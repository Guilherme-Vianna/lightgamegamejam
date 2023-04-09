using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderChase : MonoBehaviour
{
    public bool CanChase;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CanChase = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CanChase = false;
        }
    }
}
