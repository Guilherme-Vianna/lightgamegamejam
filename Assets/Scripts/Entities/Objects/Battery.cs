using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    public Image flashLightBattery;

    public SoundController soundControl;
    public bool death;

    public float batteryTimeScale;


    private void Awake()
    {
        soundControl = GameObject.FindAnyObjectByType<SoundController>();        
    }
    private void Start()
    {
        soundControl.SetDanger(1);
    }

    private void Update()
    {        
        flashLightBattery.fillAmount -= (Time.deltaTime / batteryTimeScale) * 0.5f;

        if (flashLightBattery.fillAmount <= 0.8f)
        {
            soundControl.SetDanger(1);
        }
        if (flashLightBattery.fillAmount <= 0.4f)
        {
            soundControl.SetDanger(2);
        }
        if(flashLightBattery.fillAmount > 0.8f)
        {
            soundControl.SetDanger(0);
        }

        if (flashLightBattery.fillAmount <= 0.2f)
        {
            if (!death)
            {
                death = true;
            }
        }
    }

    
}
