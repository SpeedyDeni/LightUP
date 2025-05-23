using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Password : MonoBehaviour
{
    public TMP_InputField pass;
    public GameObject flashlight;
    public List<GameObject> on;
    public List<GameObject> off;

    void Update()
    {
        if (flashlight.activeInHierarchy==false)
        {
            if (pass.text == "RUFFLE" || pass.text == "ruffle" || pass.text == "Ruffle" || pass.text == "rUFFLE")
            {
                for (int i = 0; i < on.Count; i++)
                {
                    on[i].SetActive(true);
                }
                for (int i = 0; i < off.Count; i++)
                {
                    off[i].SetActive(false);
                }
            }
        }
        else
        {
            if (pass.text == "SPICY" || pass.text == "spicy" || pass.text == "Spicy" || pass.text == "sPICY")
            {
                for (int i = 0; i < on.Count; i++)
                {
                    on[i].SetActive(true);
                }
                for (int i = 0; i < off.Count; i++)
                {
                    off[i].SetActive(false);
                }
            }
        }
        
    }
}
