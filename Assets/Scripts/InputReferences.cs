using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PlayerInputReferences
{
    public class InputReferences : MonoBehaviour
    {
        public PlayerControls playerControls;
        private void Awake()
        {
            playerControls = new PlayerControls();
            playerControls.DobberControls.Enable();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
