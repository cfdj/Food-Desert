using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    public GameObject Shop;
    public GameObject player;
     void OnTriggerEnter2D(Collider2D other)
    {
    player.transform.position = Shop.transform.position;
    }

    
}
