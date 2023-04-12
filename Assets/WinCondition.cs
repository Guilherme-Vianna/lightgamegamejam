using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public GameObject TelaVitoria;
    IluminaFinalDoJogo IluminaFinal;

    private void Start()
    {
        IluminaFinal = FindObjectOfType<IluminaFinalDoJogo>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IluminaFinal.WinGame = true;
        }
    }
}
