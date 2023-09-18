using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LIneRenderPoitns : MonoBehaviour
{
    
    public LineRenderer lineRenderer;
    public LinePointsSO linePoints;

    void Start()
    {

        linePoints.vector3Points.Clear();


    }

    public void GetLineRedenrderPOints()
    {


        int positionCount = lineRenderer.positionCount;
        for (int i = 0; i < positionCount; i++) // ask about how this works
        {
           linePoints.vector3Points.Add(lineRenderer.GetPosition(i));
        }


    }

    void Quit()
    {

        linePoints.vector3Points.Clear();

    }
    
}
