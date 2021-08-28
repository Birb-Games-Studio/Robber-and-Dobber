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
    public bool showActivationReach;
    [ShowIf("showActivationReach")]
    public Color trapActivationReachRangeDebugColor;
    public bool showInteractionReach;
    [ShowIf("showInteractionReach")]
    public Color trapInteractionReachRangeDebugColor;

    public bool isSet;
    public bool isActivated;
    public bool playerInRange;
    public bool robberInRange;
    public PlayerControls dobberControls;
    public InputReferences inputReferences;
    public Material unsetMaterial;
    public Material setMaterial;
    float interacted;

    [Header("Trap settings")]

    public LayerMask player;
    public LayerMask robber;

    [Dropdown("trapTypes")]
    public string trapType;
    private string[] trapTypes = new string[] { "Pinns", "Rope", "Ladder", "Bear Trap", "Bannana Peal" };

    public bool linkAllOffsets;

    [ShowIf("linkAllOffsets")]
    public Vector3 masterOffset;
    
    [HideIf("linkAllOffsets")]
    public Vector3 trapInteractionRadiusOffset;
    public float trapInteractionRadius;
    
    [HideIf("linkAllOffsets")]
    public Vector3 trapActivationRangeOffset;
    public float trapActivationRange;
    
    [HideIf("linkAllOffsets")]
    public Vector3 trapRangeOffset;
    public float trapRange;
    public bool hasActivationDelay;
    
    [ShowIf("hasActivationDelay")]
    public float trapActivationDelay;
    public bool isRechargable;
    
    [ShowIf("isRechargable")]
    public float rechargeTime;
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
        if (showActivationReach)
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

        if (Physics.CheckSphere(transform.position + trapInteractionRadiusOffset, trapInteractionRadius, player))
        {

            playerInRange = true;

        }
        else
        {
            playerInRange = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        interacted = inputReferences.playerControls.DobberControls.Interact.ReadValue<float>();

        if (playerInRange)
        {
            switch (interacted)
            {
                case 1:
                    Debug.Log("trap collected");
                    isSet = false;
                    GetComponent<MeshRenderer>().sharedMaterial = setMaterial;
                    break;
                case 0:
                    //Debug.Log("player in range");
                    break;
            }
        }

        if (robberInRange)
        {
            Debug.Log("The robber set off the trap");
            isActivated = true;
            GetComponent<MeshRenderer>().sharedMaterial = unsetMaterial;
        }
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInRange = true;
        }
        else
        {
            playerInRange = false;
        }

        if (other.tag == "Robber" && isSet)
        {
            robberInRange = true;
        }
        else
        {
            robberInRange = false;
        }
    }
}
