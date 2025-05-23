using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalMap : MonoBehaviour
{
    public GameObject MapLitUp;
    public GameObject LastMap;
    public GameObject Map2;
    void Update()
    {
        if (GameManager.Instance.complete == true)
        {
            MapLitUp.SetActive(true);
            LastMap.SetActive(true);
            Map2.SetActive(false);
            GameManager.Instance.complete = false;
        }
    }
}
