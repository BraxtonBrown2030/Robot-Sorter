using System.Collections.Generic;
using UnityEngine;
using System.Collections;

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

    void Update()
    {
        Debug.Log(pointNumber);
        // clears scriptible object list for new line to be drawn
        if(Input.GetButtonDown("Fire1")) // on mouse down or input system(traking inputs)  touch inputs on phone
        {
            points.Clear();
            sOlinePoints.ClearVector3List();
        }

        // casts ray and creates a line point as well adds that point to the list
        if(Input.GetButton("Fire1"))
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
        }
        
        else if (lineRendererON == true && pointNumber < sOlinePoints.vector3Points.Count)
        {
            Vector3 targetPosition = sOlinePoints.vector3Points[pointNumber];
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            //Debug.Log(pointNumber);
            // Check if the player has reached the current target point
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                // Move to the next point in the list
                pointNumber++;
                //targetPosition = sOlinePoints.vector3Points[pointNumber];
            }
            if (pointNumber >= sOlinePoints.vector3Points.Count)
            {
                // Optional: You can add additional logic when the player reaches the last point
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