using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public static Map map;
    [SerializeField] private Street currentStreet;
    public GameObject player;

    //ensures only 1 map is ever present
    private void Awake()
    {
        if(map != null && map != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            map = this;
        }
    }
    //Updates the current street and figures out which end the player should be placed at
    public void moveStreet(Intersection intersection, int streetNumber)
    {
        currentStreet = intersection.streets[streetNumber];
        if (intersection == currentStreet.Left)
        {
            player.transform.position = currentStreet.LeftSpawn.transform.position;
        }
        else
        {
            player.transform.position = currentStreet.RightSpawn.transform.position;
        }
    }
}
