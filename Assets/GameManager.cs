using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour

{
    public HungerBar hungerbar;
    public float hunger = 25;

    public float money = 50;
    public Text moneyText;

    public static GameManager gameManager;

void Start()
{
    if(gameManager != null && gameManager != this){
        Destroy(this.gameObject);
    }
    if(gameManager == null)
    {
        gameManager = this;
    }
    UpdateMoney();
}

    // Update is called once per frame
    void Update()
    {
        
            hunger = hunger + 1;

        hungerbar.set(hunger);
    }

// add money on a payday
    public void AddMoney(float amount)
    {
        money += amount;
        UpdateMoney();
    }

// reduce money when food is bought
    public void ReduceMoney(float amount)
    {
        money -= amount;
        UpdateMoney();
    }

// check if the money left is enough to buy food
    public bool CheckMoney(float amount)
    {
        if (amount <= money)
        {
            return true;
        }
        return false;
    }

// code for displaying money value
    void UpdateMoney()
    {
        moneyText.text = "$" + money.ToString("N2");

    }

// code for buying food items
    public void BuyFood(Food item)
    {
        if (CheckMoney(item.price))
        {
            ReduceMoney(item.price);
            hunger = hunger - item.hungerLoss;
        hungerbar.set(hunger);

        } 
    }
}
