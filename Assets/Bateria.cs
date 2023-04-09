using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bateria : MonoBehaviour
{
    Battery BateriaScript;

    private void Start()
    {
        BateriaScript = FindObjectOfType<Battery>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            BateriaScript.flashLightBattery.fillAmount = 1;
            Destroy(this.gameObject);
        }
    }
}
