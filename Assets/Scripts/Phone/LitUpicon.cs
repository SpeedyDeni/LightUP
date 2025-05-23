using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LitUpicon : MonoBehaviour
{
    public GameObject LitUpPhone;
    bool pressed;
    void Update()
    {
        if (GameManager.Instance.litUp)
        {
            LitUpPhone.SetActive(true);
        }
        else
        {
            LitUpPhone.SetActive(false);
        }
    }
}
