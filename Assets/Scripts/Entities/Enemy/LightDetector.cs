using System;
using UnityEngine;

namespace Entities.Enemy
{
    public class LightDetector : MonoBehaviour
    {
        public bool IsInLight;

        private void OnTriggerStay2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Light"))
            {
                IsInLight = true;
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            IsInLight = false;
        }
    }
}