using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodInTheShop : MonoBehaviour
{
    public Image sprite;
    public Text price;
    private Food food;

   public static List<FoodInTheShop> fooditems = new List<FoodInTheShop>();

    void Awake()
    {
        fooditems.Add(this);
    }

//defining food in the shop
    public void SetFood(Food newFood)
    {
        food = newFood;
        sprite.sprite = food.image;
        price.text = "$" + food.price;
        disableFood();
    }

// clicking on food to buy it i.e. reduce the money
    public void tryToBuy()
    {
        
        GameManager.gameManager.BuyFood(food);

// disable food after a click on food if it becomes unaffordable 
        for (int i=0; i<fooditems.Count; i++)
        {
                fooditems[i].disableFood();

        }
    }

  //disabling food when the player cannot afford it
    public void disableFood()
{
    
    if (!GameManager.gameManager.CheckMoney(food.price))
    { 
    gameObject.GetComponent<Button>().interactable = false;
    }
    else
    {
        gameObject.GetComponent<Button>().interactable = true;
    }
    
}
}
