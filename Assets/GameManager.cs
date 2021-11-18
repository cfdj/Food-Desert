using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour

{
    public PhoneManager phone;
    public HungerBar hungerbar;
    public float Initialhunger = 25;
    public float hungerGain = 10;
    public float MaxHunger = 100;
    public float hunger = 0;
    public int hungerIncrement = 120; //how many frames it takes to increment hunger
    public int currentHungerIncrement = 0;
    public int Day = 1;
    public Timer timer;
    public float totalTime = 180f;


    public List<Messages> todaysMessages;
    public MessageDays messageDays;

    public float money = 50;
    public Text moneyText;


    public static GameManager gameManager;
    public GameOverScreen gameOverScreen;

    public GameObject WorkScreen;
    private bool AtWork = false;

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
        messageDays.Setup();//setting up the list within message days
        todaysMessages = messageDays.getDaysMessages(0);
        phone.recieveMessage(todaysMessages);
}

    // Fixed update for consistent timing
    void FixedUpdate()
    {
        if (!AtWork)
        {
            currentHungerIncrement += 1;
            if (currentHungerIncrement >= hungerIncrement)
            {
                currentHungerIncrement = 0;
                hunger = hunger + 1;
                hungerbar.set(hunger);
            }
            GameOver();
        }
        if (Input.GetButtonDown("Cancel"))
        {
            Application.Quit();
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
        StartCoroutine(workDay());
        Day = Day + 1;
        timer.timeRemaining = totalTime;
        hunger += hungerGain;
        //Giving the phone todays messages:
        todaysMessages = messageDays.getDaysMessages(Day);
        phone.recieveMessage(todaysMessages);
        
    }
    // work day timer
    IEnumerator workDay()
    {
        WorkScreen.SetActive(true);
        AtWork = true;
        yield return new WaitForSeconds(10f);
        WorkScreen.SetActive(false);
        AtWork = false;
        yield return null;
    }

    //adding a message to the list of messages for a day:
    public void addMessage(Messages toAdd,int dayNum)
    {
        messageDays.AddMessage(toAdd, dayNum);
    }

    // code for game overs
    public void GameOver()
    {
        if (money <= 0)
        {
            gameOverScreen.NoMoney();
        }

        if (hunger >= MaxHunger)
        {
            gameOverScreen.Starved();
        }

    }
}
