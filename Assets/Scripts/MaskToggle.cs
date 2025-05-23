using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MaskToggle : MonoBehaviour
{
    public List <GameObject> real;
    public List <GameObject> fake;
    public GameObject mask;
    public GameObject flashlightlight;
    private void OnMouseDown()
    {
        if (mask.activeInHierarchy)
        {
            mask.SetActive(false);
            flashlightlight.SetActive(false);
        }
        else
        {
            mask.SetActive(true);
            flashlightlight.SetActive(true);
        }
    }
}
