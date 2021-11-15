using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class SliderController : MonoBehaviour
{
    //public Text valueText;
    public Slider slider;

    public void OnSliderChanged()
    {
        //valueText.text = value.ToString();
        slider.value =7;
        }

}
    


