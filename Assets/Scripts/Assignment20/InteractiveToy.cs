using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment20
{
    public class InteractiveToy : MonoBehaviour
    {
        public float movementAmount = 0.01f;
        public float rotateAmount = 0f;

        public float horizontalSpeed = 2.0f;
        void Start()
        {

        }

        void Update()
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(movementAmount, 0, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= new Vector3(movementAmount, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += new Vector3(0, 0, movementAmount);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position -= new Vector3(0, 0, movementAmount);
            }
            if (Input.mouseScrollDelta.y > 0)
            {
                rotateAmount += 1;
                transform.rotation = Quaternion.Euler(new Vector3(0, rotateAmount, 0));
            }
            if (Input.mouseScrollDelta.y < 0)
            {
                rotateAmount -= 1;
                transform.rotation = Quaternion.Euler(new Vector3(0, rotateAmount, 0));
            }

            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            transform.Rotate(0, -h, 0); //to rotate object with mouse X 

        }
    }
}