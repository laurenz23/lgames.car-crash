using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game_ideas
{
    public class CameraManager : MonoBehaviour
    {

        [SerializeField] private Camera currentCamera;
        [SerializeField] private Transform trackObject;

        private void Start()
        {
            trackObject = PlayerManager.GetInstance().transform;
        }

        private void LateUpdate()
        {
            transform.position = trackObject.position;
        }
        public Camera GetCurrentCamera()
        {
            return currentCamera;
        }

    }
}
