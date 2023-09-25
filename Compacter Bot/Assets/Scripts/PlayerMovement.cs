using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.iOS;
using System;
using System.Linq;

public class PlayerMovement : MonoBehaviour
{
    
    [Header("Game Objects")]
    public GameObject pickup; 
    public GameObject pointTesting;

    [Header("Values")]
    public bool lineRendererON;
    public float moveSpeed;

    [Header("Lists")]
    public List<Transform> lineTransforms;
    private List<Vector3> points = new List<Vector3>();
    private Vector3[] pointsArry;

    [Header("Game Managers")]
    public LineRenderer lineRenderer;
    public Camera sceneCamera;
    public LIneRenderPoitns lRP;
    public LinePointsSO sOlinePoints;

    public Vector3 distaince;

    void Start()
    {
        
    

    }

    void Update()
    {

        

        //StartMovement();

        if(Input.GetButtonDown("Fire1")) // on mouse down or input system(traking inputs)  touch inputs on phone
        {
            points.Clear();
            sOlinePoints.ClearVector3List();
        }


        if(Input.GetButton("Fire1") && Vector3.Distance(sOlinePoints.vector3Points.Max, distaince) > new Vector3(0,0,0))
        {

            Ray myRay = sceneCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit mayRayCastHit;
            lRP.GetLineRedenrderPOints(); // Ttestin raycats

             if(Physics.Raycast(myRay, out mayRayCastHit))
            {

                points.Add(mayRayCastHit.point);

                lineRenderer.positionCount = points.Count;
                lineRenderer.SetPositions(points.ToArray());  

            }

        }

            else if(lineRendererON == true && Input.touchCount > 0f)
            {

                transform.position = Vector3.MoveTowards(transform.position, new Vector3(lRP.transform.position.x,0.5f,lRP.transform.position.y), moveSpeed * Time.deltaTime);

            }
        

            if(Input.touchCount > (0))
            {
 
                Debug.Log("touch works");
                
            }

    }

/*
    public void StartMovement()
    {

        if(Input.GetKeyDown(KeyCode.R))
        {

            lineRendererON = true;
            Debug.Log("R pressed");
        }
    }
*/

void TestCode()
{


    if (Step2Points(start, next, ref distance, ref remainingDistance, out Vector3 point))
    {
        MarkPoint(point);
        start = point;
    }

    lineRenderer.GetPosition(i);
    i++;

}



}
