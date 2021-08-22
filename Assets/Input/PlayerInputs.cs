// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""AlivePlayer"",
            ""id"": ""8bf94838-9ca8-42b3-a990-4f60c8abff20"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""1f800577-0c5e-4125-b4ed-47b70445a516"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""daed06f5-23cd-462a-9f1c-ae74c10af2e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Value"",
                    ""id"": ""c6cc6b10-290e-4686-a68f-9ba33347989c"",
                    ""expectedControlType"": ""Integer"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""87fa7a14-c047-4e6a-a340-eaecf0ebd43e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""ddaef88e-bbd6-45b6-80e8-698a200cbb67"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""62607822-e17b-4d69-ba88-0b72852efbb1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2b55ccd-6229-4924-8f77-3051fd9a651a"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdf0eefc-47dc-4cc7-ab01-a45a893be2e7"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Android phone"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b08fd5b1-47d3-455b-b53f-eabd8ddfafbb"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b167e894-11ae-4cda-ab81-4fabb553497a"",
                    ""path"": ""<XInputController>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5816720f-ce42-4c0c-8af6-196a76d90562"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Android phone"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0caeaf20-383a-4ba6-a532-7ef1afdf4a8e"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f25379a3-e24b-42e5-b333-05e83cb552d3"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b4dd341-db48-46a3-904a-5cfffef028f7"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Android phone"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b857737-329d-4cb7-b82d-33c3d1b15a7f"",
                    ""path"": ""<Touchscreen>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Android phone"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""458610ce-2bc7-4bf3-9965-2ab4384682e6"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c90411b-43e6-4cc5-9f70-6184fe64db7f"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1877ae4c-1937-4948-b7e8-2a3b4a90b337"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Android phone"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WSAD"",
                    ""id"": ""877f83bc-2ed2-4fe6-864e-a27d135ff257"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ba28d7f2-c6b8-4af9-bac1-e77f67fab80a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a2a78432-d184-4721-b73d-b617de497476"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""33ba911f-72c4-4cd3-8db8-ed6e534f70b4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""73a94fd7-8940-4454-9d2c-3454092c36dc"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bca74622-720e-43ed-a499-4b2fddeff35d"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6c8788f-4ad0-4741-a901-4e5c7e3f6891"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Android phone"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardAndMouse"",
            ""bindingGroup"": ""KeyboardAndMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XboxController"",
            ""bindingGroup"": ""XboxController"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<AndroidGamepadXboxController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Android phone"",
            ""bindingGroup"": ""Android phone"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<AndroidGamepadXboxController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // AlivePlayer
        m_AlivePlayer = asset.FindActionMap("AlivePlayer", throwIfNotFound: true);
        m_AlivePlayer_Move = m_AlivePlayer.FindAction("Move", throwIfNotFound: true);
        m_AlivePlayer_Jump = m_AlivePlayer.FindAction("Jump", throwIfNotFound: true);
        m_AlivePlayer_Crouch = m_AlivePlayer.FindAction("Crouch", throwIfNotFound: true);
        m_AlivePlayer_Look = m_AlivePlayer.FindAction("Look", throwIfNotFound: true);
        m_AlivePlayer_Pause = m_AlivePlayer.FindAction("Pause", throwIfNotFound: true);
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

    // AlivePlayer
    private readonly InputActionMap m_AlivePlayer;
    private IAlivePlayerActions m_AlivePlayerActionsCallbackInterface;
    private readonly InputAction m_AlivePlayer_Move;
    private readonly InputAction m_AlivePlayer_Jump;
    private readonly InputAction m_AlivePlayer_Crouch;
    private readonly InputAction m_AlivePlayer_Look;
    private readonly InputAction m_AlivePlayer_Pause;
    public struct AlivePlayerActions
    {
        private @PlayerInputs m_Wrapper;
        public AlivePlayerActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_AlivePlayer_Move;
        public InputAction @Jump => m_Wrapper.m_AlivePlayer_Jump;
        public InputAction @Crouch => m_Wrapper.m_AlivePlayer_Crouch;
        public InputAction @Look => m_Wrapper.m_AlivePlayer_Look;
        public InputAction @Pause => m_Wrapper.m_AlivePlayer_Pause;
        public InputActionMap Get() { return m_Wrapper.m_AlivePlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AlivePlayerActions set) { return set.Get(); }
        public void SetCallbacks(IAlivePlayerActions instance)
        {
            if (m_Wrapper.m_AlivePlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_AlivePlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_AlivePlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_AlivePlayerActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_AlivePlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_AlivePlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_AlivePlayerActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_AlivePlayerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_AlivePlayerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_AlivePlayerActionsCallbackInterface.OnCrouch;
                @Look.started -= m_Wrapper.m_AlivePlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_AlivePlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_AlivePlayerActionsCallbackInterface.OnLook;
                @Pause.started -= m_Wrapper.m_AlivePlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_AlivePlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_AlivePlayerActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_AlivePlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public AlivePlayerActions @AlivePlayer => new AlivePlayerActions(this);
    private int m_KeyboardAndMouseSchemeIndex = -1;
    public InputControlScheme KeyboardAndMouseScheme
    {
        get
        {
            if (m_KeyboardAndMouseSchemeIndex == -1) m_KeyboardAndMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardAndMouse");
            return asset.controlSchemes[m_KeyboardAndMouseSchemeIndex];
        }
    }
    private int m_XboxControllerSchemeIndex = -1;
    public InputControlScheme XboxControllerScheme
    {
        get
        {
            if (m_XboxControllerSchemeIndex == -1) m_XboxControllerSchemeIndex = asset.FindControlSchemeIndex("XboxController");
            return asset.controlSchemes[m_XboxControllerSchemeIndex];
        }
    }
    private int m_AndroidphoneSchemeIndex = -1;
    public InputControlScheme AndroidphoneScheme
    {
        get
        {
            if (m_AndroidphoneSchemeIndex == -1) m_AndroidphoneSchemeIndex = asset.FindControlSchemeIndex("Android phone");
            return asset.controlSchemes[m_AndroidphoneSchemeIndex];
        }
    }
    public interface IAlivePlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
