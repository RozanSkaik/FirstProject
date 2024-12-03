using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment20
{
    public class Horse : MonoBehaviour
    {
        public Vector3 scaleFactor = new Vector3(0.005f, 0.005f, 0.005f);
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.Z))
            {
                transform.localScale += scaleFactor;
            }
            if (Input.GetKey(KeyCode.X))
            {
                transform.localScale -= scaleFactor;
            }

        }
    }
}