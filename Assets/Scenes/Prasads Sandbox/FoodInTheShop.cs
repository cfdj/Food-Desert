using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodInTheShop : MonoBehaviour
{
    public Image sprite;
    public Text price;
    private Food food;
    void Awake()
    {

    }
    public void SetFood(Food newFood){
        food = newFood;
        sprite.sprite = food.image;
        price.text = "$" + food.price;
    }
}
