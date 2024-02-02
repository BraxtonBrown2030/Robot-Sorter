using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderUpdate : MonoBehaviour
{
    public LinePointsSO numberOfPoints;
    public Slider slider;
    
    void Update()
    {

        
        
        slider.value = numberOfPoints.vector3Points.Count;
        

    }
}
