// GENERATED AUTOMATICALLY FROM 'Assets/magnCons.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MagnCons : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MagnCons()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""magnCons"",
    ""maps"": [
        {
            ""name"": ""magnoMap"",
            ""id"": ""8ff166ee-80bf-4fb3-ab58-0eeb77211894"",
            ""actions"": [
                {
                    ""name"": ""Forward"",
                    ""type"": ""Button"",
                    ""id"": ""95f2ac0a-be95-4f72-a844-5486d5bdba56"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""6f0f5295-5c23-478a-85e9-c6895260529a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""TurnLeft"",
                    ""type"": ""Button"",
                    ""id"": ""8ec75448-6267-4cb0-b09d-31aa3fa9c69c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""TurnRight"",
                    ""type"": ""Button"",
                    ""id"": ""25c56d2d-323e-4f93-a767-11025a3440f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""eeb463a6-f746-4370-903c-b26d45128ab6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Push"",
                    ""type"": ""Button"",
                    ""id"": ""ac1fe777-8358-444e-81e4-6fb3ff34f36e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Pull"",
                    ""type"": ""Button"",
                    ""id"": ""a8ae81e5-4b0f-4a5e-ab46-64ea0ef0fbb5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Lock"",
                    ""type"": ""Button"",
                    ""id"": ""e32a1313-2b5b-40d4-91f7-ad4c7f32a4cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""LookUp"",
                    ""type"": ""Value"",
                    ""id"": ""28fe921b-f1e9-439f-bb27-3fe809c85ff1"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookX"",
                    ""type"": ""Value"",
                    ""id"": ""e1c4e3ba-a90b-49f0-909a-0b66bf938709"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a3d5821a-3c86-48a2-8c5c-1a28475754af"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42147aa4-2b3c-4ec7-bab7-93056b44ffa2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c7b4710-d6a4-4c33-ab32-15354baef9dd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ccd4d35-8057-4849-bd39-d1d07b9846a2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25400e2c-f985-4f50-8f0c-67f9b15d632f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""675745f9-4b6a-409e-aef8-5b539fc977ce"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Push"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62578326-ae6d-4e35-bced-6aad2a237bd7"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pull"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de30a325-d7e5-4a65-8574-52d31f85f785"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1fa3ca32-3e72-49db-802e-dd85e8a231f8"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30d42341-8941-469d-8054-03175c076239"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // magnoMap
        m_magnoMap = asset.FindActionMap("magnoMap", throwIfNotFound: true);
        m_magnoMap_Forward = m_magnoMap.FindAction("Forward", throwIfNotFound: true);
        m_magnoMap_Back = m_magnoMap.FindAction("Back", throwIfNotFound: true);
        m_magnoMap_TurnLeft = m_magnoMap.FindAction("TurnLeft", throwIfNotFound: true);
        m_magnoMap_TurnRight = m_magnoMap.FindAction("TurnRight", throwIfNotFound: true);
        m_magnoMap_Pause = m_magnoMap.FindAction("Pause", throwIfNotFound: true);
        m_magnoMap_Push = m_magnoMap.FindAction("Push", throwIfNotFound: true);
        m_magnoMap_Pull = m_magnoMap.FindAction("Pull", throwIfNotFound: true);
        m_magnoMap_Lock = m_magnoMap.FindAction("Lock", throwIfNotFound: true);
        m_magnoMap_LookUp = m_magnoMap.FindAction("LookUp", throwIfNotFound: true);
        m_magnoMap_LookX = m_magnoMap.FindAction("LookX", throwIfNotFound: true);
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

    // magnoMap
    private readonly InputActionMap m_magnoMap;
    private IMagnoMapActions m_MagnoMapActionsCallbackInterface;
    private readonly InputAction m_magnoMap_Forward;
    private readonly InputAction m_magnoMap_Back;
    private readonly InputAction m_magnoMap_TurnLeft;
    private readonly InputAction m_magnoMap_TurnRight;
    private readonly InputAction m_magnoMap_Pause;
    private readonly InputAction m_magnoMap_Push;
    private readonly InputAction m_magnoMap_Pull;
    private readonly InputAction m_magnoMap_Lock;
    private readonly InputAction m_magnoMap_LookUp;
    private readonly InputAction m_magnoMap_LookX;
    public struct MagnoMapActions
    {
        private @MagnCons m_Wrapper;
        public MagnoMapActions(@MagnCons wrapper) { m_Wrapper = wrapper; }
        public InputAction @Forward => m_Wrapper.m_magnoMap_Forward;
        public InputAction @Back => m_Wrapper.m_magnoMap_Back;
        public InputAction @TurnLeft => m_Wrapper.m_magnoMap_TurnLeft;
        public InputAction @TurnRight => m_Wrapper.m_magnoMap_TurnRight;
        public InputAction @Pause => m_Wrapper.m_magnoMap_Pause;
        public InputAction @Push => m_Wrapper.m_magnoMap_Push;
        public InputAction @Pull => m_Wrapper.m_magnoMap_Pull;
        public InputAction @Lock => m_Wrapper.m_magnoMap_Lock;
        public InputAction @LookUp => m_Wrapper.m_magnoMap_LookUp;
        public InputAction @LookX => m_Wrapper.m_magnoMap_LookX;
        public InputActionMap Get() { return m_Wrapper.m_magnoMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MagnoMapActions set) { return set.Get(); }
        public void SetCallbacks(IMagnoMapActions instance)
        {
            if (m_Wrapper.m_MagnoMapActionsCallbackInterface != null)
            {
                @Forward.started -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnForward;
                @Forward.performed -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnForward;
                @Forward.canceled -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnForward;
                @Back.started -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnBack;
                @TurnLeft.started -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnTurnLeft;
                @TurnLeft.performed -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnTurnLeft;
                @TurnLeft.canceled -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnTurnLeft;
                @TurnRight.started -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnTurnRight;
                @TurnRight.performed -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnTurnRight;
                @TurnRight.canceled -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnTurnRight;
                @Pause.started -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnPause;
                @Push.started -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnPush;
                @Push.performed -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnPush;
                @Push.canceled -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnPush;
                @Pull.started -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnPull;
                @Pull.performed -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnPull;
                @Pull.canceled -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnPull;
                @Lock.started -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnLock;
                @Lock.performed -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnLock;
                @Lock.canceled -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnLock;
                @LookUp.started -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnLookUp;
                @LookUp.performed -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnLookUp;
                @LookUp.canceled -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnLookUp;
                @LookX.started -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnLookX;
                @LookX.performed -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnLookX;
                @LookX.canceled -= m_Wrapper.m_MagnoMapActionsCallbackInterface.OnLookX;
            }
            m_Wrapper.m_MagnoMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Forward.started += instance.OnForward;
                @Forward.performed += instance.OnForward;
                @Forward.canceled += instance.OnForward;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
                @TurnLeft.started += instance.OnTurnLeft;
                @TurnLeft.performed += instance.OnTurnLeft;
                @TurnLeft.canceled += instance.OnTurnLeft;
                @TurnRight.started += instance.OnTurnRight;
                @TurnRight.performed += instance.OnTurnRight;
                @TurnRight.canceled += instance.OnTurnRight;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Push.started += instance.OnPush;
                @Push.performed += instance.OnPush;
                @Push.canceled += instance.OnPush;
                @Pull.started += instance.OnPull;
                @Pull.performed += instance.OnPull;
                @Pull.canceled += instance.OnPull;
                @Lock.started += instance.OnLock;
                @Lock.performed += instance.OnLock;
                @Lock.canceled += instance.OnLock;
                @LookUp.started += instance.OnLookUp;
                @LookUp.performed += instance.OnLookUp;
                @LookUp.canceled += instance.OnLookUp;
                @LookX.started += instance.OnLookX;
                @LookX.performed += instance.OnLookX;
                @LookX.canceled += instance.OnLookX;
            }
        }
    }
    public MagnoMapActions @magnoMap => new MagnoMapActions(this);
    public interface IMagnoMapActions
    {
        void OnForward(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnTurnLeft(InputAction.CallbackContext context);
        void OnTurnRight(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnPush(InputAction.CallbackContext context);
        void OnPull(InputAction.CallbackContext context);
        void OnLock(InputAction.CallbackContext context);
        void OnLookUp(InputAction.CallbackContext context);
        void OnLookX(InputAction.CallbackContext context);
    }
}
