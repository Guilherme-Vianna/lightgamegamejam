using Entities.Player;
using UnityEngine;

public class Porta : MonoBehaviour
{
    public bool IsOpenByKey;

    SoundController soundController;

    private SFXPlayer[] sfxs;

    private void Start()
    {
        soundController = FindObjectOfType<SoundController>();
        sfxs = GetComponents<SFXPlayer>();        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) 
        {
            return;
        }
        if (other.GetComponent<PlayerInventory>().IsOwnKey && IsOpenByKey)
        {
            soundController.PlaySfxByName("PortaAbre", sfxs);
            Destroy(gameObject);
        }
        if (!other.GetComponent<PlayerInventory>().IsOwnKey && IsOpenByKey)
        {
            soundController.PlaySfxByName("PortaFechada", sfxs);
        } 
        if (!IsOpenByKey)
        {
            soundController.PlaySfxByName("PortaAbre", sfxs);
            Destroy(gameObject);
        }
        

    }
}
