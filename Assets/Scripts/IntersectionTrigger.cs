using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntersectionTrigger : MonoBehaviour
{
    [SerializeField] Street street;
    public enum End {
        Left,Right
    }
    public End end;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(end == End.Left)
        {
            street.LeftTriggerEnter();
        }
        else
        {
            street.RightTriggerEnter();
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        street.intersectionOff();
    }
}
