using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Vector3So : ScriptableObject
{
    public Vector3 v3Postion;

    public void UpdatePostion(Vector3 postion)
    {

        v3Postion = postion;

    }
    
}
