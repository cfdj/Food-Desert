using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    public GameObject Shop;
    public GameObject Office;
    public GameObject player;
    public GameObject EnterShop;
    public List<FoodInTheShop> foodList;
    public Shop thisShop;


    void Start ()
    {
        EnterShop.SetActive(false);
        
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        EnterShop.SetActive(true);
        if(thisShop != null)
        {
        for(int i = 0; i<4; i++){
            foodList[i].gameObject.SetActive(true);
            foodList[i].SetFood(thisShop.menu[i]);

        }
        }
        
    }
void OnTriggerExit2D(Collider2D other)
    {
        EnterShop.SetActive(false);
        

    }

    public void teleport()
    {
        player.transform.position = Shop.transform.position;
    }
}
