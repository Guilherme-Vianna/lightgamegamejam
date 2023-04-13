using System;
using UnityEngine;
using UnityEditor;
public class PauseManager : MonoBehaviour
{
    public GameObject TelaPause;
    public GameObject SairBotao;

    public void SwitchPauseGame()
    {
        switch (Time.timeScale)
        {
            case 0:
                Time.timeScale = 1;
                TelaPause.SetActive(false);
                SairBotao.SetActive(false);
                break;
            case 1:
                Time.timeScale = 0; 
                TelaPause.SetActive(true);
                SairBotao.SetActive(true);
                break;
        }
    }

    public static void GameExit()
    {
        #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
