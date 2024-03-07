using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickPoint : MonoBehaviour
{
    public GameObject spawnObject;
    public Camera sceneCamera;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        
        // casts ray and creates a line point as well adds that point to the list
        if(Input.GetButtonDown("Fire1"))
        {

            Ray myRay = sceneCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit mayRayCastHit;

            if(Physics.Raycast(myRay, out mayRayCastHit))
            {

                Debug.Log("ray works");
                
                // change transform.postion to ray cast point on screen
                Instantiate(spawnObject, mayRayCastHit.transform.position, Quaternion.identity);

            }
  
        }
        
        
    }
}
