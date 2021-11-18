using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour

{
    public PhoneManager phone;
    public HungerBar hungerbar;
    public float Initialhunger = 25;
    public float MaxHunger = 100;
    public float hunger = 0;
    public int hungerIncrement = 120; //how many frames it takes to increment hunger
    public int currentHungerIncrement = 0;
    public int Day = 1;
    public Timer timer;
    public float totalTime = 180f;


    public List<Messages> todaysMessages;


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
        hunger = Initialhunger;
        hungerbar.set(hunger);
}

    // Fixed update for consistent timing
    void FixedUpdate()
    {
        currentHungerIncrement += 1;
        if (currentHungerIncrement >= hungerIncrement)
        {
            currentHungerIncrement = 0;
            hunger = hunger + 1;
            hungerbar.set(hunger);
        }
        
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
// code for day cycle
    public void NextDay()
    {
        Day = Day + 1;
        timer.timeRemaining = totalTime;
        hunger += Initialhunger; //adding hunger for the start of the day
        //Giving the phone todays messages:
        phone.recieveMessage(todaysMessages);
    }
    
}
