using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{
    public GameObject real;
    public GameObject fake;
    void Start()
    {
        if (real.activeInHierarchy)
        {
            fake.SetActive(true);
        }
        else
        {
            fake.SetActive(false);
        }
    }
}
