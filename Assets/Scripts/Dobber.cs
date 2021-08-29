using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerInputReferences;

//requiered components
[RequireComponent(typeof(Rigidbody))]
public class Dobber : MonoBehaviour
{
    public Animator dobberAnimator;
    Rigidbody rb;
    public InputReferences inputReferences;
    public PlayerControls playerControls;
    float moveHorizontal;
    float moveVertical;
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float sprintSpeed;
    [SerializeField]
    float turnSpeed;
    float isRunning;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerControls = new PlayerControls();
        playerControls.DobberControls.Enable();
    }

    private void FixedUpdate()
    {
        Move();

    }

    void Update()
    {
#region calls to other voids
        Inputs();
        #endregion

        inputReferences.playerControls.DobberControls.ExitGame.performed += ctx => { Application.Quit(); };
    }

    //this void assignes values to input virables
    void Inputs()
    {
        //reading the Vector2 value and assigning it to moveHorizontal and moveVertical
        moveHorizontal = inputReferences.playerControls.DobberControls.Walk.ReadValue<Vector2>().x;
        moveVertical = inputReferences.playerControls.DobberControls.Walk.ReadValue<Vector2>().y;
        isRunning = inputReferences.playerControls.DobberControls.Run.ReadValue<float>();

    }

    Vector3 move;

    void Move()
    {

        //new Vector3 for calculating movement values
        Quaternion rotate = Quaternion.Euler(transform.rotation.x, moveHorizontal * turnSpeed, transform.rotation.z);
        //here we apply the movement related to the rotation of player
        switch (isRunning)
        {
            case 1:
                move = new Vector3(0, rb.velocity.y, moveVertical * sprintSpeed);
                dobberAnimator.SetBool("ReadyToRun", true);
                if (move.y == 0 && move.x == 0 && move.z == 0)
                {
                    dobberAnimator.SetBool("Moving", false);
                }
                else
                {
                    dobberAnimator.SetBool("Moving", true);
                }                
                break;
            case 0:
                move = new Vector3(0, rb.velocity.y, moveVertical * moveSpeed);
                dobberAnimator.SetBool("ReadyToRun", false);
                if (move.y == 0 && move.x == 0 && move.z == 0)
                {
                    dobberAnimator.SetBool("Moving", false);
                }
                else
                {
                    dobberAnimator.SetBool("Moving", true);
                }
                break;
        }
        rb.velocity = transform.right * move.x + transform.up * move.y + transform.forward * move.z;
        gameObject.transform.rotation = transform.rotation * rotate;


    }
}
