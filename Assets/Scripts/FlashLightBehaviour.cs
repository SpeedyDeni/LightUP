using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightBehaviour : MonoBehaviour
{
    public List<GameObject> real;
    public List<GameObject> fake;
    public GameObject flashlight;

    void Update()
    {
        if (flashlight.activeInHierarchy==false)
        {
            for (int i = 0; i < real.Count; i++)
            {
                real[i].SetActive(true);
            }
            for (int i = 0; i < fake.Count; i++)
            {
                fake[i].SetActive(false);
            }
        }
        else
        {
            for (int i = 0; i < real.Count; i++)
            {
                real[i].SetActive(false);
            }
            for (int i = 0; i < fake.Count; i++)
            {
                fake[i].SetActive(true);
            }
        }
    }
}
