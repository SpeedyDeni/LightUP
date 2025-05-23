using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    public GameObject lights;

    void OnMouseEnter()
    {
        if (lights.activeInHierarchy == false)
        {
            lights.SetActive(true);
        }
    }
    void OnMouseExit()
    {
        lights.SetActive(false);
    }
}
