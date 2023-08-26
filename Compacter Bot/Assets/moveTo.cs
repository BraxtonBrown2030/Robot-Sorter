using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTo : MonoBehaviour
{
    
    public PlayerMovement pM;
    public float moveSpeed;

    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        
        if(pM.lineRendererON == true)
        {

            transform.position = Vector3.MoveTowards(transform.position, pM.lineRenderer.transform.position, moveSpeed * Time.deltaTime);

        }


    }
}
