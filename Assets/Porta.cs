using Entities.Player;
using FMODUnity;
using UnityEngine;

public class Porta : MonoBehaviour
{
    public bool IsOpenByKey;

    Animator Anim;
    public GameObject PorraDoCollider;
    BoxCollider2D Box;

    [SerializeField]
    private EventReference sfxOpeningDoor;

    [SerializeField]
    private EventReference sfxClosedDoor;

    bool IsOpened;

    private void Start()
    {
        Anim = GetComponent<Animator>();
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
            RuntimeManager.PlayOneShotAttached(sfxOpeningDoor, gameObject);
            Anim.SetBool("HasKey", true);
            Box.enabled = false;
            Destroy(PorraDoCollider);
            IsOpened = true;
        }
        if (!other.GetComponent<PlayerInventory>().IsOwnKey && IsOpenByKey)
        {
            RuntimeManager.PlayOneShotAttached(sfxClosedDoor, gameObject);
        } 
        if (!IsOpenByKey)
        {
            RuntimeManager.PlayOneShotAttached(sfxOpeningDoor, gameObject);
            Destroy(gameObject);
        }
        

    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
