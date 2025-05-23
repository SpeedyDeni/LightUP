using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneIsActive : MonoBehaviour
{
    void OnEnable()
    {
        GameManager.Instance.phoneisactive = true;
    }
    void OnDisable()
    {
        GameManager.Instance.phoneisactive = false;
    }
}
