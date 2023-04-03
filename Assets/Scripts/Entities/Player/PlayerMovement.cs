using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Entities.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private Vector2 movement;
        [SerializeField]
        private int speed;
        public Animator Animator;

        PlayerLantern Lantern;

        private void Awake()
        {
            Lantern = FindObjectOfType<PlayerLantern>();
        }

        private void Update()
        {
            Animacoes();
        }

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
            Animator.SetFloat("X", movement.x);
            Animator.SetFloat("Y", movement.y);
            Animator.SetFloat("Speed", movement.sqrMagnitude);

            if (movement != Vector2.zero)
            {
                Animator.SetFloat("HorizontalIdle", movement.x);
                Animator.SetFloat("VerticalIdle", movement.y);
            }
        }
    
    
        //public void rotateLanternDown()
        //{
        //    Lantern.RotateDown();
        //}


        //public void rotateLanternUp()
        //{
        //    Lantern.RotateUp();
        //}

        //public void rotateLanternLeft()
        //{
        //    Lantern.RotateLeft();
        //}

        //public void rotateLanternRight()
        //{
        //    Lantern.RotateRight();
        //}
    }

}
