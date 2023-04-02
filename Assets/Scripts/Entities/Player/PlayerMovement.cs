using UnityEngine;
using UnityEngine.InputSystem;

namespace Entities.Player
{
    public class PlayerMovement : MonoBehaviour
    {
<<<<<<< Updated upstream
        public Vector2 movement;
        public int speed = 5;
=======
        private Vector2 movement;
        private int speed = 5;
        [SerializeField]
        private Animator Animator;
>>>>>>> Stashed changes
        
        void Update()
        {
            Move();
        }

<<<<<<< Updated upstream
        private void Move()
=======
        private void Update()
        {
            Animacoes();
        }

        void FixedUpdate()
>>>>>>> Stashed changes
        {
            transform.position += new Vector3(movement.x, movement.y, 0) * Time.deltaTime * speed;
        }

        public void SetMovement(InputAction.CallbackContext value)
        {
            movement = value.ReadValue<Vector2>();
        }


        public void Animacoes()
        {
            Animator.SetFloat("X", movement.x);
            Animator.SetFloat("Y", movement.y);
            Animator.SetFloat("Speed", movement.sqrMagnitude);

            if (movement != Vector2.zero)
            {
                Animator.SetFloat("HorizontalIdle", movement.x);
                Animator.SetFloat("VerticalIdle", movement.y);
            }
        }
    }
}
