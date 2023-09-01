using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LinePointsSO : ScriptableObject
{

    public List<Vector3> vector3Points = new List<Vector3>();

    public void ClearVector3List()
    {

        vector3Points.Clear();

    }


}
