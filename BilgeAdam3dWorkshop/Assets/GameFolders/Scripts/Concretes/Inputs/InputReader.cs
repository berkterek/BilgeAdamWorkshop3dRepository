using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace BilgeAdam3dWorkshop.Inputs
{
    public class InputReader : MonoBehaviour
    {
        private GameInput _gameInput;

        public Vector2 Direction { get; private set; }

        private void Awake()
        {
            //instance
            _gameInput = new GameInput();
        }

        private void OnEnable()
        {
            _gameInput.Enable();
        }

        private void OnDisable()
        {
            _gameInput.Disable();
        }

        //bu method bizim PlayerInput script'in playeronmove icinde move unity event'ine atanicak olan method'unuzdur
        public void OnMove(InputAction.CallbackContext context)
        {
            Direction = context.ReadValue<Vector2>();
        }
    }    
}

