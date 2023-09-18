using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PathUpdater : MonoBehaviour
{
    public SliderValue pathleft;
    public Slider slider;

    void Start()
    {
        
    }
    void Update()
    {

      slider.value = pathleft.sliderValue;

    }
}
