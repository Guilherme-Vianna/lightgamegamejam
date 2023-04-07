using Entities.Player;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("O Jogador Pegou a chave");
            collision.GetComponent<PlayerInventory>().IsOwnKey = true;
        }    
    }
}
