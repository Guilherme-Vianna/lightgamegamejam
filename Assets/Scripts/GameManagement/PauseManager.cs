using System;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject TelaPause;

    public void SwitchPauseGame()
    {
        switch (Time.timeScale)
        {
            case 0:
                Time.timeScale = 1;
                TelaPause.SetActive(false);
                break;
            case 1:
                Time.timeScale = 0; 
                TelaPause.SetActive(true);
                break;
        }
    }
}
