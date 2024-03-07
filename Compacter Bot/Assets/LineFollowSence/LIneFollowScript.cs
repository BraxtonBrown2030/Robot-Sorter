using Unity.VisualScripting;
using UnityEngine;

public class LIneFollowScript : MonoBehaviour
{
    public GameObject[] pathNode;
    public GameObject player;
    public float moveSpeed;
    public float timer;
    public Vector3So currentPositionHolder;
    public int currentNode;
    public Vector2 startPosition;
    public Camera sceneCamera;
    public GameObject pathPreFab;

// Use this for initialization
    void Start () 
    {
//PathNode = GetComponentInChildren<>();
        CheckNode ();
    }

    void CheckNode()
    {
        timer = 0;
        startPosition = player.transform.position;
        currentPositionHolder.v3Postion = pathNode[currentNode].transform.position;
    }

// Update is called once per frame
    void Update () 
    {

        timer += Time.deltaTime * moveSpeed;

        if (player.transform.position != currentPositionHolder.v3Postion) 
        {

            player.transform.position = Vector3.Lerp (startPosition, currentPositionHolder.v3Postion, timer);
        }
        else
        {

            if(currentNode <pathNode.Length -1)
            {
                currentNode++;
                CheckNode ();
            }
        }

        if (Input.GetButtonDown("Fire"))
        {
            
            Ray myRay = sceneCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit mayRayCastHit;

            if(Physics.Raycast(myRay, out mayRayCastHit))
            {

                Instantiate(pathPreFab, transform.position, Quaternion.identity);

            }
            
            
        }
    }
}
