using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intersection : MonoBehaviour
{
    //public Street North, East, South, West;
    public Street[] streets;
    public bool[] GetConnections()
    {
        bool[] connected = new bool[4] { false, false, false, false };
        connected[0] = (streets[0] != null);
        connected[1] = (streets[1] != null);
        connected[2] = (streets[2] != null);
        connected[3] = (streets[3] != null);

        return connected;
    }


#if UNITY_EDITOR
    void OnDrawGizmos()
    {
        Vector2 origin = transform.position;
        Gizmos.color = Color.blue;
        bool[] connected = GetConnections();
        for(int i = 0; i < 4; i++)
        {
            if (connected[i])
            {                
                Gizmos.DrawLine(origin, streets[i].transform.position);
            }
        }
     
    }
#endif
}