using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffMessages : MonoBehaviour
{
    public List<GameObject> on;
    public List<GameObject> off;

    void OnMouseDown()
    {
        for (int i = 0; i < GameManager.Instance.messages; i++)
        {
            on[i].SetActive(true);
        }
        for (int i = 0; i < off.Count; i++)
        {
            off[i].SetActive(false);
        }
    }
}
