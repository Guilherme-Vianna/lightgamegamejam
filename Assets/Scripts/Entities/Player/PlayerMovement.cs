using UnityEngine;
using UnityEngine.InputSystem;

namespace Entities.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        public Vector2 movement;
        public int speed = 5;
        
        [SerializeField] private Animator Animator;
        
        void Update()
        {
            //Move();
        }

        //private void Move();

        void FixedUpdate()
        {
            transform.position += new Vector3(movement.x, movement.y, 0) * Time.deltaTime * speed;
        }

        public void SetMovement(InputAction.CallbackContext value)
        {
            movement = value.ReadValue<Vector2>();
        }


        public void Animacoes()
        {
            //Animator.SetFloat("X", movement.x);
            //Animator.SetFloat("Y", movement.y);
            //Animator.SetFloat("Speed", movement.sqrMagnitude);

            //if (movement != Vector2.zero)
            //{
            //    Animator.SetFloat("HorizontalIdle", movement.x);
            //    Animator.SetFloat("VerticalIdle", movement.y);
            //}
        }
    }
}
