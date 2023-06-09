using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Entities.Player
{
    public class PlayerLantern : MonoBehaviour
    {
        public Transform lanternPos1;
        public Transform lanternPos2;
        public Transform lanternPos3;
        public Transform lanternPos4;
        
        public Vector2 movement;
        
        public void SetMovement(InputAction.CallbackContext value)
        {
            movement = value.ReadValue<Vector2>();
        }

        private void Update()
        {
            if(Time.timeScale == 1)
            {
                if (movement.x > 0)
                {
                    transform.position = lanternPos2.position;
                    transform.rotation = Quaternion.Euler(0, 0, -90F);
                }
                else if (movement.x < 0)
                {
                    transform.position = lanternPos1.position;
                    transform.rotation = Quaternion.Euler(0, 0, 90F);
                }
                else if (movement.y > 0)
                {
                    transform.position = lanternPos3.position;
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else if (movement.y < 0)
                {
                    transform.position = lanternPos4.position;
                    transform.rotation = Quaternion.Euler(0, 0, -180F);
                }
                else
                {
                    return;
                }
            }
        }
    }    
}