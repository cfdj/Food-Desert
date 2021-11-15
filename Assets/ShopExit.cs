using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopExit : MonoBehaviour
{
    public GameObject Shop;
    public GameObject player;
    //public GameObject EnterShop;
    public GameObject ExitShop;

    // Start is called before the first frame update
    void Start()
    {
     //EnterShop.SetActive(false);
        ExitShop.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //EnterShop.SetActive(true);
        ExitShop.SetActive(true);
    //player.transform.position = Shop.transform.position;
    }
void OnTriggerExit2D(Collider2D other)
    {
        //EnterShop.SetActive(false);
        ExitShop.SetActive(false);

    }
}
