using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Maps2 : MonoBehaviour
{
    public GameObject tile;
    public GameObject pigment;
    public GameObject newmap;
    public GameObject oldmap;
    public GameObject fnewmap;
    public GameObject foldmap;
    public GameObject FlashLight;
    void OnMouseDown()
    {
        if (tile.tag == "correct")
        {
            pigment.SetActive(true);
        }
        else if (tile.tag == "final")
        {
            foldmap.SetActive(false);
            fnewmap.SetActive(true);
            oldmap.SetActive(false);
            newmap.SetActive(true);
            SceneManager.LoadScene("Cutscene2");

        }
        else if (tile.tag == "Untagged")
        {
            if (FlashLight.activeInHierarchy == false)
            {
                GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("on");

                foreach (GameObject nottile in gameObjectArray)
                {
                    nottile.SetActive(false);
                }
            }
            else
            {
                GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("onf");

                foreach (GameObject nottile in gameObjectArray)
                {
                    nottile.SetActive(false);
                }
            }

        }
    }
}
