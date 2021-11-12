using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Street : MonoBehaviour
{
    public Intersection Left;
    public Intersection Right;

    public GameObject LeftSpawn;
    public GameObject RightSpawn;

    public void LeftTriggerEnter()
    {
        if (Left != null)
        {
            Map.map.intersectionOn(Left);
        }
    }
    public void RightTriggerEnter()
    {
        if (Right != null)
        {
            Map.map.intersectionOn(Right);
        }
    }
    public void intersectionOff()
    {
        Map.map.intersectionOff();
    }
}
