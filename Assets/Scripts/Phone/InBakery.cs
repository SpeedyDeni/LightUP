using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InBakery : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.InBakery1 = true;
        GameManager.Instance.receivedMessage = true;
    }
}
