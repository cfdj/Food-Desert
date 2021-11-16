using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour

{
    public HungerBar hungerbar;
    public float hunger = 25;




    // Update is called once per frame
    void Update()
    {
        
            hunger = hunger + 1;
          

    }
}
