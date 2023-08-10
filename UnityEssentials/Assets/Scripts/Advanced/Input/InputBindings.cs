//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/Advanced/Input/InputBindings.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputBindings : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputBindings()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputBindings"",
    ""maps"": [
        {
            ""name"": ""Keyboard"",
            ""id"": ""140c6c2a-f84f-41ff-856e-1212ef91b984"",
            ""actions"": [
                {
                    ""name"": ""WASDMovement"",
                    ""type"": ""Value"",
                    ""id"": ""a0bd70d6-8d1a-453f-9d84-a6c61277bf55"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""3db47d7d-e10a-4475-8455-2dc0d17c981b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""48451916-f780-47b4-9338-fdc5f0c77283"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Axis"",
                    ""id"": ""fbe435ff-f584-4537-9f97-1f56ba6f04e1"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASDMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b07a543e-28ea-4ddf-b78e-22536ed84a3d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASDMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5a505be8-9c17-4133-bfb2-99644069e348"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASDMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3b2fab2a-17f3-4453-8239-228c60c36a7a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASDMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c4bdd82a-b61d-4373-ba40-b79c040b08f1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASDMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b50695d9-55c7-4bc4-b1f0-bb12a29bd0f2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d04affa7-f5c3-4165-b60c-b3c30834edcd"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Keyboard
        m_Keyboard = asset.FindActionMap("Keyboard", throwIfNotFound: true);
        m_Keyboard_WASDMovement = m_Keyboard.FindAction("WASDMovement", throwIfNotFound: true);
        m_Keyboard_Jump = m_Keyboard.FindAction("Jump", throwIfNotFound: true);
        m_Keyboard_Crouch = m_Keyboard.FindAction("Crouch", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Keyboard
    private readonly InputActionMap m_Keyboard;
    private IKeyboardActions m_KeyboardActionsCallbackInterface;
    private readonly InputAction m_Keyboard_WASDMovement;
    private readonly InputAction m_Keyboard_Jump;
    private readonly InputAction m_Keyboard_Crouch;
    public struct KeyboardActions
    {
        private @InputBindings m_Wrapper;
        public KeyboardActions(@InputBindings wrapper) { m_Wrapper = wrapper; }
        public InputAction @WASDMovement => m_Wrapper.m_Keyboard_WASDMovement;
        public InputAction @Jump => m_Wrapper.m_Keyboard_Jump;
        public InputAction @Crouch => m_Wrapper.m_Keyboard_Crouch;
        public InputActionMap Get() { return m_Wrapper.m_Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardActions instance)
        {
            if (m_Wrapper.m_KeyboardActionsCallbackInterface != null)
            {
                @WASDMovement.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnWASDMovement;
                @WASDMovement.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnWASDMovement;
                @WASDMovement.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnWASDMovement;
                @Jump.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnCrouch;
            }
            m_Wrapper.m_KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @WASDMovement.started += instance.OnWASDMovement;
                @WASDMovement.performed += instance.OnWASDMovement;
                @WASDMovement.canceled += instance.OnWASDMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
            }
        }
    }
    public KeyboardActions @Keyboard => new KeyboardActions(this);
    public interface IKeyboardActions
    {
        void OnWASDMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
    }
}