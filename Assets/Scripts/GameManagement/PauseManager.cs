using System;
using UnityEngine;
using TMPro;

public class PauseManager : MonoBehaviour
{
    public TextMeshProUGUI pauseTxt;

    public void SwitchPauseGame()
    {
        switch (Time.timeScale)
        {
            case 0:
                Time.timeScale = 1;
                pauseTxt.text = "";
                break;
            case 1:
                Time.timeScale = 0;
                pauseTxt.text = "Jogo Pausado";
                break;
        }
    }
}
