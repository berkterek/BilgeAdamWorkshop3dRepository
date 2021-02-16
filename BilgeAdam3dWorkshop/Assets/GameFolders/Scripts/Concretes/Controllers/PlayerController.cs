using System;
using System.Collections;
using System.Collections.Generic;
using BilgeAdam3dWorkshop.Animations;
using BilgeAdam3dWorkshop.Inputs;
using BilgeAdam3dWorkshop.Movements;
using UnityEngine;

namespace BilgeAdam3dWorkshop.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private InputReader _input;
        private Mover _mover;
        private CharacterAnimation _animation;

        private Vector2 _direction;
        
        private void Awake()
        {
            _input = GetComponent<InputReader>();
            _mover = new Mover(this);
            _animation = new CharacterAnimation(this);
        }

        private void Update()
        {
            _direction = _input.Direction;
        }

        private void FixedUpdate()
        {
            _mover.FixedTick(_direction);
        }

        private void LateUpdate()
        {
            _animation.MoveAnimation(_direction.magnitude);
        }
    }    
}
