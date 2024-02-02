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
        
        // handles movement to the listed object
        else if(lineRendererON == true)
        {
            foreach (Vector3 points in sOlinePoints.vector3Points)
            {

                transform.position = Vector3.MoveTowards(transform.position, sOlinePoints.vector3Points[pointNumber], moveSpeed * Time.deltaTime);

            }
        }
    }
}