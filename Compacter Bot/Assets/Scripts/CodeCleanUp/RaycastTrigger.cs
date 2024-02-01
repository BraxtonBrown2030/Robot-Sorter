using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/*
public class RaycastTrigger : MonoBehaviour
{
    public UnityEvent startCast, stopCast;

    public Camera sceneCamera;
    public LinePointsSO sOLinePoints;
    public LIneRenderPoitns lRP;
    public LineRenderer lineRenderer;

    public void RacycatingStart()
    {
        
        if(Input.GetButtonDown("Fire1")) // on mouse down or input system(traking inputs)  touch inputs on phone
        {
            sOLinePoints.ClearVector3List();
        }


        if(Input.GetButton("Fire1")) // && Vector3.Distance(sOlinePoints.vector3Points, distaince) > new Vector3(0,0,0))
        {

            Ray myRay = sceneCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit mayRayCastHit;
            lRP.GetLineRedenrderPOints();

            if(Physics.Raycast(myRay, out mayRayCastHit))
            {

                lineRenderer.positionCount = points.Count;
                lineRenderer.SetPositions(points.ToArray());

            }

        }
        
        startCast.Invoke();
        
    }
    
    
    
    
}
*/