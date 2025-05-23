using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Passkey : MonoBehaviour
{
    public TMP_InputField pass;
    public GameObject Available;
    public GameObject Answer;

    void Update()
    {

        if (pass.text == "SECRET" || pass.text == "secret" || pass.text == "Secret" || pass.text == "sECRET")
        {
            GameManager.Instance.InBakery2 = true;
            GameManager.Instance.receivedMessage = true;
            Available.SetActive(false);
            Answer.SetActive(true);
        }
    }
}
