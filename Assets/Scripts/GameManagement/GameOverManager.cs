using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public Image Battery;
    public GameObject GameOverScreen;
    public float Scale;

    public SoundController soundControl;

    private void Start()
    {
        soundControl = GameObject.FindAnyObjectByType<SoundController>();
        Time.timeScale = 1;
        GameOverScreen.SetActive(false);
    }

    private void Update()
    {
        Battery.fillAmount -= Time.deltaTime / Scale;

        if (Battery.fillAmount <= 0.8f)
            soundControl.SetDanger(1);
        if (Battery.fillAmount <= 0.5f)
            soundControl.SetDanger(2);
        else
            soundControl.SetDanger(0);
        if (Battery.fillAmount <= 0.2f)
        {
            soundControl.Death();
            StartCoroutine(GameOver());
        }
    }

    public IEnumerator GameOver()
    {
        yield return new WaitForSecondsRealtime(3);
        Battery.gameObject.SetActive(false);
        GameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void GameOverNormal()
    {
        GameOverScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(3);
    }
}
