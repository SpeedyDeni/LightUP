using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnPhone : MonoBehaviour
{
    void OnMouseDown()
    {
        if (GameManager.Instance.phone.activeInHierarchy == false)
        {
            GameManager.Instance.phone.SetActive(true);
        }
        else
        {
            GameManager.Instance.phone.SetActive(false); 
        }
        
    }
}
