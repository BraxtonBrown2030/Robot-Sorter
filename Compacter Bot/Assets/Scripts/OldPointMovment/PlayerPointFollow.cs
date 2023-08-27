using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPointFollow : MonoBehaviour
{
   public PointMovment pmovment;
   public GameObject pointsmovement;
   public float speed = 4;

    void Start()
    {
    
        Time.timeScale = 0;
        pmovment = GameObject.FindGameObjectWithTag("MovePoint").GetComponent<PointMovment>();

    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {

            Time.timeScale = 0;

        }

        if(Time.timeScale == 1)
        {

            Movemnt();

        }

    }

    void Movemnt()
    {

        transform.position = Vector3.MoveTowards(transform.position, pmovment.points[pmovment.curPlayerMove].transform.position, speed * Time.deltaTime);

    }
}
