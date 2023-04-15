using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Entities.Objects;
using FMODUnity;

public class GameOverManager : MonoBehaviour
{
    Battery battery;
    public GameObject GameOverEst;
    public GameObject GameOverBat;
    public GameObject TelaVitoria;
    public GameObject pauseButton;

    public bool Key;
    public GameObject KeyOBJ;

    [SerializeField]
    private EventReference sfxDeath;

    SoundController soundController;

    public bool Death;
    bool didTheSound;

    private void Start()
    {
        soundController = FindObjectOfType<SoundController>();
        battery = FindObjectOfType<Battery>();
        Time.timeScale = 1;
        GameOverEst.SetActive(false);
        didTheSound = false;
    }

    private void Update()
    {
        if (Key)
        {
            KeyOBJ.SetActive(true);
        }
        else
        {
            KeyOBJ.SetActive(false);
        }

        if (battery.death)
        {
            BatteryGameOver();
        }
    }

    public void GameOverEstatua()
    {
        soundController.EmitterStop();
        if (!didTheSound)
        {

            RuntimeManager.PlayOneShotAttached(sfxDeath, gameObject);
            didTheSound = true;    
        }
        pauseButton.SetActive(false);
        GameOverEst.SetActive(true);
        Time.timeScale = 0;
    }

    public void BatteryGameOver()
    {
        soundController.EmitterStop(); 
        
        if (!didTheSound)
        {
            RuntimeManager.PlayOneShotAttached(sfxDeath, gameObject);
            didTheSound = true;
        }
        battery.enabled = false;
        GameOverBat.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;
    }


}
