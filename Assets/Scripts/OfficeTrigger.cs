using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfficeTrigger : MonoBehaviour
{
    public Button enterOffice;
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == player)
        {
            enterOffice.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject == player)
        {
            enterOffice.gameObject.SetActive(false);
        }
    }

}
