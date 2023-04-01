using System;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            SwitchPauseGame();
    }

    private static void SwitchPauseGame()
    {
        switch (Time.timeScale)
        {
            case 0:
                Time.timeScale = 1;
                Debug.Log("Jogo Resumido");
                break;
            case 1:
                Time.timeScale = 0;
                Debug.Log("Jogo Pausado");
                break;
        }
    }
}
