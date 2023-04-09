using Entities.Player;
using UnityEngine;

public class Porta : MonoBehaviour
{
    public bool IsOpenByKey;

    SoundController soundController;
    Animator Anim;
    public GameObject PorraDoCollider;
    BoxCollider2D Box;

    private SFXPlayer[] sfxs;

    bool IsOpened;

    private void Start()
    {
        soundController = FindObjectOfType<SoundController>();
        Anim = GetComponent<Animator>();
        sfxs = GetComponents<SFXPlayer>();
        Box = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) 
        {
            return;
        }
        if (other.GetComponent<PlayerInventory>().IsOwnKey && IsOpenByKey && !IsOpened)
        {
            soundController.PlaySfxByName("PortaAbre", sfxs);
            Anim.SetBool("HasKey", true);
            Box.enabled = false;
            Destroy(PorraDoCollider);
            IsOpened = true;
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

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
