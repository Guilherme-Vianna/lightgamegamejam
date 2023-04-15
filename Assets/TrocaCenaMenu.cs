using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FMODUnity;

public class TrocaCenaMenu : MonoBehaviour
{
    [SerializeField]
    private EventReference sfxSplashScreen;
    
    Animator Anim;

    public bool CarregouTudo;


    [BankRef]
    public List<string> banks;

    private void Awake()
    {
        Anim = GetComponent<Animator>();
        LoadBanks();
    }


    public void LoadBanks()
    {
        foreach (string b in banks)
        {
            RuntimeManager.LoadBank(b, true);
        }
        /*
            For Chrome / Safari browsers / WebGL.  Reset audio on response to user interaction (LoadBanks is called from a button press), to allow audio to be heard.
        */
        RuntimeManager.CoreSystem.mixerSuspend();
        RuntimeManager.CoreSystem.mixerResume();

        StartCoroutine(CheckBanksLoaded());
    }

    IEnumerator CheckBanksLoaded()
    {
        while (!RuntimeManager.HaveAllBanksLoaded)
        {
            yield return null;
        }

        CarregouTudo = true;
    }

    private void Update()
    {
        Anim.SetBool("CarregouTudo", CarregouTudo);
    }

    public void TrocaCena()
    {
        SceneManager.LoadScene(1);
    }

    public void Sonzinho()
    {
        RuntimeManager.PlayOneShotAttached(sfxSplashScreen, gameObject);
    }
}
