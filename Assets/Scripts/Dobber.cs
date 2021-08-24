using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//requiered components
[RequireComponent(typeof(Rigidbody))]
public class Dobber : MonoBehaviour
{
    Rigidbody rb;
    PlayerControls playerControls;
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
        playerControls = new PlayerControls();
        rb = gameObject.GetComponent<Rigidbody>();
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
    }

    //this void assignes values to input virables
    void Inputs()
    {
        //reading the Vector2 value and assigning it to moveHorizontal and moveVertical
        moveHorizontal = playerControls.DobberControls.Walk.ReadValue<Vector2>().x;
        moveVertical = playerControls.DobberControls.Walk.ReadValue<Vector2>().y;
        isRunning = playerControls.DobberControls.Run.ReadValue<float>();

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
                break;
            case 0:
                move = new Vector3(0, rb.velocity.y, moveVertical * moveSpeed);
                break;
        }
        rb.velocity = transform.right * move.x + transform.up * move.y + transform.forward * move.z;
        gameObject.transform.rotation = transform.rotation * rotate;


    }
}
