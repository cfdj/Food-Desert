using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Food",menuName = "ScriptableObject/Food") ]
public class Food : ScriptableObject
{
    public float price;
    public float hungerLoss;
    public Sprite image;

}
