using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FMODUnity;

public class TrocaCenaMenu : MonoBehaviour
{
    [SerializeField]
    private EventReference sfxSplashScreen;

    public void TrocaCena()
    {
        SceneManager.LoadScene(1);
    }

    public void Sonzinho()
    {
        RuntimeManager.PlayOneShotAttached(sfxSplashScreen, gameObject);
    }
}
