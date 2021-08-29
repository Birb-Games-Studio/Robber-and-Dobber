using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerInputReferences;
using NaughtyAttributes;

public class Trap : MonoBehaviour
{
    [Header("Debug")]

    public bool showReachRangeSphere;
    [ShowIf("showReachRangeSphere")]
    public Color trapReachRangeDebugColor;
    [ShowIf("requieresActivation")]
    public bool showActivationReach;
    [ShowIf(EConditionOperator.And, "showActivationReach", "requieresActivation")]
    public Color trapActivationReachRangeDebugColor;
    public bool showInteractionReach;
    [ShowIf("showInteractionReach")]
    public Color trapInteractionReachRangeDebugColor;

    public bool isSet;
    public bool isPickedUp;
    public bool wasUsed;
    public bool playerInRange;
    public bool robberInRange;
    public PlayerControls dobberControls;
    public InputReferences inputReferences;
    public RobberStatHandler robberStatHandler;
    public GameObject robberGO;
    public Material unsetMaterial;
    public Material setMaterial;
    public DobberIK dobberIK;
    public Rigidbody dobberTrapAnchor;
    public Transform dobberHeadTarget;
    public SpringJoint trapSpring;
    float interacted;

    [Header("Trap settings")]

    public LayerMask player;
    public LayerMask robber;

    [Dropdown("trapTypes")]
    public string trapType;
    private string[] trapTypes = new string[] { "Pins", "Rope", "Ladder", "Bear Trap", "Bannana Peel" };

    public bool linkAllOffsets;

    [ShowIf("linkAllOffsets")]
    public Vector3 masterOffset;
    
    [HideIf("linkAllOffsets")]
    public Vector3 trapInteractionRadiusOffset;
    public float trapInteractionRadius;

    [ShowIf(EConditionOperator.And, "!linkAllOffsets", "requieresActivation")]
    public Vector3 trapActivationRangeOffset;
    [ShowIf("requieresActivation")]
    public float trapActivationRange;
    
    [HideIf("linkAllOffsets")]
    public Vector3 trapRangeOffset;
    public float trapRange;
    public bool hasActivationDelay;

    [Header("robber stat change")]
    public int miniDamage;
    public int maxDamage;
    public int miniFear;
    public int maxFear;
    public int miniAnger;
    public int maxAnger;

    [ShowIf("hasActivationDelay")]
    public float trapActivationDelay;
    public bool requieresActivation;
    public bool isReusable;
    public bool requieresPlayer;


    void OnDrawGizmos()
    {
        if (linkAllOffsets)
        {
            trapInteractionRadiusOffset = masterOffset;
            trapActivationRangeOffset = masterOffset;
            trapRangeOffset = masterOffset;
        }

        //draw interaction sphere
        if (showInteractionReach)
        {
            Gizmos.color = trapInteractionReachRangeDebugColor;
            Gizmos.DrawWireSphere(transform.position + trapInteractionRadiusOffset, trapInteractionRadius);
        }
        

        //draw activation range
        if (showActivationReach && requieresActivation)
        {
            Gizmos.color = trapActivationReachRangeDebugColor;
            Gizmos.DrawSphere(transform.position + trapActivationRangeOffset, trapActivationRange);
        }
        
        
        //draw effect range
        if (showReachRangeSphere)
        {
            Gizmos.color = trapReachRangeDebugColor;
            Gizmos.DrawSphere(transform.position + trapActivationRangeOffset, trapRange);
        }

    }

    private void Awake()
    {
        dobberControls = new PlayerControls();
        dobberControls.Enable();
    }

    private void FixedUpdate()
    {
        if (Physics.CheckSphere(transform.position + trapInteractionRadiusOffset, trapInteractionRadius, player))
        {
            playerInRange = true;
        }
        else
        {
            playerInRange = false;
        }

        if (Physics.CheckSphere(transform.position + trapRangeOffset, trapRange, robber))
        {

            robberInRange = true;

            if (!isPickedUp && isSet)
            {
                // private string[] trapTypes = new string[] { "Pins", "Rope", "Ladder", "Bear Trap", "Bannana Peel" };
                switch (trapType)
                {
                    case "Pins":
                        DealDamage();
                        AddAnger();
                        wasUsed = true;
                        break;

                    case "Rope":
                        AddAnger();
                        wasUsed = true;

                        break;

                    case "Ladder":
                        DealDamage();
                        wasUsed = true;
                        break;

                    case "Bear Trap":
                        Animator bearTrapAnims = GetComponentInChildren<Animator>();
                        bearTrapAnims.SetBool("trapTriggered", true);
                        Rigidbody bearRb = GetComponent<Rigidbody>();
                        bearRb.isKinematic = true;
                        bearRb.useGravity = false;
                        gameObject.transform.parent = robberGO.transform;
                        AddFear();
                        DealDamage();
                        wasUsed = true;
                        break;

                    case "Bannana Peel":
                        Rigidbody bananaRb = GetComponent<Rigidbody>();
                        robberGO.transform.position = gameObject.transform.position;
                        bananaRb.AddForce(transform.forward * 10000);
                        AddFear();
                        AddAnger();
                        robberGO.transform.position = robberGO.transform.position;
                        wasUsed = true;
                        break;

                    default:
                        Debug.LogError("Unknown trap type. Make sure it's added to the switch statement in FixedUpdate, and not just the context menu. And make sure there aren't any types *looks at nimfer* [from nimfer: *typos not types  :) ]", this);
                        break;
                }
            }
            
        }
        else
        {
            robberInRange = false;
            if (isReusable)
            {
                wasUsed = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        interacted = inputReferences.playerControls.DobberControls.Interact.ReadValue<float>();

        if (playerInRange && !isSet)
        {
            dobberControls.DobberControls.InteractAlt.performed += ctx => 
            {
                if (!isSet)
                {
                    Debug.Log("Trap is set.");
                    isSet = true;
                }
            };

            dobberControls.DobberControls.Interact.performed += ctx =>
            {
                if (!isPickedUp && playerInRange)
                {
                    isPickedUp = true;
                    isSet = false;
                }
            };

            dobberControls.DobberControls.Interact.canceled += ctx =>
            {
                if (isPickedUp)
                {
                    Debug.Log("Trap released");
                    isPickedUp = false;
                }
            };

        }


        if (isPickedUp)
        {

            Vector3 startPose = dobberHeadTarget.position;
            Vector3 endPose = new Vector3(dobberHeadTarget.position.x, transform.position.y, dobberHeadTarget.position.z);

            dobberIK.useHeadIK = false;
            dobberHeadTarget.position = Vector3.Lerp(startPose, endPose, 100f);
            trapSpring.connectedBody = dobberTrapAnchor;
        }
        else
        {
            dobberIK.useHeadIK = true;
            trapSpring.connectedBody = null;
        }
        
    }

    void DealDamage()
    {
        if (!wasUsed)
        {
            int randomDamage = Random.Range(miniDamage, maxDamage);
            robberStatHandler.health = robberStatHandler.health - randomDamage;
            Debug.Log(randomDamage);

        }
    }

    void AddFear()
    {
        if (!wasUsed)
        {
            int randomFear = Random.Range(miniFear, maxFear);
            robberStatHandler.fear = robberStatHandler.fear  + randomFear;
            Debug.Log(randomFear);

        }
    }

    void AddAnger()
    {
        if (!wasUsed)
        {
            int randomAnger = Random.Range(miniAnger, maxAnger);
            robberStatHandler.anger = robberStatHandler.anger + randomAnger;
            Debug.Log(randomAnger);

        }
    }
}
