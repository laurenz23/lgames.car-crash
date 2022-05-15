using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game_ideas
{
    public class PlayerManager : MonoBehaviour
    {

        private static PlayerManager instance;

        public static PlayerManager GetInstance()
        {
            return instance;
        }

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        [HideInInspector]
        public bool turnLeft;

        [HideInInspector]
        public bool turnRight;

        [SerializeField] private float speed;
        [SerializeField] private float turnSpeed;

        [Header("Script Reference")]
        [SerializeField] private PlayerMovements playerMovements;

        private Rigidbody _rigidbody;

        // Start is called before the first frame update
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();

            playerMovements._rigidbody = _rigidbody;
        }

        // Update is called once per frame
        void Update()
        {
            playerMovements.Accelerate(speed);

            if (turnLeft && turnRight)
            {
                // movement forward
            }
            else if (turnLeft)
            {
                playerMovements.TurnLeft(turnSpeed);
            }
            else if (turnRight)
            {
                playerMovements.TurnRight(turnSpeed);
            }
            else
            {
                playerMovements.ResetTurn();
            }
        }
    }
}
