using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map2 : MonoBehaviour
{
    public GameObject marker;
    public GameObject Fade;
    void OnMouseDown()
    {
        if (marker.tag == "park")
        {
            Fade.SetActive(true);
            SceneManager.LoadScene("Park");
        }
        else if (marker.tag == "bakery")
        {
            Fade.SetActive(true);
            SceneManager.LoadScene("Bakery");
        }
        else if (marker.tag == "shop")
        {
            Fade.SetActive(true);
            SceneManager.LoadScene("ShopStreet");
        }
    }
}
