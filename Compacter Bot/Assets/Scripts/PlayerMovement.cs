using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class PlayerMovement : MonoBehaviour
{

    [Header("Values")]
    public bool lineRendererON;
    public float moveSpeed;

    [Header("Lists")]
    private List<Vector3> points = new List<Vector3>();
    private Vector3[] pointsArry;

    [Header("Raycast / Marking Objects")]
    public LineRenderer lineRenderer;
    public Camera sceneCamera;
    public LIneRenderPoitns lRP;
    public LinePointsSO sOlinePoints;
    
    [Header("Testing Varbales")]
    public Vector3 distaince;
     public int pointNumber;
     public Vector3So removelNumber;
     public Vector3So secondRemvoelNum;


     void Update()
    {
        Debug.Log(pointNumber);
        // clears scriptible object list for new line to be drawn
        if(Input.GetButtonDown("Fire1")) // on mouse down or input system(traking inputs)  touch inputs on phone
        {
            points.Clear();
            sOlinePoints.ClearVector3List();
            pointNumber = 0;
        }

        // casts ray and creates a line point as well adds that point to the list
        if(Input.GetButtonDown("Fire1")) // change from getbutton to get button down
        {

            Ray myRay = sceneCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit mayRayCastHit;
            lRP.GetLineRedenrderPOints();

             if(Physics.Raycast(myRay, out mayRayCastHit))
            {

                points.Add(mayRayCastHit.point);

                lineRenderer.positionCount = points.Count;
                lineRenderer.SetPositions(points.ToArray());
                
            }
           // removelNumber.v3Postion = sOlinePoints.vector3Points[0]; //
            //secondRemvoelNum.v3Postion = sOlinePoints.vector3Points[2]; //
        }
        
        else if (lineRendererON == true && pointNumber < sOlinePoints.vector3Points.Count)
        {
            // changes to 0,0,0 for some reason then gose back to first point in line render array
            Vector3 targetPosition = sOlinePoints.vector3Points[pointNumber];
           // sOlinePoints.vector3Points.RemoveAll(v => v == removelNumber.v3Postion); //
           // sOlinePoints.vector3Points.RemoveAll(v => v == secondRemvoelNum.v3Postion);// test line
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            // Check if the player has reached the current target point
            if (Vector3.Distance(transform.position, targetPosition) < .2f)
            {
                // Move to the next point in the list
                pointNumber++;
                //targetPosition = sOlinePoints.vector3Points[pointNumber];
            }
            if (pointNumber >= sOlinePoints.vector3Points.Count)
            {
                // can add additional logic when the player reaches the last point
                Debug.Log("Player reached the last point!");
            }
        }


        
        
        /*
        
        // handles movement to the listed object
        else if(lineRendererON == true)
        {
            foreach (Vector3 points in sOlinePoints.vector3Points)
            {

                transform.position = Vector3.MoveTowards(transform.position, sOlinePoints.vector3Points[pointNumber], moveSpeed * Time.deltaTime);

            }
        }
        */
    }
}