using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InShopStreet : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.InShop = true;
        GameManager.Instance.receivedMessage = true;
    }
}
