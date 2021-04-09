// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @KaraokeControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @KaraokeControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Karaoke"",
            ""id"": ""f52398a7-0548-4bf2-98fe-e4d1dd464ce5"",
            ""actions"": [
                {
                    ""name"": ""Triangle"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e36cd811-7ace-4d88-97e5-43978156eb0e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Square"",
                    ""type"": ""Button"",
                    ""id"": ""8af9391b-3fdf-4dc5-bf68-6e3346fa63e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cross"",
                    ""type"": ""Button"",
                    ""id"": ""51b53003-5b6b-4e7d-9bb9-b06f46236f50"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Circle"",
                    ""type"": ""Button"",
                    ""id"": ""74a5b7a3-28c2-4c6a-b47f-3d4450f7d043"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8d42a159-d69d-46a0-8529-b68335b0dc3f"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Triangle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3632764b-11ff-4b69-86a2-f170dd427ba3"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Square"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""237fdcf2-91a2-43f8-a5fc-42b93302336b"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cross"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0007375-bd4f-43bf-a3b5-27741d0fded5"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Circle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Karaoke
        m_Karaoke = asset.FindActionMap("Karaoke", throwIfNotFound: true);
        m_Karaoke_Triangle = m_Karaoke.FindAction("Triangle", throwIfNotFound: true);
        m_Karaoke_Square = m_Karaoke.FindAction("Square", throwIfNotFound: true);
        m_Karaoke_Cross = m_Karaoke.FindAction("Cross", throwIfNotFound: true);
        m_Karaoke_Circle = m_Karaoke.FindAction("Circle", throwIfNotFound: true);
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

    // Karaoke
    private readonly InputActionMap m_Karaoke;
    private IKaraokeActions m_KaraokeActionsCallbackInterface;
    private readonly InputAction m_Karaoke_Triangle;
    private readonly InputAction m_Karaoke_Square;
    private readonly InputAction m_Karaoke_Cross;
    private readonly InputAction m_Karaoke_Circle;
    public struct KaraokeActions
    {
        private @KaraokeControls m_Wrapper;
        public KaraokeActions(@KaraokeControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Triangle => m_Wrapper.m_Karaoke_Triangle;
        public InputAction @Square => m_Wrapper.m_Karaoke_Square;
        public InputAction @Cross => m_Wrapper.m_Karaoke_Cross;
        public InputAction @Circle => m_Wrapper.m_Karaoke_Circle;
        public InputActionMap Get() { return m_Wrapper.m_Karaoke; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KaraokeActions set) { return set.Get(); }
        public void SetCallbacks(IKaraokeActions instance)
        {
            if (m_Wrapper.m_KaraokeActionsCallbackInterface != null)
            {
                @Triangle.started -= m_Wrapper.m_KaraokeActionsCallbackInterface.OnTriangle;
                @Triangle.performed -= m_Wrapper.m_KaraokeActionsCallbackInterface.OnTriangle;
                @Triangle.canceled -= m_Wrapper.m_KaraokeActionsCallbackInterface.OnTriangle;
                @Square.started -= m_Wrapper.m_KaraokeActionsCallbackInterface.OnSquare;
                @Square.performed -= m_Wrapper.m_KaraokeActionsCallbackInterface.OnSquare;
                @Square.canceled -= m_Wrapper.m_KaraokeActionsCallbackInterface.OnSquare;
                @Cross.started -= m_Wrapper.m_KaraokeActionsCallbackInterface.OnCross;
                @Cross.performed -= m_Wrapper.m_KaraokeActionsCallbackInterface.OnCross;
                @Cross.canceled -= m_Wrapper.m_KaraokeActionsCallbackInterface.OnCross;
                @Circle.started -= m_Wrapper.m_KaraokeActionsCallbackInterface.OnCircle;
                @Circle.performed -= m_Wrapper.m_KaraokeActionsCallbackInterface.OnCircle;
                @Circle.canceled -= m_Wrapper.m_KaraokeActionsCallbackInterface.OnCircle;
            }
            m_Wrapper.m_KaraokeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Triangle.started += instance.OnTriangle;
                @Triangle.performed += instance.OnTriangle;
                @Triangle.canceled += instance.OnTriangle;
                @Square.started += instance.OnSquare;
                @Square.performed += instance.OnSquare;
                @Square.canceled += instance.OnSquare;
                @Cross.started += instance.OnCross;
                @Cross.performed += instance.OnCross;
                @Cross.canceled += instance.OnCross;
                @Circle.started += instance.OnCircle;
                @Circle.performed += instance.OnCircle;
                @Circle.canceled += instance.OnCircle;
            }
        }
    }
    public KaraokeActions @Karaoke => new KaraokeActions(this);
    public interface IKaraokeActions
    {
        void OnTriangle(InputAction.CallbackContext context);
        void OnSquare(InputAction.CallbackContext context);
        void OnCross(InputAction.CallbackContext context);
        void OnCircle(InputAction.CallbackContext context);
    }
}
