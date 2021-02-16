// GENERATED AUTOMATICALLY FROM 'Assets/GameFolders/Scripts/Concretes/Inputs/GameInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace BilgeAdam3dWorkshop.Inputs
{
    public class @GameInput : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GameInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""PlayerOnFoot"",
            ""id"": ""92d9bcf8-d236-4806-8aac-99bbc6f53f06"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""72d4df36-6820-4ba9-917a-d76f219befb0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""2739a230-0d40-4a2d-830f-6b06708fb6ec"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""95569ee0-c253-4ab2-8c82-d1324e37dbaa"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7c59c662-3713-4254-ba34-dfb570bf0a2d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""aaab90e0-ae7d-468f-8aa4-995d5181c07e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""019e8697-4ffc-4c93-b727-f76a39228b64"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""c0e880b8-c1b9-4baa-9528-e193606b0c83"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ca8afc9c-9cf1-484c-9f95-8b39b41f2bfd"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b60a0b9d-c48f-4877-bf7d-9583cdec9c67"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4885ee71-ce59-4254-8b39-f4abf9739d3d"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a146fee7-d4c1-4ff3-9aeb-bd1b69aec556"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""PlayerOnMenu"",
            ""id"": ""075ac5d7-89ab-4240-845b-658642c27a2c"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""95e6f8ac-d8b8-4562-82ac-c67dc0b804ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0d4148a0-e34b-4bef-b258-0ac5f41b9c7a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerOnUi"",
            ""id"": ""7d5764c9-bf6d-4ca7-885b-f469dd58e0b9"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""2d1d1906-e39f-40de-ac4c-db82c7a6860d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""005c31b5-a3e0-4409-9a7b-61bdbddbfd91"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerOnCar"",
            ""id"": ""21b33da8-f06f-4bf0-b13c-e31f9f385d17"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""ef2bd0b2-7162-4e4d-9cfc-a777c031e9ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6876f7ce-aa91-4c08-ab22-57cbf9341fd9"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // PlayerOnFoot
            m_PlayerOnFoot = asset.FindActionMap("PlayerOnFoot", throwIfNotFound: true);
            m_PlayerOnFoot_Move = m_PlayerOnFoot.FindAction("Move", throwIfNotFound: true);
            // PlayerOnMenu
            m_PlayerOnMenu = asset.FindActionMap("PlayerOnMenu", throwIfNotFound: true);
            m_PlayerOnMenu_Newaction = m_PlayerOnMenu.FindAction("New action", throwIfNotFound: true);
            // PlayerOnUi
            m_PlayerOnUi = asset.FindActionMap("PlayerOnUi", throwIfNotFound: true);
            m_PlayerOnUi_Newaction = m_PlayerOnUi.FindAction("New action", throwIfNotFound: true);
            // PlayerOnCar
            m_PlayerOnCar = asset.FindActionMap("PlayerOnCar", throwIfNotFound: true);
            m_PlayerOnCar_Newaction = m_PlayerOnCar.FindAction("New action", throwIfNotFound: true);
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

        // PlayerOnFoot
        private readonly InputActionMap m_PlayerOnFoot;
        private IPlayerOnFootActions m_PlayerOnFootActionsCallbackInterface;
        private readonly InputAction m_PlayerOnFoot_Move;
        public struct PlayerOnFootActions
        {
            private @GameInput m_Wrapper;
            public PlayerOnFootActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_PlayerOnFoot_Move;
            public InputActionMap Get() { return m_Wrapper.m_PlayerOnFoot; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerOnFootActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerOnFootActions instance)
            {
                if (m_Wrapper.m_PlayerOnFootActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnMove;
                }
                m_Wrapper.m_PlayerOnFootActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                }
            }
        }
        public PlayerOnFootActions @PlayerOnFoot => new PlayerOnFootActions(this);

        // PlayerOnMenu
        private readonly InputActionMap m_PlayerOnMenu;
        private IPlayerOnMenuActions m_PlayerOnMenuActionsCallbackInterface;
        private readonly InputAction m_PlayerOnMenu_Newaction;
        public struct PlayerOnMenuActions
        {
            private @GameInput m_Wrapper;
            public PlayerOnMenuActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Newaction => m_Wrapper.m_PlayerOnMenu_Newaction;
            public InputActionMap Get() { return m_Wrapper.m_PlayerOnMenu; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerOnMenuActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerOnMenuActions instance)
            {
                if (m_Wrapper.m_PlayerOnMenuActionsCallbackInterface != null)
                {
                    @Newaction.started -= m_Wrapper.m_PlayerOnMenuActionsCallbackInterface.OnNewaction;
                    @Newaction.performed -= m_Wrapper.m_PlayerOnMenuActionsCallbackInterface.OnNewaction;
                    @Newaction.canceled -= m_Wrapper.m_PlayerOnMenuActionsCallbackInterface.OnNewaction;
                }
                m_Wrapper.m_PlayerOnMenuActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Newaction.started += instance.OnNewaction;
                    @Newaction.performed += instance.OnNewaction;
                    @Newaction.canceled += instance.OnNewaction;
                }
            }
        }
        public PlayerOnMenuActions @PlayerOnMenu => new PlayerOnMenuActions(this);

        // PlayerOnUi
        private readonly InputActionMap m_PlayerOnUi;
        private IPlayerOnUiActions m_PlayerOnUiActionsCallbackInterface;
        private readonly InputAction m_PlayerOnUi_Newaction;
        public struct PlayerOnUiActions
        {
            private @GameInput m_Wrapper;
            public PlayerOnUiActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Newaction => m_Wrapper.m_PlayerOnUi_Newaction;
            public InputActionMap Get() { return m_Wrapper.m_PlayerOnUi; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerOnUiActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerOnUiActions instance)
            {
                if (m_Wrapper.m_PlayerOnUiActionsCallbackInterface != null)
                {
                    @Newaction.started -= m_Wrapper.m_PlayerOnUiActionsCallbackInterface.OnNewaction;
                    @Newaction.performed -= m_Wrapper.m_PlayerOnUiActionsCallbackInterface.OnNewaction;
                    @Newaction.canceled -= m_Wrapper.m_PlayerOnUiActionsCallbackInterface.OnNewaction;
                }
                m_Wrapper.m_PlayerOnUiActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Newaction.started += instance.OnNewaction;
                    @Newaction.performed += instance.OnNewaction;
                    @Newaction.canceled += instance.OnNewaction;
                }
            }
        }
        public PlayerOnUiActions @PlayerOnUi => new PlayerOnUiActions(this);

        // PlayerOnCar
        private readonly InputActionMap m_PlayerOnCar;
        private IPlayerOnCarActions m_PlayerOnCarActionsCallbackInterface;
        private readonly InputAction m_PlayerOnCar_Newaction;
        public struct PlayerOnCarActions
        {
            private @GameInput m_Wrapper;
            public PlayerOnCarActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Newaction => m_Wrapper.m_PlayerOnCar_Newaction;
            public InputActionMap Get() { return m_Wrapper.m_PlayerOnCar; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerOnCarActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerOnCarActions instance)
            {
                if (m_Wrapper.m_PlayerOnCarActionsCallbackInterface != null)
                {
                    @Newaction.started -= m_Wrapper.m_PlayerOnCarActionsCallbackInterface.OnNewaction;
                    @Newaction.performed -= m_Wrapper.m_PlayerOnCarActionsCallbackInterface.OnNewaction;
                    @Newaction.canceled -= m_Wrapper.m_PlayerOnCarActionsCallbackInterface.OnNewaction;
                }
                m_Wrapper.m_PlayerOnCarActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Newaction.started += instance.OnNewaction;
                    @Newaction.performed += instance.OnNewaction;
                    @Newaction.canceled += instance.OnNewaction;
                }
            }
        }
        public PlayerOnCarActions @PlayerOnCar => new PlayerOnCarActions(this);
        public interface IPlayerOnFootActions
        {
            void OnMove(InputAction.CallbackContext context);
        }
        public interface IPlayerOnMenuActions
        {
            void OnNewaction(InputAction.CallbackContext context);
        }
        public interface IPlayerOnUiActions
        {
            void OnNewaction(InputAction.CallbackContext context);
        }
        public interface IPlayerOnCarActions
        {
            void OnNewaction(InputAction.CallbackContext context);
        }
    }
}
