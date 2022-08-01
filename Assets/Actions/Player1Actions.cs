//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.1
//     from Assets/Actions/Player1Actions.inputactions
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

public partial class @Player1Actions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player1Actions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player1Actions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""a4a9aae0-1a0f-4f93-a78b-14d1edd04daa"",
            ""actions"": [
                {
                    ""name"": ""MovingHorizontal"",
                    ""type"": ""Button"",
                    ""id"": ""01dbbd30-264d-4e9a-9a91-0ea497f70e42"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MovingVertical"",
                    ""type"": ""Button"",
                    ""id"": ""87550c3f-2964-4774-9659-45e4bee71c3b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FreeTheBall"",
                    ""type"": ""Button"",
                    ""id"": ""ea91271b-6bd0-4da1-b66d-312407495d4a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""0ba6abee-8903-43aa-9755-3eb447d1dce1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""8dfbd915-d837-4e58-8ffb-dccfa9ce20a9"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovingHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ca453f4c-d652-4197-9cee-6f067f17bc21"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""MovingHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3a6d8fb4-6a73-426d-b50e-bde748b44955"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""MovingHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Vertical"",
                    ""id"": ""80dacda8-6123-4600-96f9-9a523e18aace"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovingVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8e726a2c-af40-4f46-b134-0b834bafffe7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""MovingVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""88468350-ddcb-4b8d-bbf4-02fac519a888"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""MovingVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""25af1553-4e86-4909-bc5a-2d83a8dfd39f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""FreeTheBall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4effa515-0a3f-4049-b3e9-28b35a8e2a50"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyBoard"",
            ""bindingGroup"": ""KeyBoard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MovingHorizontal = m_Player.FindAction("MovingHorizontal", throwIfNotFound: true);
        m_Player_MovingVertical = m_Player.FindAction("MovingVertical", throwIfNotFound: true);
        m_Player_FreeTheBall = m_Player.FindAction("FreeTheBall", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MovingHorizontal;
    private readonly InputAction m_Player_MovingVertical;
    private readonly InputAction m_Player_FreeTheBall;
    private readonly InputAction m_Player_Pause;
    public struct PlayerActions
    {
        private @Player1Actions m_Wrapper;
        public PlayerActions(@Player1Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovingHorizontal => m_Wrapper.m_Player_MovingHorizontal;
        public InputAction @MovingVertical => m_Wrapper.m_Player_MovingVertical;
        public InputAction @FreeTheBall => m_Wrapper.m_Player_FreeTheBall;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MovingHorizontal.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovingHorizontal;
                @MovingHorizontal.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovingHorizontal;
                @MovingHorizontal.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovingHorizontal;
                @MovingVertical.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovingVertical;
                @MovingVertical.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovingVertical;
                @MovingVertical.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovingVertical;
                @FreeTheBall.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFreeTheBall;
                @FreeTheBall.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFreeTheBall;
                @FreeTheBall.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFreeTheBall;
                @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovingHorizontal.started += instance.OnMovingHorizontal;
                @MovingHorizontal.performed += instance.OnMovingHorizontal;
                @MovingHorizontal.canceled += instance.OnMovingHorizontal;
                @MovingVertical.started += instance.OnMovingVertical;
                @MovingVertical.performed += instance.OnMovingVertical;
                @MovingVertical.canceled += instance.OnMovingVertical;
                @FreeTheBall.started += instance.OnFreeTheBall;
                @FreeTheBall.performed += instance.OnFreeTheBall;
                @FreeTheBall.canceled += instance.OnFreeTheBall;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyBoardSchemeIndex = -1;
    public InputControlScheme KeyBoardScheme
    {
        get
        {
            if (m_KeyBoardSchemeIndex == -1) m_KeyBoardSchemeIndex = asset.FindControlSchemeIndex("KeyBoard");
            return asset.controlSchemes[m_KeyBoardSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovingHorizontal(InputAction.CallbackContext context);
        void OnMovingVertical(InputAction.CallbackContext context);
        void OnFreeTheBall(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
