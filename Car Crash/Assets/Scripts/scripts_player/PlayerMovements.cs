using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game_ideas
{
    public class PlayerMovements : MonoBehaviour
    {

        [HideInInspector] public Rigidbody _rigidbody;

        public void Accelerate(float speed)
        {
            _rigidbody.velocity = transform.forward * speed;
        }

        public void TurnLeft(float speed)
        {
            _rigidbody.angularVelocity = new Vector3(0f, -(speed * Mathf.Deg2Rad), 0f);
        }

        public void TurnRight(float speed)
        {
            _rigidbody.angularVelocity = new Vector3(0f, speed * Mathf.Deg2Rad, 0f);
        }

        public void ResetTurn()
        {
            _rigidbody.angularVelocity = Vector3.zero;
        }

    }
}
