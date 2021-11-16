using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour


{
    public Slider slider;
    

    public void set(float newValue)
    {
        slider.value = newValue;
    }
}



