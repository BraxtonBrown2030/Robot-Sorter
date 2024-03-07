using UnityEngine;
using UnityEngine.UI;

public class PathUpdater : MonoBehaviour
{
    public SliderValue pathleft;
    public Slider slider;

    void Update()
    {

      slider.value = pathleft.sliderValue;

    }
}
