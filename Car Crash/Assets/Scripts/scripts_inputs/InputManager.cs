using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace game_ideas
{
    public class InputManager : MonoBehaviour
    {

        private InputActions inputActions;

        private PlayerManager playerManager;

        private void Awake()
        {
            inputActions = new InputActions();
        }

        private void OnEnable()
        {
            inputActions.Enable();
        }

        private void OnDisable()
        {
            inputActions.Disable();
        }

        private void Start()
        {
            playerManager = PlayerManager.GetInstance();

            inputActions.MouseAction.LeftClick.started += context => StartLeftClick(context);
            inputActions.MouseAction.LeftClick.canceled += context => EndLeftClick(context);

            inputActions.MouseAction.RightClick.started += context => StartRightClick(context);
            inputActions.MouseAction.RightClick.canceled += context => EndRightClick(context);
        }

        private void StartLeftClick(InputAction.CallbackContext context)
        {
            playerManager.turnLeft = true;
        }

        private void EndLeftClick(InputAction.CallbackContext context)
        {
            playerManager.turnLeft = false;
        }

        private void StartRightClick(InputAction.CallbackContext context)
        {
            playerManager.turnRight = true;
        }

        private void EndRightClick(InputAction.CallbackContext context)
        {
            playerManager.turnRight = false;
        }

    }
}
