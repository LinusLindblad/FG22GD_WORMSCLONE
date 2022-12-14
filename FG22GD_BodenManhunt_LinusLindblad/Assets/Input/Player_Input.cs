//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/Input/Player_Input.inputactions
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

public partial class @Player_Input : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player_Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player_Input"",
    ""maps"": [
        {
            ""name"": ""BaseInput"",
            ""id"": ""37caf7d3-0c27-4cc5-b3d5-b605d89bc428"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""734d2997-61e6-4bc9-a26e-84dfdef94f0a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""4acd83c4-aa88-4844-ba2c-2da7b05ef865"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""be08fa5b-d548-495f-b80e-2c41ba426a1e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""01d06c52-5eec-4ee4-90b6-bd73d0f54127"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""dcd24e6d-88a7-42f4-9f60-c1b4913343c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""ec3a999e-faa8-4973-a227-a8816c3b5708"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SecondaryUse"",
                    ""type"": ""Button"",
                    ""id"": ""b2e4c613-f144-45a8-87af-35ddde8ffa5d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TetriaryUse"",
                    ""type"": ""Button"",
                    ""id"": ""9ee1e049-c075-4d2f-8674-575937708d3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PassTurn"",
                    ""type"": ""Button"",
                    ""id"": ""8af13c45-d451-4009-ba81-d508c750cc06"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""41d279e7-cefe-4559-956d-8ec0dd214ff2"",
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
                    ""id"": ""7ac18183-8f77-428e-8c1b-46bb682003e2"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aae92faf-603f-4ea9-b449-dadef5658cab"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""dc8f7923-a421-453b-9387-983c31588434"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0f1d4c27-8819-4a38-b162-4e7aaa2398dd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""865b7011-a6c7-431b-9b34-2b7fd9dceb4c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""055541b5-5712-4455-8ff8-a355a8defd20"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e0325e06-fe31-4541-b366-dd264218a56b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""15f2234d-900d-448c-bf2b-d98b8f131767"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68a986e3-9c9b-4b4c-920e-986847c80393"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b404a02-02bd-43cd-b9db-91a304aa5cff"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""092e45e7-35d8-4123-b41a-82cd9b5d0cc7"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryUse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67103d97-11a8-4a38-9713-c3e998f29b29"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PassTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35858f5c-580b-434b-9e86-ff119d7eec8c"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TetriaryUse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90102ece-2022-42de-a9f2-1b95f74c5a5f"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TetriaryUse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BaseInput
        m_BaseInput = asset.FindActionMap("BaseInput", throwIfNotFound: true);
        m_BaseInput_Movement = m_BaseInput.FindAction("Movement", throwIfNotFound: true);
        m_BaseInput_Look = m_BaseInput.FindAction("Look", throwIfNotFound: true);
        m_BaseInput_Jump = m_BaseInput.FindAction("Jump", throwIfNotFound: true);
        m_BaseInput_Inventory = m_BaseInput.FindAction("Inventory", throwIfNotFound: true);
        m_BaseInput_Aim = m_BaseInput.FindAction("Aim", throwIfNotFound: true);
        m_BaseInput_Use = m_BaseInput.FindAction("Use", throwIfNotFound: true);
        m_BaseInput_SecondaryUse = m_BaseInput.FindAction("SecondaryUse", throwIfNotFound: true);
        m_BaseInput_TetriaryUse = m_BaseInput.FindAction("TetriaryUse", throwIfNotFound: true);
        m_BaseInput_PassTurn = m_BaseInput.FindAction("PassTurn", throwIfNotFound: true);
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

    // BaseInput
    private readonly InputActionMap m_BaseInput;
    private IBaseInputActions m_BaseInputActionsCallbackInterface;
    private readonly InputAction m_BaseInput_Movement;
    private readonly InputAction m_BaseInput_Look;
    private readonly InputAction m_BaseInput_Jump;
    private readonly InputAction m_BaseInput_Inventory;
    private readonly InputAction m_BaseInput_Aim;
    private readonly InputAction m_BaseInput_Use;
    private readonly InputAction m_BaseInput_SecondaryUse;
    private readonly InputAction m_BaseInput_TetriaryUse;
    private readonly InputAction m_BaseInput_PassTurn;
    public struct BaseInputActions
    {
        private @Player_Input m_Wrapper;
        public BaseInputActions(@Player_Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_BaseInput_Movement;
        public InputAction @Look => m_Wrapper.m_BaseInput_Look;
        public InputAction @Jump => m_Wrapper.m_BaseInput_Jump;
        public InputAction @Inventory => m_Wrapper.m_BaseInput_Inventory;
        public InputAction @Aim => m_Wrapper.m_BaseInput_Aim;
        public InputAction @Use => m_Wrapper.m_BaseInput_Use;
        public InputAction @SecondaryUse => m_Wrapper.m_BaseInput_SecondaryUse;
        public InputAction @TetriaryUse => m_Wrapper.m_BaseInput_TetriaryUse;
        public InputAction @PassTurn => m_Wrapper.m_BaseInput_PassTurn;
        public InputActionMap Get() { return m_Wrapper.m_BaseInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BaseInputActions set) { return set.Get(); }
        public void SetCallbacks(IBaseInputActions instance)
        {
            if (m_Wrapper.m_BaseInputActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnMovement;
                @Look.started -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnJump;
                @Inventory.started -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnInventory;
                @Aim.started -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnAim;
                @Use.started -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnUse;
                @Use.performed -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnUse;
                @Use.canceled -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnUse;
                @SecondaryUse.started -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnSecondaryUse;
                @SecondaryUse.performed -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnSecondaryUse;
                @SecondaryUse.canceled -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnSecondaryUse;
                @TetriaryUse.started -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnTetriaryUse;
                @TetriaryUse.performed -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnTetriaryUse;
                @TetriaryUse.canceled -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnTetriaryUse;
                @PassTurn.started -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnPassTurn;
                @PassTurn.performed -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnPassTurn;
                @PassTurn.canceled -= m_Wrapper.m_BaseInputActionsCallbackInterface.OnPassTurn;
            }
            m_Wrapper.m_BaseInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Use.started += instance.OnUse;
                @Use.performed += instance.OnUse;
                @Use.canceled += instance.OnUse;
                @SecondaryUse.started += instance.OnSecondaryUse;
                @SecondaryUse.performed += instance.OnSecondaryUse;
                @SecondaryUse.canceled += instance.OnSecondaryUse;
                @TetriaryUse.started += instance.OnTetriaryUse;
                @TetriaryUse.performed += instance.OnTetriaryUse;
                @TetriaryUse.canceled += instance.OnTetriaryUse;
                @PassTurn.started += instance.OnPassTurn;
                @PassTurn.performed += instance.OnPassTurn;
                @PassTurn.canceled += instance.OnPassTurn;
            }
        }
    }
    public BaseInputActions @BaseInput => new BaseInputActions(this);
    public interface IBaseInputActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
        void OnSecondaryUse(InputAction.CallbackContext context);
        void OnTetriaryUse(InputAction.CallbackContext context);
        void OnPassTurn(InputAction.CallbackContext context);
    }
}
