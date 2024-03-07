using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatFollowFixTests : MonoBehaviour
{
    public GameObject[] PathNode;
    public GameObject Player;
    public float MoveSpeed;
    public float Timer;
    public Vector3So CurrentPositionHolder;
    public int CurrentNode;
    private Vector3 startPosition;

    // Use this for initialization
    void Start()
    {
        CheckNode();
    }

    void CheckNode()
    {
        Timer = 0;
        startPosition = Player.transform.position;

        if (PathNode != null && PathNode.Length > 0 && CurrentNode < PathNode.Length)
        {
            CurrentPositionHolder.v3Postion = PathNode[CurrentNode].transform.position;
        }
        else
        {
            // Reset to the first node if PathNode is null or empty
            CurrentNode = 0;

            // Check if there are elements in PathNode before accessing
            if (PathNode != null && PathNode.Length > 0)
            {
                CurrentPositionHolder.v3Postion = PathNode[CurrentNode].transform.position;
            }
            else
            {
                Debug.LogError("PathNode is null or empty. Please assign nodes in the inspector.");
            }
        }
    }

    void Update()
    {
        Timer += Time.deltaTime * MoveSpeed;

        if (Player.transform.position != CurrentPositionHolder.v3Postion)
        {
            Player.transform.position = Vector3.Lerp(startPosition, CurrentPositionHolder.v3Postion, Timer);
        }
        else
        {
            if (CurrentNode < PathNode.Length - 1)
            {
                CurrentNode++;
                CheckNode();
            }
        }
    }
}
