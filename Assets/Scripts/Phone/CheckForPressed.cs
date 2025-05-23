using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForPressed : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameManager.Instance.litUp = false;
    }
}
