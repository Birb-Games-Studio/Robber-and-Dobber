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
        playerControls = new PlayerControls();
        //automatically find rigidbody in character
        rb = gameObject.GetComponent<Rigidbody>();
        //lock rotation or the rigidbody
        rb.constraints = RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationX;
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
        moveHorizontal = playerControls.DobberControls.Walk.ReadValue<Vector2>().x;
        moveVertical = playerControls.DobberControls.Walk.ReadValue<Vector2>().y;

    }

    void Move()
    {

        Vector3 move = new Vector3(moveHorizontal * 100 * moveSpeed * Time.deltaTime, rb.velocity.y, moveVertical * 100 * moveSpeed * Time.deltaTime);
        rb.velocity = transform.right * move.x + transform.up * move.y + transform.forward * move.z;

    }
}
