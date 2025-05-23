using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageGoDown : MonoBehaviour
{
    public GameObject messanger;
    public Vector3 pos1;
    public Vector3 pos2;
    public Vector3 pos3;
    public Vector3 pos4;
    public GameObject notif1;
    public GameObject notif2;
    public GameObject notif3;
    public GameObject notif4;
    public GameObject notif5;
    public GameObject notif6;
    void Update()
    {
        if (GameManager.Instance.receivedMessage)
        {
            if(GameManager.Instance.messages==0)
            {
                GameObject message=Instantiate(notif1, messanger.transform);
                message.transform.position = pos1;
            }
            else if (GameManager.Instance.messages == 1)
            {
                GameObject message1 = Instantiate(notif2, messanger.transform);
                message1.transform.position = pos1;
                GameObject message2 = Instantiate(notif1, messanger.transform);
                message2.transform.position = pos2;
            }
            else if (GameManager.Instance.messages == 2)
            {
                GameObject message1 = Instantiate(notif3, messanger.transform);
                message1.transform.position = pos1;
                GameObject message2 = Instantiate(notif2, messanger.transform);
                message2.transform.position = pos2;
                GameObject message3 = Instantiate(notif1, messanger.transform);
                message3.transform.position = pos3;
            }
            else if (GameManager.Instance.messages == 3)
            {
                GameObject message1 = Instantiate(notif4, messanger.transform);
                message1.transform.position = pos1;
                GameObject message2 = Instantiate(notif3, messanger.transform);
                message2.transform.position = pos2;
                GameObject message3 = Instantiate(notif2, messanger.transform);
                message3.transform.position = pos3;
                GameObject message4 = Instantiate(notif1, messanger.transform);
                message4.transform.position = pos4;
            }
            else if (GameManager.Instance.messages == 4)
            {
                GameObject message1 = Instantiate(notif5, messanger.transform);
                message1.transform.position = pos1;
                GameObject message2 = Instantiate(notif4, messanger.transform);
                message2.transform.position = pos2;
                GameObject message3 = Instantiate(notif3, messanger.transform);
                message3.transform.position = pos3;
                GameObject message4 = Instantiate(notif2, messanger.transform);
                message4.transform.position = pos4;
            }
            else if (GameManager.Instance.messages == 5)
            {
                GameObject message1 = Instantiate(notif6, messanger.transform);
                message1.transform.position = pos1;
                GameObject message2 = Instantiate(notif5, messanger.transform);
                message2.transform.position = pos2;
                GameObject message3 = Instantiate(notif4, messanger.transform);
                message3.transform.position = pos3;
                GameObject message4 = Instantiate(notif3, messanger.transform);
                message4.transform.position = pos4;
            }
        }
    }
}
