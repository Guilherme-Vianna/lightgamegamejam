using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Entities.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private Vector2 movement;
        private int speed = 5;
        
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            //rb.AddForce(new Vector2(movement.x, movement.y) * Time.deltaTime * 200);
            transform.position += new Vector3(movement.x, movement.y, 0) * Time.deltaTime * speed;
        }

        public void SetMovement(InputAction.CallbackContext value)
        {
            movement = value.ReadValue<Vector2>();
        }
    }
}
