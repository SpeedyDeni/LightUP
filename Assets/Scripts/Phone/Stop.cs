using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public GameObject anim;
    public GameObject on;
    void Update()
    {
        anim.SetActive(false);
        on.SetActive(true);
    }
}
