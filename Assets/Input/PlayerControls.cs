// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""MasterControls"",
            ""id"": ""f7565937-e528-462b-9ded-16dfb905f7c3"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""be6e786e-2b78-4d6e-8127-2deef24b4da0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""02c63c97-1d3a-431b-a604-dbf8c15eb9ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""5dab8e0d-08a2-4d69-a730-8dbe1a2a992c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""d589d313-c622-4b03-b51b-db3c83a09d8c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WSAD"",
                    ""id"": ""4e0b432b-0bd7-460e-be7e-2888aa8a36a2"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""316dc81b-17db-443f-8875-1da1a9e0b72e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a3207824-c110-4062-a439-05559ff4cad8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""55ee6c45-0320-4a48-ba88-896eaf94b8aa"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f0fc1dc0-22b4-46a7-b339-4ca6435b0d6c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""022e351f-8d17-4d16-b6d9-c543e28afae4"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26f1fb67-35b0-47a9-b5a2-bfe3b6fccb98"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ec6d248-a48a-4fbf-963b-37d54822b275"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""DobberControls"",
            ""id"": ""6cdda2bd-a80a-4696-8ba5-41608337acf2"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""cd18a080-0387-4235-ba68-0a023e151c88"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Value"",
                    ""id"": ""d1f99bf2-4c7d-4878-a413-914bf7c51c52"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sneak"",
                    ""type"": ""Button"",
                    ""id"": ""1bdefbcf-0beb-4e0e-be62-4b8157689964"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Value"",
                    ""id"": ""441a993f-cce4-4bfb-93b1-5a5a64659cc2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""7cf33650-4b55-4349-a6f9-7fec79820a36"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ArmTrap"",
                    ""type"": ""Button"",
                    ""id"": ""fb854b7a-e668-4da2-881f-a497ea520985"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WSAD"",
                    ""id"": ""b435ffd3-dc4b-4387-a8f2-9bdfb8d858e3"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6211f3a6-dd1c-478d-a9ec-f9b5daaf1ab1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6290538a-488c-4818-b29b-53aed95c6def"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ca56b909-a482-4a49-8920-84eccc8bb488"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a5e61916-29f7-4e2b-a7fd-ff7748860c37"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e4518da1-34f2-46c2-bce5-5942715a52fc"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""871adb62-ef9d-4318-a874-e5a063372311"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Sneak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""964fc1d3-50fd-40e6-999f-07835ad88e99"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0b907e8-18ca-4802-a127-77635ac1edd9"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a9e47c1-be56-4466-aa0e-e22ba0fe4a4b"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArmTrap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""RobberControls"",
            ""id"": ""df3ddd27-042e-48f5-bd04-39cc10d2b2cb"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""59046b81-f653-491e-b8b9-af2c883e02db"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""69ee7372-2696-46da-9509-502226ef84b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sneak"",
                    ""type"": ""Button"",
                    ""id"": ""0b89a625-3982-4246-9dca-7249224dec58"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""0499cf13-679b-4975-a6d6-ef9f8110148c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""c367ad4e-5750-442b-b745-c42b4627cc32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WSAD"",
                    ""id"": ""cb9c099e-be7d-44c2-bae7-03258e32b608"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2df70612-7fbf-4236-8f3f-14f07bc258a9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0cb7d7fb-2f4d-4eee-92d8-99eb1ae3e2ab"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d04c7d8e-f2a0-4934-a14c-e1d1b4a5fadc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c1fcc34f-2a2d-4c76-992b-847ae9b56e94"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bf5c5cf6-d682-4d79-9398-7c8157a1cfb3"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9983075-2265-4046-9ea0-97cb8995b4de"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3527d055-f90d-4179-ac97-fced57907127"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Sneak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2dbdb402-f96a-4e7a-9eba-11b55f73b23f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
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
        }
    ]
}");
        // MasterControls
        m_MasterControls = asset.FindActionMap("MasterControls", throwIfNotFound: true);
        m_MasterControls_Walk = m_MasterControls.FindAction("Walk", throwIfNotFound: true);
        m_MasterControls_Run = m_MasterControls.FindAction("Run", throwIfNotFound: true);
        m_MasterControls_Crouch = m_MasterControls.FindAction("Crouch", throwIfNotFound: true);
        m_MasterControls_Interact = m_MasterControls.FindAction("Interact", throwIfNotFound: true);
        // DobberControls
        m_DobberControls = asset.FindActionMap("DobberControls", throwIfNotFound: true);
        m_DobberControls_Walk = m_DobberControls.FindAction("Walk", throwIfNotFound: true);
        m_DobberControls_Run = m_DobberControls.FindAction("Run", throwIfNotFound: true);
        m_DobberControls_Sneak = m_DobberControls.FindAction("Sneak", throwIfNotFound: true);
        m_DobberControls_Interact = m_DobberControls.FindAction("Interact", throwIfNotFound: true);
        m_DobberControls_Attack = m_DobberControls.FindAction("Attack", throwIfNotFound: true);
        m_DobberControls_ArmTrap = m_DobberControls.FindAction("ArmTrap", throwIfNotFound: true);
        // RobberControls
        m_RobberControls = asset.FindActionMap("RobberControls", throwIfNotFound: true);
        m_RobberControls_Walk = m_RobberControls.FindAction("Walk", throwIfNotFound: true);
        m_RobberControls_Run = m_RobberControls.FindAction("Run", throwIfNotFound: true);
        m_RobberControls_Sneak = m_RobberControls.FindAction("Sneak", throwIfNotFound: true);
        m_RobberControls_Crouch = m_RobberControls.FindAction("Crouch", throwIfNotFound: true);
        m_RobberControls_Interact = m_RobberControls.FindAction("Interact", throwIfNotFound: true);
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

    // MasterControls
    private readonly InputActionMap m_MasterControls;
    private IMasterControlsActions m_MasterControlsActionsCallbackInterface;
    private readonly InputAction m_MasterControls_Walk;
    private readonly InputAction m_MasterControls_Run;
    private readonly InputAction m_MasterControls_Crouch;
    private readonly InputAction m_MasterControls_Interact;
    public struct MasterControlsActions
    {
        private @PlayerControls m_Wrapper;
        public MasterControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_MasterControls_Walk;
        public InputAction @Run => m_Wrapper.m_MasterControls_Run;
        public InputAction @Crouch => m_Wrapper.m_MasterControls_Crouch;
        public InputAction @Interact => m_Wrapper.m_MasterControls_Interact;
        public InputActionMap Get() { return m_Wrapper.m_MasterControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MasterControlsActions set) { return set.Get(); }
        public void SetCallbacks(IMasterControlsActions instance)
        {
            if (m_Wrapper.m_MasterControlsActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_MasterControlsActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_MasterControlsActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_MasterControlsActionsCallbackInterface.OnWalk;
                @Run.started -= m_Wrapper.m_MasterControlsActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_MasterControlsActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_MasterControlsActionsCallbackInterface.OnRun;
                @Crouch.started -= m_Wrapper.m_MasterControlsActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_MasterControlsActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_MasterControlsActionsCallbackInterface.OnCrouch;
                @Interact.started -= m_Wrapper.m_MasterControlsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_MasterControlsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_MasterControlsActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_MasterControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public MasterControlsActions @MasterControls => new MasterControlsActions(this);

    // DobberControls
    private readonly InputActionMap m_DobberControls;
    private IDobberControlsActions m_DobberControlsActionsCallbackInterface;
    private readonly InputAction m_DobberControls_Walk;
    private readonly InputAction m_DobberControls_Run;
    private readonly InputAction m_DobberControls_Sneak;
    private readonly InputAction m_DobberControls_Interact;
    private readonly InputAction m_DobberControls_Attack;
    private readonly InputAction m_DobberControls_ArmTrap;
    public struct DobberControlsActions
    {
        private @PlayerControls m_Wrapper;
        public DobberControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_DobberControls_Walk;
        public InputAction @Run => m_Wrapper.m_DobberControls_Run;
        public InputAction @Sneak => m_Wrapper.m_DobberControls_Sneak;
        public InputAction @Interact => m_Wrapper.m_DobberControls_Interact;
        public InputAction @Attack => m_Wrapper.m_DobberControls_Attack;
        public InputAction @ArmTrap => m_Wrapper.m_DobberControls_ArmTrap;
        public InputActionMap Get() { return m_Wrapper.m_DobberControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DobberControlsActions set) { return set.Get(); }
        public void SetCallbacks(IDobberControlsActions instance)
        {
            if (m_Wrapper.m_DobberControlsActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnWalk;
                @Run.started -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnRun;
                @Sneak.started -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnSneak;
                @Sneak.performed -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnSneak;
                @Sneak.canceled -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnSneak;
                @Interact.started -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnInteract;
                @Attack.started -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnAttack;
                @ArmTrap.started -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnArmTrap;
                @ArmTrap.performed -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnArmTrap;
                @ArmTrap.canceled -= m_Wrapper.m_DobberControlsActionsCallbackInterface.OnArmTrap;
            }
            m_Wrapper.m_DobberControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Sneak.started += instance.OnSneak;
                @Sneak.performed += instance.OnSneak;
                @Sneak.canceled += instance.OnSneak;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @ArmTrap.started += instance.OnArmTrap;
                @ArmTrap.performed += instance.OnArmTrap;
                @ArmTrap.canceled += instance.OnArmTrap;
            }
        }
    }
    public DobberControlsActions @DobberControls => new DobberControlsActions(this);

    // RobberControls
    private readonly InputActionMap m_RobberControls;
    private IRobberControlsActions m_RobberControlsActionsCallbackInterface;
    private readonly InputAction m_RobberControls_Walk;
    private readonly InputAction m_RobberControls_Run;
    private readonly InputAction m_RobberControls_Sneak;
    private readonly InputAction m_RobberControls_Crouch;
    private readonly InputAction m_RobberControls_Interact;
    public struct RobberControlsActions
    {
        private @PlayerControls m_Wrapper;
        public RobberControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_RobberControls_Walk;
        public InputAction @Run => m_Wrapper.m_RobberControls_Run;
        public InputAction @Sneak => m_Wrapper.m_RobberControls_Sneak;
        public InputAction @Crouch => m_Wrapper.m_RobberControls_Crouch;
        public InputAction @Interact => m_Wrapper.m_RobberControls_Interact;
        public InputActionMap Get() { return m_Wrapper.m_RobberControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RobberControlsActions set) { return set.Get(); }
        public void SetCallbacks(IRobberControlsActions instance)
        {
            if (m_Wrapper.m_RobberControlsActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_RobberControlsActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_RobberControlsActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_RobberControlsActionsCallbackInterface.OnWalk;
                @Run.started -= m_Wrapper.m_RobberControlsActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_RobberControlsActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_RobberControlsActionsCallbackInterface.OnRun;
                @Sneak.started -= m_Wrapper.m_RobberControlsActionsCallbackInterface.OnSneak;
                @Sneak.performed -= m_Wrapper.m_RobberControlsActionsCallbackInterface.OnSneak;
                @Sneak.canceled -= m_Wrapper.m_RobberControlsActionsCallbackInterface.OnSneak;
                @Crouch.started -= m_Wrapper.m_RobberControlsActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_RobberControlsActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_RobberControlsActionsCallbackInterface.OnCrouch;
                @Interact.started -= m_Wrapper.m_RobberControlsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_RobberControlsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_RobberControlsActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_RobberControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Sneak.started += instance.OnSneak;
                @Sneak.performed += instance.OnSneak;
                @Sneak.canceled += instance.OnSneak;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public RobberControlsActions @RobberControls => new RobberControlsActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface IMasterControlsActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IDobberControlsActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnSneak(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnArmTrap(InputAction.CallbackContext context);
    }
    public interface IRobberControlsActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnSneak(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
