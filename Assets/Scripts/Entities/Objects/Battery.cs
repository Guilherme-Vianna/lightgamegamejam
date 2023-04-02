using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    [SerializeField] public Slider battery;

    void Update()
    {
        battery.value -= Time.deltaTime;

        if(battery.value <= battery.minValue)
        {
            //Game over
        }
    }
}
