using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulb : MonoBehaviour
{
    public GameObject color1;
    public GameObject color2;
    public GameObject color3;
    public GameObject color4;
    public GameObject color5;
    public int on=0;
    public int i = 1;
    public GameObject puller;
    public Vector3 poz;

    void OnMouseDown()
    {
        if (on == 0)
        {
            poz= new Vector3 (transform.position.x, transform.position.y, transform.position.z);
            puller.transform.position = new Vector3(0, 0, 0);
            if (i <= 5)
            {
                on = i;
                i++;
            }
            else
            {
                i = 1;
                on = i;
                i++;
            }

            if (on == 1)
            {
                color1.SetActive(true);
            }
            else if (on == 2)
            {
                color2.SetActive(true);
            }
            else if (on == 3)
            {
                color3.SetActive(true);
            }
            else if (on == 4)
            {
                color4.SetActive(true);
            }
            else if (on == 5)
            {
                color5.SetActive(true);
            }
            on = 1;
        }

        else if(on==1)
        {
            puller.transform.position = poz;

            GameObject[] colors = GameObject.FindGameObjectsWithTag("color");

            foreach (GameObject color in colors)
            {
                color.SetActive(false);
            }

            on = 0;
        }
    }
}
