using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIneRenderPoitns : MonoBehaviour
{
    
    public LineRenderer lineRenderer;

    //public List<Vector3> linepoints = new List<Vector3>();

    public LinePointsSO linePoints;

    void Start()
    {

        
    }

    void Update()
    {
        
       // GetLineRedenrderPOints();

    }

    public void GetLineRedenrderPOints()
    {


        int positionCount = lineRenderer.positionCount;
        for (int i = 0; i < positionCount; i++)
        {
           linePoints.vector3Points.Add(lineRenderer.GetPosition(i));
        }


    }
    
}
