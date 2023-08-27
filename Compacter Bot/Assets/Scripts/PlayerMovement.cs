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

    void Start()
    {
        
        

    }

    void Update()
    {
        
        if(Input.GetButtonDown("Fire1"))
        {
            points.Clear();
        }


        if(Input.GetButton("Fire1"))
        {

            Ray myRay = sceneCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit mayRayCastHit;

            if(Physics.Raycast(myRay, out mayRayCastHit))
            {

                points.Add(mayRayCastHit.point);

                lineRenderer.positionCount = points.Count;
                lineRenderer.SetPositions(points.ToArray());  

            }

        }

        if(lineRendererON == true)
        {

            transform.position = Vector3.MoveTowards(transform.position, lineRenderer.transform.position , moveSpeed * Time.deltaTime);

        }  
    }
}
