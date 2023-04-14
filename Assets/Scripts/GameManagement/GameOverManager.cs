using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    private void Start()
    {
        battery = GetComponent<Battery>();
        Time.timeScale = 1;
        GameOverEst.SetActive(false);
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
        RuntimeManager.PlayOneShotAttached(sfxDeath, gameObject);
        pauseButton.SetActive(false);
        GameOverEst.SetActive(true);
        Time.timeScale = 0;
    }

    public void BatteryGameOver()
    {
        RuntimeManager.PlayOneShotAttached(sfxDeath, gameObject);
        battery.enabled = false;
        GameOverBat.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(4);

    }
}
