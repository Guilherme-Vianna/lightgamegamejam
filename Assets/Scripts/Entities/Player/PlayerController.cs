using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private bool _interact;

    public void SetInteraction(InputAction.CallbackContext value)
    {
        if (value.performed)
        {
            _interact = true;
            //print(_interact);
            print("Space");
        }
    }

    public void SetInteractionEnd(bool value)
    {
        _interact = value;
    }

    public bool GetInteraction()
    {
        return _interact;
    }
}
