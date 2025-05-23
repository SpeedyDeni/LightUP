using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Tcode : MonoBehaviour
{
    public TMP_InputField pass;
    void OnMouseDown()
    {
        if (pass.text == "281")
        {
            SceneManager.LoadScene("Cutscene2");
        }
    }
}
