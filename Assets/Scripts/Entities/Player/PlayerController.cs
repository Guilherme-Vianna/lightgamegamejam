using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private bool _interact;

    public void SetInteraction(InputAction.CallbackContext value)
    {
        _interact = value.ReadValue<bool>();
        //print(_interact);
        print("Space");
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
