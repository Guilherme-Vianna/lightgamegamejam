using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    public Image flashLightBattery;

    public SoundController soundControl;
    public bool death;

    public float batteryTimeScale;


    private void Start()
    {
        soundControl = GameObject.FindAnyObjectByType<SoundController>();
    }

    private void Update()
    {        
        flashLightBattery.fillAmount -= (Time.deltaTime / batteryTimeScale) * 0.5f;

        if (flashLightBattery.fillAmount <= 0.9f)
            soundControl.SetDanger(1);
        if (flashLightBattery.fillAmount <= 0.6f)
            soundControl.SetDanger(2);
        else
            soundControl.SetDanger(0);
        if (flashLightBattery.fillAmount <= 0.2f)
        {
            if (!death)
            {
                death = true;
            }
        }
    }

    
}
