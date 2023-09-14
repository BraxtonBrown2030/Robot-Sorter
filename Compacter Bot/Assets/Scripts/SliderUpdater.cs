using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderUpdater : MonoBehaviour
{
    
    public SliderValue sliderValueSO;
    public Slider slider;

    void Start()
    {
        
    }

    void Update()
    {
        
        if(Input.GetButtonDown("Fire1"))
        {

            slider.value = sliderValueSO.sliderValue;

        }

    }
}
