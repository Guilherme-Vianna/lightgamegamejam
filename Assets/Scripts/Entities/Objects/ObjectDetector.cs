using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

namespace Entities.Objects
{
    public class ObjectDetector : MonoBehaviour
    {
        public ObjectsInteraction _object;
        public TMP_Text _text; 
        public void OnTriggerStay2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Collectable"))
                _object = other.gameObject.GetComponent<ObjectsInteraction>(); 
        }

        public void Interact(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                _object.Interact();
                _object = null;
                ClearText();
            }
        }

        private void ClearText()
        {
            _text.text = "";
        }

        private void LateUpdate()
        {
            UIChange(_object.gameObject);
        }

        public void UIChange(GameObject gameObject)
        {
            if (_object == null)
            {
                _text.text = "";
            }
            else
            {
                _text.text = $"{gameObject.GetComponent<ObjectsInteraction>().GetType().Name}";
            }
        }
    }
}
