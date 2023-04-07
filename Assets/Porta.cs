using Entities.Player;
using UnityEngine;

public class Porta : MonoBehaviour
{
    public GameObject TelaVitoria;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        if(other.GetComponent<PlayerInventory>().IsOwnKey)
            TelaVitoria.SetActive(true);
    }
}
