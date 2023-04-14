using UnityEngine;
using UnityEngine.Rendering.Universal;
using FMODUnity;

public class IluminaFinalDoJogo : MonoBehaviour
{
    public Light2D light2D;
    public bool WinGame;
    public GameObject[] ObjsDesativar;

    WinCondition Win;

    [SerializeField]
    private EventReference sfxWin;

    bool Tocou;

    private void Start()
    {
        Win = FindObjectOfType<WinCondition>();
        Tocou=false;
    }


    void Update()
    {
        if (WinGame)
        {
            if (light2D.intensity < 1)
            {
                light2D.intensity += 0.5f * Time.deltaTime;
                foreach (GameObject Luzes in ObjsDesativar)
                {
                    Luzes.SetActive(false);
                }
            }

            if (light2D.intensity >= 0.6f)
            {
                if (!Tocou)
                {
                    RuntimeManager.PlayOneShotAttached(sfxWin, gameObject);
                    Tocou = true;
                }
            }

            if (light2D.intensity >= 0.98f)
            {
                Time.timeScale = 0;
                Win.TelaVitoria.SetActive(true);
            }
        }
    }
}
