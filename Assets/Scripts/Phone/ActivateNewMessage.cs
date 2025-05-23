using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateNewMessage : MonoBehaviour
{
    void OnEnable()
    {
            GameManager.Instance.receivedMessage = true;
    }
}