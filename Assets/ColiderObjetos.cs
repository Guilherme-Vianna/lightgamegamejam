using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderObjetos : MonoBehaviour
{
    GameOverManager GameOverMng;

    private void Awake()
    {
        GameOverMng = FindObjectOfType<GameOverManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            GameOverMng.Key = true;
        }

        if (collision.gameObject.CompareTag("LockedDoor"))
        {
            if (GameOverMng.Key)
            {
                //OpenTheDoor
            }
            else
            {
                //Som de porta fechada
            }
        }

        if (collision.gameObject.CompareTag("OpenedDoor"))
        {
                //OpenTheDoor
        }
    }

    public void checkDoor()
    {

    }
}
