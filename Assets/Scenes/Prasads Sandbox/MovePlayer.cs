using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovePlayer : MonoBehaviour
{
    public GameObject Shop;
    public GameObject player;
    public GameObject EnterShop;
    //public GameObject ExitShop;

    void Start ()
    {
        EnterShop.SetActive(false);
        //ExitShop.SetActive(false);
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        EnterShop.SetActive(true);
        //ExitShop.SetActive(true);
    //player.transform.position = Shop.transform.position;
    }
void OnTriggerExit2D(Collider2D other)
    {
        EnterShop.SetActive(false);
       // ExitShop.SetActive(false);

    }

    public void teleport()
    {
        //If (EnterShop = true)
        //{
        player.transform.position = Shop.transform.position;
    }
   // }


    
}
