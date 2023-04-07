using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    public Image flashLightBattery;

    public SoundController soundControl;
    public bool death;

    public int batteryTimeScale;

    private void Start()
    {
        soundControl = GameObject.FindAnyObjectByType<SoundController>();
    }

    private void Update()
    {
        flashLightBattery.fillAmount -= Time.deltaTime / batteryTimeScale;

        if (flashLightBattery.fillAmount <= 0.8f)
            soundControl.SetDanger(1);
        if (flashLightBattery.fillAmount <= 0.5f)
            soundControl.SetDanger(2);
        else
            soundControl.SetDanger(0);
        if (flashLightBattery.fillAmount <= 0.2f)
        {
            if (!death)
            {
                soundControl.Death();
                death = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            flashLightBattery.fillAmount = 1;
            Destroy(this.gameObject);
        }
    }
}
