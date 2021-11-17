using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public GameObject Shop;
    public GameObject Office;
    public GameObject player;
    public GameObject EnterShop;
    public GameObject foodHolder;
    public List<FoodInTheShop> foodList;
    public Shop thisShop;


    void Start ()
    {
        if (EnterShop != null)
        {
            EnterShop.SetActive(false);
        }
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        EnterShop.SetActive(true);
        if(thisShop != null)
        {
            foodHolder.gameObject.SetActive(true);
        for(int i = 0; i < foodList.Count; i++){
            foodList[i].gameObject.SetActive(true);
            foodList[i].SetFood(thisShop.menu[i]);
    
        }
        }
        
    }
void OnTriggerExit2D(Collider2D other)
    {
        EnterShop.SetActive(false);
        if (thisShop != null)
        {
            for (int i = 0; i < foodList.Count; i++)
            {
                foodList[i].gameObject.SetActive(false);

            }
            foodHolder.gameObject.SetActive(false);
        }
    }

    public void teleport()
    {
        player.transform.position = Shop.transform.position;
    }
}
