using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIneRenderPoitns : MonoBehaviour
{
    
    public LineRenderer lineRenderer;
    public LinePointsSO linePoints;

    void Start()
    {

        
    }

    public void GetLineRedenrderPOints()
    {


        int positionCount = lineRenderer.positionCount;
        for (int i = 0; i < positionCount; i++) // ask about how this works
        {
           linePoints.vector3Points.Add(lineRenderer.GetPosition(i));
        }


    }
    
}
