using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SOGameObjectArray : ScriptableObject
{
    public GameObject[] followPath;
    public GameObject path;
    public int arraySize;
    
    public void ClearList()
    {

        followPath = new GameObject[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            followPath[i] = Instantiate(path, Vector3.zero, Quaternion.identity);
            // You might want to adjust the position and rotation accordingly
        }

    }

}