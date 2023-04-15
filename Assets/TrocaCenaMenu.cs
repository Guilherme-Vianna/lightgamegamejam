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

    [FMODUnity.BankRef]
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
            FMODUnity.RuntimeManager.LoadBank(b, true);
            Debug.Log("Loaded bank " + b);
        }
        /*
            For Chrome / Safari browsers / WebGL.  Reset audio on response to user interaction (LoadBanks is called from a button press), to allow audio to be heard.
        */
        FMODUnity.RuntimeManager.CoreSystem.mixerSuspend();
        FMODUnity.RuntimeManager.CoreSystem.mixerResume();

        StartCoroutine(CheckBanksLoaded());
    }

    IEnumerator CheckBanksLoaded()
    {
        while (!FMODUnity.RuntimeManager.HaveAllBanksLoaded)
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
