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

    void Awake()
    {
        //i don't know why dose need to reference it's self but it's requiered to work
        playerControls = new PlayerControls();
        //automatically find rigidbody in character
        rb = gameObject.GetComponent<Rigidbody>();
        //lock rotation of the rigidbody
        rb.constraints = RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationX;
        //here we enable controlls for Dobber character
        playerControls.DobberControls.Enable();
    }

    void Update()
    {
        #region calls to other voids
        Inputs();
        Move();
        #endregion
    }

    //this void assignes values to input virables
    void Inputs()
    {
        //reading the Vector2 value and assigning it to moveHorizontal and moveVertical
        moveHorizontal = playerControls.DobberControls.Walk.ReadValue<Vector2>().x;
        moveVertical = playerControls.DobberControls.Walk.ReadValue<Vector2>().y;

    }

    void Move()
    {
        //new Vector3 for calculating movement values
        Vector3 move = new Vector3(moveHorizontal * 100 * moveSpeed * Time.deltaTime, rb.velocity.y, moveVertical * 100 * moveSpeed * Time.deltaTime);
        //here we apply the movement related to the rotation of player
        rb.velocity = transform.right * move.x + transform.up * move.y + transform.forward * move.z;

    }
}
