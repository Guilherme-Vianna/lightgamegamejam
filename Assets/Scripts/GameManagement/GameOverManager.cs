using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Entities.Objects;

public class GameOverManager : MonoBehaviour
{
    public GameObject batteryOver;
    public GameObject GameOverEst;
    public GameObject GameOverBat;
    public GameObject TelaVitoria;
    public GameObject pauseButton;

    public bool Key;
    public GameObject KeyOBJ;

    private void Start()
    {
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

        if (batteryOver.GetComponent<Battery>().death)
        {
            BatteryGameOver();
        }
    }

    public void GameOverEstatua()
    {
        pauseButton.SetActive(false);
        GameOverEst.SetActive(true);
        Time.timeScale = 0;
    }

    public void BatteryGameOver()
    {
        batteryOver.GetComponent<Battery>().flashLightBattery.enabled = false;
        GameOverBat.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(4);

    }
}
