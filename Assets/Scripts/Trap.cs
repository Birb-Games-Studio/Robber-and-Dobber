using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public bool isSet;

    public Material unsetMaterial;
    public Material setMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){

        if(other.tag == "Player" && !isSet){
            Debug.Log("Set the trap.");
            isSet = true;
            this.GetComponent<MeshRenderer>().sharedMaterial = setMaterial;
        }        
        if(other.tag == "Robber" && isSet){
            Debug.Log("The robber set off the trap.");
            isSet = false;
            this.GetComponent<MeshRenderer>().sharedMaterial = unsetMaterial;
        }
    }
}
