using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
    [SerializeField]
    private EventReference sfx;

    public void Start()
    {
        Debug.Log(sfx.Guid);
        Debug.Log(sfx.Path);
    }

    public string sfxName; 

    public void PlaySFX()

    {
        RuntimeManager.PlayOneShotAttached(sfx, gameObject);
    }
}
