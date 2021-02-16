using System.Collections;
using System.Collections.Generic;
using BilgeAdam3dWorkshop.Controllers;
using UnityEngine;

namespace BilgeAdam3dWorkshop.Animations
{
    public class CharacterAnimation
    {
        private Animator _animator;

        public CharacterAnimation(PlayerController playerController)
        {
            _animator = playerController.GetComponentInChildren<Animator>();
        }

        public void MoveAnimation(float moveSpeed)
        {
            if (_animator.GetFloat("moveSpeed") == moveSpeed) return;
            
            _animator.SetFloat("moveSpeed", moveSpeed,0.05f,Time.deltaTime);
        }
    }
}