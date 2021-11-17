using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PhoneManager : MonoBehaviour
{
    public bool messageNotification;
    private Messages currentMessage;
    public Image bigNotification;
    public Image smallNotification;

    public List<ShopDisplay> displays;
    public List<Shop> shops;

    //Notification ui
    public Button messageBackground;
    public Text messageText;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < displays.Count && i< shops.Count; i++)
        {
            displays[i].SetShop(shops[i]);
            displays[i].gameObject.SetActive(true);
        }
    }
    public void recieveMessage(Messages newMessage)
    {
        currentMessage = newMessage;
        messageNotification = true;
        bigNotification.gameObject.SetActive(true);
        smallNotification.gameObject.SetActive(true);
    }

    public void onClickMessage()
    {
        //do something with the current message
        messageNotification = false;
        bigNotification.gameObject.SetActive(false);
        smallNotification.gameObject.SetActive(false);

        messageText.text = currentMessage.messageContent;
        messageBackground.gameObject.SetActive(true);
    }
    public void onClickReadNotification()
    {
        messageBackground.gameObject.SetActive(false);
    }
}
