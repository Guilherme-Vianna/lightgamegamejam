using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
    [SerializeField]
    private EventReference sfx;

    public string sfxName; 

    public void PlaySFX()
    {
        RuntimeManager.PlayOneShotAttached(sfx, gameObject);
    }
}
