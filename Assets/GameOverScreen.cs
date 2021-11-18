using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 3 variables for 3 endings - function to set them true

public class GameOverScreen : MonoBehaviour
{
    public Image GameOverFired;
    public Image GameOverNoMoney;
    public Image GameOverStarved;

    public void Fired()
    {
        GameOverFired.gameObject.SetActive(true);
    }

    public void NoMoney()
    {
        GameOverNoMoney.gameObject.SetActive(true);
    }

     public void Starved()
    {
        GameOverStarved.gameObject.SetActive(true);
    }


}

