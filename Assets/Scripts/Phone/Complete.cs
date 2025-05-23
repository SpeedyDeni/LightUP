using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Complete : MonoBehaviour
{
    public GameObject finalmap;
    public GameObject Map2;
    public GameObject litupmap;
    void Update()
    {
        if (GameManager.Instance.complete)
        {
            Map2.SetActive(false);
            finalmap.SetActive(true);
            litupmap.SetActive(true);
        }
    }
}
