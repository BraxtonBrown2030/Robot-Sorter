using System.Collections.Generic;
using UnityEngine;
using System.Collections;

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

    void Update()
    {

        if(Input.GetButtonDown("Fire1")) // on mouse down or input system(traking inputs)  touch inputs on phone
        {
            points.Clear();
            sOlinePoints.ClearVector3List();
        }


        if(Input.GetButton("Fire1")) // && Vector3.Distance(sOlinePoints.vector3Points, distaince) > new Vector3(0,0,0))
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

        else if(lineRendererON == true) //&& Input.touchCount > 0f)
        {

            // transform.position = Vector3.MoveTowards(transform.position, sOlinePoints.vector3Points.First(), moveSpeed * Time.deltaTime);
            
            // old target vector 3 : new Vector3(lRP.transform.position.x,0.5f,lRP.transform.position.y

            foreach (Vector3 points in sOlinePoints.vector3Points)
            {

                transform.position = Vector3.MoveTowards(transform.position,points, .5f * Time.deltaTime);

                // StartCoroutine(ExampleCoroutine());

            }
            
        }

    }
    IEnumerator ExampleCoroutine()
    {
        
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

    }
    
}