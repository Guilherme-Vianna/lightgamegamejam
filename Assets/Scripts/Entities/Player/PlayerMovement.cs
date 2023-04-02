using UnityEngine;
using UnityEngine.InputSystem;

namespace Entities.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        public Vector2 movement;
        public int speed = 5;
        
        void Update()
        {
            Move();
        }

        private void Move()
        {
            transform.position += new Vector3(movement.x, movement.y, 0) * Time.deltaTime * speed;
        }

        public void SetMovement(InputAction.CallbackContext value)
        {
            movement = value.ReadValue<Vector2>();
        }
    }
}
