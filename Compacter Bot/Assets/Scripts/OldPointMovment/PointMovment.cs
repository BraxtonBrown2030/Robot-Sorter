using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public class PointMovment : MonoBehaviour
{
    
    public GameObject[] points;
    private int curPointsPlaced;
    public int curPlayerMove;

    [SerializeField] private Camera mainCamera;

    void Update()
    {
        
    }

    private void MovePoint()
    {

        if(Input.GetMouseButtonDown(0) && Time.timeScale == 0)
        {

            Ray myRay = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit myRayCastHit;

            if(Physics.Raycast(myRay, out myRayCastHit))
            {

                points[curPointsPlaced].transform.position = myRayCastHit.point;
                curPointsPlaced += 1;

            }

        }

    }

    private void ResetPoints()
    {

        if(Input.GetKeyDown(KeyCode.R))
        {

            curPointsPlaced = 0;

        }

    }
}
