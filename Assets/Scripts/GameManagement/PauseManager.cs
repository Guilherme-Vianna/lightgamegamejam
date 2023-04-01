using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseManager : MonoBehaviour
{
    private Keyboard _keyboard;

    private void Start()
    {
        _keyboard = Keyboard.current;
    }

    private void Update()
    {
        if(_keyboard.wasUpdatedThisFrame)
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
