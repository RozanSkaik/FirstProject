using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment37
{
    public class RigidBodyCharacterController : MonoBehaviour
    {
        Rigidbody rigidbodyComponent;
        Vector3 velocityVector;
        public float moveSpeed = 5f;
        public float jumpSpeed = 5f;
        private bool isJump = false;

        void Start()
        {
            SetRigidbodySettings();
        }

        private void SetRigidbodySettings()
        {
            rigidbodyComponent = GetComponent<Rigidbody>();
            rigidbodyComponent.freezeRotation = true;
            rigidbodyComponent.mass = 1;
        }

        void Update()
        {
            SetVelocityVector();
            if (Input.GetKeyDown(KeyCode.Space))
                isJump = true;
        }

        void FixedUpdate()
        {
            if (isJump)
            {
                rigidbodyComponent.drag = 0.5f;
                rigidbodyComponent.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
                isJump = false;
            }
            else
            {
                rigidbodyComponent.drag = 0f;
                rigidbodyComponent.velocity = velocityVector;
            }
        }
        private void SetVelocityVector()
        {
            velocityVector = new Vector3(Input.GetAxis("Horizontal"),
                                                 0,
                                                Input.GetAxis("Vertical")).normalized * moveSpeed;
            velocityVector.y = rigidbodyComponent.velocity.y;
        }
    }
}