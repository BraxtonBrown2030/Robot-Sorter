using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public GameObject pickup;
    public LineRenderer lineRenderer;
    public bool lineRendererON;
    public Camera sceneCamera;
    public float moveSpeed;
    public List<Transform> lineTransforms;

    void Start()
    {
        
    }

    void Update()
    {
        

        if(Input.GetButtonDown("Fire1"))
        {

            Ray myRay = sceneCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit mayRayCastHit;

            if(Physics.Raycast(myRay, out mayRayCastHit))
            {

                

            }

        }

        if(lineRendererON == true)
        {

            transform.position = Vector3.MoveTowards(transform.position, lineRenderer., moveSpeed * Time.deltaTime);

        }

    }
}
