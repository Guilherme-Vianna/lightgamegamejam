using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    GameOverManager GameOverMng;

    void Awake()
    {
        GameOverMng = FindObjectOfType<GameOverManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameOverMng.GameOver();
        }
    }
}
