using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotifToggle : MonoBehaviour
{
    public List<GameObject> content;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        for(int i=0; i<content.Count; i++)
        {
            content[i].SetActive(true);
        }
    }
}