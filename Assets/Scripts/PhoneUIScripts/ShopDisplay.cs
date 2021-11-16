using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopDisplay : MonoBehaviour
{
    private Shop shop;
    public Image sprite;
    public Text shopName;
    public Text price;
    public Text foodType;
    void OnEnable()
    {
        if(shop != null)
        {
            sprite.sprite = shop.shopFront;
            shopName.text = shop.name;
            string currency = "";
            for(int i = 0; i < shop.priceEst; i++)
            {
                currency += "£";
            }
            price.text = currency;
        }
    }

    void SetShop(Shop newShop)
    {
        shop = newShop;
        sprite.sprite = shop.shopFront;
        shopName.text = shop.name;
    }
}
