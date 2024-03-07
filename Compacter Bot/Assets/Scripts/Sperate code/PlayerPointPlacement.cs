using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPointPlacement : MonoBehaviour
{

    public Camera senceCamera;
    public GameObject point;
    private Vector3 offsetPosition;
    
    
    void Update()
    {

        if (Input.GetButtonDown("Fire1")) // change from getbutton to get button down
        {

            Ray myRay = senceCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit mayRayCastHit;

            if (Physics.Raycast(myRay, out mayRayCastHit))
            {

                
                StartCoroutine(TimedPlacement());
               

            }

        }
    }

    public IEnumerator TimedPlacement()
    {
        offsetPosition = transform.position - senceCamera.ScreenToWorldPoint(Input.mousePosition);
        Ray myRay = senceCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit mayRayCastHit;
        
        Debug.Log("started time");
        
        // test - senceCamera.ScreenToWorldPoint(Input.mousePosition) + offsetPosition
        
        Instantiate(point, senceCamera.ScreenToWorldPoint(Input.mousePosition) + offsetPosition, Quaternion.identity);
        
        yield return new WaitForSeconds(3f);
        
        Debug.Log("finished time");

    }
    
}
