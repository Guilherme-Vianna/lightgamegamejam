using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public Image Battery;
    public GameObject GameOverEst;
    public GameObject GameOverBat;
    public GameObject TelaVitoria;
    public float Scale;

    public bool tocou;

    public bool Key;
    public GameObject KeyOBJ;

    public SoundController soundControl;

    private void Start()
    {
        soundControl = GameObject.FindAnyObjectByType<SoundController>();
        Time.timeScale = 1;
        GameOverEst.SetActive(false);
        tocou = false;
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

        Battery.fillAmount -= Time.deltaTime / Scale;

        if (Battery.fillAmount <= 0.8f)
            soundControl.SetDanger(1);
        if (Battery.fillAmount <= 0.5f)
            soundControl.SetDanger(2);
        else
            soundControl.SetDanger(0);
        if (Battery.fillAmount <= 0.2f)
        {
            if (!tocou)
            {
                soundControl.Death();
                tocou = true;
            }
            GameOverBateria();
        }
    }

    public void GameOverEstatua()
    {
        Battery.gameObject.SetActive(false);
        GameOverEst.SetActive(true);
        Time.timeScale = 0;
    }

    public void GameOverBateria()
    {
        Battery.gameObject.SetActive(false);
        GameOverBat.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(3);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Battery.fillAmount = 1;
            Destroy(this.gameObject);
        }
    }
}
