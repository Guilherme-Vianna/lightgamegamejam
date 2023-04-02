using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundController : MonoBehaviour
{
    SoundController soundController;

    // Start is called before the first frame update
    void Start()
    {
        soundController = FindObjectOfType<SoundController>();
    }

    void DoStep()
    {
        soundController.DoStep();
    }


}
