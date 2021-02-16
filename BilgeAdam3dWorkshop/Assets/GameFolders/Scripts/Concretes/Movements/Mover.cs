using System.Collections;
using System.Collections.Generic;
using BilgeAdam3dWorkshop.Controllers;
using UnityEngine;

namespace BilgeAdam3dWorkshop.Movements
{
    public class Mover
    {
        private float _moveSpeed = 5f;
        private CharacterController _characterController;
        
        //constructor yapici method
        public Mover(PlayerController playerController)
        {
            _characterController = playerController.GetComponent<CharacterController>();
        }

        public void FixedTick(Vector2 direction)
        {
            if (direction.magnitude == 0f) return;
            
            Vector3 newDirection = new Vector3(direction.x, 0f, direction.y);
            Vector3 worldPosition = _characterController.transform.TransformDirection(newDirection);
            Vector3 movement = worldPosition * _moveSpeed * Time.deltaTime;

            _characterController.Move(movement);
        }
    }    
}
