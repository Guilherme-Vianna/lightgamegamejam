using Entities.Player;
using UnityEngine;
using FMODUnity;

public class Key : MonoBehaviour
{
    [SerializeField]
    private EventReference getKey;

    GameOverManager UI;

    private void Awake()
    {
        UI = FindObjectOfType<GameOverManager>();    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<PlayerInventory>().IsOwnKey = true;
            UI.Key = true;
            Destroy(gameObject);
            RuntimeManager.PlayOneShotAttached(getKey, gameObject);
        }    
    }
}
