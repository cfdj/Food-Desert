using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Shop", menuName = "ScriptableObject/Shop")]
public class Shop : ScriptableObject
{
    public Sprite shopFront;
    public List<Food> menu;
}
