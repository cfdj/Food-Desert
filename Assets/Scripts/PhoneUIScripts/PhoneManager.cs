using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PhoneManager : MonoBehaviour
{
    public bool messageNotification;
    private List<Messages> todaysMessages = new List<Messages>(); //works like a stack, with the last message being popped off when read
    private Messages currentMessage;
    public Image bigNotification;
    public Image smallNotification;
    public Text numMessages;

    public List<ShopDisplay> displays;
    public List<Shop> shops;

    //Notification ui
    public Image messageBackground;
    public Text messageText;
    public Text messageSender;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < displays.Count && i< shops.Count; i++)
        {
            displays[i].SetShop(shops[i]);
            displays[i].gameObject.SetActive(true);
        }
    }
    public void recieveMessage(List<Messages> newMessages)
    {
        foreach(Messages m in todaysMessages) //set all of the previous days messages as ignored if they're still there
        {
            if(m.ignore != null)
            {
                GameManager.gameManager.addMessage(m.ignore, m.ignoreDay);
            }
        }
        todaysMessages = newMessages;
        if (todaysMessages.Count > 0)
        {
            messageNotification = true;
            bigNotification.gameObject.SetActive(true);
            smallNotification.gameObject.SetActive(true);
            numMessages.text = "" + todaysMessages.Count;
            nextMessage();
        }
    }

    public void onClickMessage()
    {
        //do something with the current message
        if(todaysMessages.Count == 0)
        {
            bigNotification.gameObject.SetActive(false);
            smallNotification.gameObject.SetActive(false);
        }
        else
        {
            numMessages.text = "" + todaysMessages.Count;
        }
        messageText.text = currentMessage.messageContent;
        messageSender.text = currentMessage.sender;
        messageBackground.gameObject.SetActive(true);
    }
    public void onClickRespond()
    {
        messageBackground.gameObject.SetActive(false);
        if (currentMessage.reply != null)
        {
            GameManager.gameManager.addMessage(currentMessage.reply, currentMessage.replyDay);
        }
        nextMessage();
    }
    public void onClickIgnore()
    {
        messageBackground.gameObject.SetActive(false);
        if (currentMessage.ignore != null)
        {
            GameManager.gameManager.addMessage(currentMessage.ignore, currentMessage.ignoreDay);
        }
        nextMessage();
    }
    public void nextMessage()
    {
        if (todaysMessages.Count > 0)
        {
            currentMessage = todaysMessages[todaysMessages.Count - 1];
            todaysMessages.RemoveAt(todaysMessages.Count - 1);
        }
    }
}
