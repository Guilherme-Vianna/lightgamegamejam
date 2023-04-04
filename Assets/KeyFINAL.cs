using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyFINAL : MonoBehaviour
{
    public GameObject TelaVitoria;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            TelaVitoria.SetActive(true);
        }    
    }
}
