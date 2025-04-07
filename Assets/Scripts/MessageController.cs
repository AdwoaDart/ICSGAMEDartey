using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageController : MonoBehaviour
{
    public GameObject firstMessage;
    public GameObject secondMessage;

    void Start()
    {
        firstMessage.SetActive(true); 
    }

    public void ShowSecondMessage()
    {
        firstMessage.SetActive(false);
        secondMessage.SetActive(true);
    }

    public void CloseSecondMessage()
    {
        secondMessage.SetActive(false);
    }


}
