using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Entities.Objects;

public class GameOverManager : MonoBehaviour
{
    public GameObject batteryOver;
    //public GameObject GameOverEst;
    public GameObject GameOverBat;
    //public GameObject TelaVitoria;

    //public bool Key;
    //public GameObject KeyOBJ;

    private void Start()
    {
        Time.timeScale = 1;
        //    GameOverEst.SetActive(false);
        //    tocou = false;
    }

    private void Update()
    {
        if (batteryOver.GetComponent<Battery>().death)
        {
            BatteryGameOver();
        }
        //    if (Key)
        //    {
        //        KeyOBJ.SetActive(true);
        //    }
        //    else
        //    {
        //        KeyOBJ.SetActive(false);
        //    }

        //        if (!tocou)
        //        {
        //            soundcontrol.death();
        //            tocou = true;
        //        }
        //        GameOverBateria();
        //    }
    }

    //public void GameOverEstatua()
    //{
    //    Battery.gameObject.SetActive(false);
    //    GameOverEst.SetActive(true);
    //    Time.timeScale = 0;
    //}

    public void BatteryGameOver()
    {
        batteryOver.GetComponent<Battery>().flashLightBattery.enabled = false;
        GameOverBat.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(3);

    }
}
