using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Code : MonoBehaviour
{
    public TMP_InputField pass;
    public GameObject triggerr;
    public GameObject triggerf;
    public GameObject Answer;
    public GameObject inti;
    bool receivedMessageOnPark;
    void Update()
    {
        if (pass.text == "4291")
        {
            GameManager.Instance.InPark = true;
            if (!receivedMessageOnPark)
            {
                GameManager.Instance.receivedMessage = true;
                receivedMessageOnPark = true;
            }
            triggerf.SetActive(false);
            triggerr.SetActive(false);
            Answer.SetActive(true);
            inti.SetActive(false);
        }
    }
}
