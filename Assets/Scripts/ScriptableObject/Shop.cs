using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Shop", menuName = "ScriptableObject/Shop")]
public class Shop : ScriptableObject
{
    public Sprite shopFront;
    public List<Food> menu;
    public int priceEst = 1; //value of 1 to 3
}
