// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/scripts_inputs/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""MouseAction"",
            ""id"": ""613768bb-225b-49b4-8b49-60d59b516bb9"",
            ""actions"": [
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""54948409-f038-4bee-b62d-90a7d90544bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""1c50de4f-c315-4f9f-8849-fb1e286b0c52"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""c290ba24-e372-4ee2-8513-a65d3b14c3a6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Delta"",
                    ""type"": ""Value"",
                    ""id"": ""8888d98c-9e0d-494d-b790-51669fdf16cb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0e29cfe7-f8dd-484a-9f68-ef961a79bb30"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34262150-b927-4ffb-9775-58191e2e1248"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10afbfcb-0b72-4c53-981a-696f63df38ab"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9d22561-13f6-4654-a2c1-d83c34057288"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Delta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MouseAction
        m_MouseAction = asset.FindActionMap("MouseAction", throwIfNotFound: true);
        m_MouseAction_LeftClick = m_MouseAction.FindAction("LeftClick", throwIfNotFound: true);
        m_MouseAction_RightClick = m_MouseAction.FindAction("RightClick", throwIfNotFound: true);
        m_MouseAction_Position = m_MouseAction.FindAction("Position", throwIfNotFound: true);
        m_MouseAction_Delta = m_MouseAction.FindAction("Delta", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // MouseAction
    private readonly InputActionMap m_MouseAction;
    private IMouseActionActions m_MouseActionActionsCallbackInterface;
    private readonly InputAction m_MouseAction_LeftClick;
    private readonly InputAction m_MouseAction_RightClick;
    private readonly InputAction m_MouseAction_Position;
    private readonly InputAction m_MouseAction_Delta;
    public struct MouseActionActions
    {
        private @InputActions m_Wrapper;
        public MouseActionActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftClick => m_Wrapper.m_MouseAction_LeftClick;
        public InputAction @RightClick => m_Wrapper.m_MouseAction_RightClick;
        public InputAction @Position => m_Wrapper.m_MouseAction_Position;
        public InputAction @Delta => m_Wrapper.m_MouseAction_Delta;
        public InputActionMap Get() { return m_Wrapper.m_MouseAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActionActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActionActions instance)
        {
            if (m_Wrapper.m_MouseActionActionsCallbackInterface != null)
            {
                @LeftClick.started -= m_Wrapper.m_MouseActionActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_MouseActionActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_MouseActionActionsCallbackInterface.OnLeftClick;
                @RightClick.started -= m_Wrapper.m_MouseActionActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_MouseActionActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_MouseActionActionsCallbackInterface.OnRightClick;
                @Position.started -= m_Wrapper.m_MouseActionActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_MouseActionActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_MouseActionActionsCallbackInterface.OnPosition;
                @Delta.started -= m_Wrapper.m_MouseActionActionsCallbackInterface.OnDelta;
                @Delta.performed -= m_Wrapper.m_MouseActionActionsCallbackInterface.OnDelta;
                @Delta.canceled -= m_Wrapper.m_MouseActionActionsCallbackInterface.OnDelta;
            }
            m_Wrapper.m_MouseActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
                @Delta.started += instance.OnDelta;
                @Delta.performed += instance.OnDelta;
                @Delta.canceled += instance.OnDelta;
            }
        }
    }
    public MouseActionActions @MouseAction => new MouseActionActions(this);
    public interface IMouseActionActions
    {
        void OnLeftClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnPosition(InputAction.CallbackContext context);
        void OnDelta(InputAction.CallbackContext context);
    }
}
