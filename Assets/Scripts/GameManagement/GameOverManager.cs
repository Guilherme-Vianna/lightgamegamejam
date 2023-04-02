using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public Slider Battery;
    public TextMeshProUGUI GameOverTxt;
    public GameObject Restart;

    private void Start()
    {
        Time.timeScale = 1f;
        GameOverTxt.enabled = false;
        Restart.SetActive(false);
    }

    private void Update()
    {
        Battery.value -= Time.deltaTime;

        if (Battery.value <= 0)
            GameOver();
    }

    private void GameOver()
    {
        Battery.gameObject.SetActive(false);
        GameOverTxt.enabled = true;
        Restart.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(3);
        //print("Restart");
    }
}
