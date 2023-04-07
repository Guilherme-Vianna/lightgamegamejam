using Entities.Player;
using UnityEngine;

public class Porta : MonoBehaviour
{
    public GameObject TelaVitoria;
    public bool IsOpenByKey;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) 
        {
            return;
        }
        if (other.GetComponent<PlayerInventory>().IsOwnKey && IsOpenByKey)
        {
            //tocar porta abrindo
            Debug.Log("Tem chave e vai abrir");
            Destroy(gameObject);
        }
        if (!other.GetComponent<PlayerInventory>().IsOwnKey && IsOpenByKey)
        {

            Debug.Log("nao tem chave");
            //som porta fechada
        } 
        if (!IsOpenByKey)
        {
            Debug.Log("Nao precisa de chave");
            //som porta abrindo
            Destroy(gameObject);
        }
        

    }
}
