using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

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


    void Start()
    {
        
        

    }

    void Update()
    {
        
        StartMovement();

        if(Input.GetButtonDown("Fire1"))
        {
            points.Clear();
            sOlinePoints.ClearVector3List();
        }


        if(Input.GetButton("Fire1"))
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

        if(lineRendererON == true)
        {

            transform.position = Vector3.MoveTowards(transform.position, new Vector3(lRP.transform.position.x,0.5f,lRP.transform.position.y), moveSpeed * Time.deltaTime);

        }  

    }

    public void StartMovement()
    {

        if(Input.GetKey(KeyCode.R))
        {

            lineRendererON = true;
            Debug.Log("R pressed");
        }
    }
}
