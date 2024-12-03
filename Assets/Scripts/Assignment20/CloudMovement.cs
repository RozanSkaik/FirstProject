using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment20
{
    public class CloudMovement : MonoBehaviour
    {
        public float movementAmount = 0.0004f;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.position += new Vector3(movementAmount, 0, 0);
        }
    }
}