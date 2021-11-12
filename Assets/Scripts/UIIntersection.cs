using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIIntersection : MonoBehaviour
{
    public GameObject buttonHolder;
    private Intersection currentIntersection;
    public Button North;
    public Button West;
    public Button East;
    public Button South;
    // Start is called before the first frame update
    void Start()
    {
        buttonHolder.SetActive(false);
    }

    public void turnOnButtons(Intersection intersection)
    {
        buttonHolder.SetActive(true);
        currentIntersection = intersection;
        bool[] toturnOn = intersection.GetConnections();
        North.gameObject.SetActive(toturnOn[0]);
        East.gameObject.SetActive(toturnOn[1]);
        South.gameObject.SetActive(toturnOn[2]);
        West.gameObject.SetActive(toturnOn[3]);

        //Turning off the button for the current street
        int current =5;
        for (int i = 0; i < 4; i++)
        {
            if (intersection.streets[i] == Map.map.currentStreet)
            {
                current = i;
            }
        }
        if (current == 0)
        {
            North.gameObject.SetActive(false);
        }
        else if (current == 1)
        {
            East.gameObject.SetActive(false);
        }
        else if (current == 2)
        {
            South.gameObject.SetActive(false);
        }
        else if (current == 3)
        {
            West.gameObject.SetActive(false);
        }
    }
    public void OnButtonDown(int direction)
    {
        Map.map.moveStreet(currentIntersection, direction);
        buttonHolder.SetActive(false);
    }
    public void ButtonsOff()
    {
        buttonHolder.SetActive(false);
    }
}
