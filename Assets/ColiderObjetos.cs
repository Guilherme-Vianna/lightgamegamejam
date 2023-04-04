using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColiderObjetos : MonoBehaviour
{
    GameOverManager GameOverMng;

    private void Awake()
    {
        //GameOverMng = FindObjectOfType<GameOverManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            //GameOverMng.TelaVitoria.SetActive(true);
        }

        

    }

    public void checkDoor()
    {

    }
}
