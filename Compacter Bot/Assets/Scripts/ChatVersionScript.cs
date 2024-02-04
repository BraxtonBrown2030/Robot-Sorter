using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatVersionScript : MonoBehaviour
{

    [Header("Values")]
    public bool lineRendererON;
    public float moveSpeed;

    [Header("Raycast / Marking Objects")]
    public LineRenderer lineRenderer;
    public Camera sceneCamera;
    public LIneRenderPoitns lRP;
    public LinePointsSO sOlinePoints;
    private List<Vector3> points = new List<Vector3>();
    
    [Header("Testing Variables")]
    public int pointNumber;
    public bool hasRun = false;

    public enum MovementState
    {
        Idle,
        Moving
    }

    MovementState currentState = MovementState.Idle;

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
        // handles movement to the listed object
        else if (lineRendererON == true && pointNumber < sOlinePoints.vector3Points.Count)
        {
            Vector3 targetPosition = sOlinePoints.vector3Points[pointNumber];

            switch (currentState)
            {
                case MovementState.Idle:
                    // Check if the player has reached the current target point
                    if (Vector3.Distance(transform.position, targetPosition) > 0.1f)
                    {
                        // Move towards the target position
                        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
                        currentState = MovementState.Moving; // Change state to Moving
                    }
                    break;

                case MovementState.Moving:
                    // Check if the player has reached the current target point
                    if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
                    {
                        // Move to the next point in the list
                        pointNumber++;

                        // Check if the player has reached the last point
                        if (pointNumber >= sOlinePoints.vector3Points.Count)
                        {
                            // Optional: You can add additional logic when the player reaches the last point
                            Debug.Log("Player reached the last point!");
                            currentState = MovementState.Idle; // Change state to Idle
                        }
                    }
                    break;
            }
        }
    }
}
