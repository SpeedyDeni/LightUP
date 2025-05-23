using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    public List <GameObject> notifs;
    public List<GameObject> notifgroups;
    public int messagesdisplayed = 0;
    public GameObject bakery1;
    public GameObject bakery2;
    public GameObject park;
    public GameObject shop;

    public GameObject NotifGroup1;
    public GameObject NotifGroup2;
    public GameObject NotifGroup3;
    public GameObject NotifGroup4;
    public GameObject NotifGroup5;
    public GameObject NotifGroup6;

    public bool ok = true;
    
    public float amount;
    public int multiplier = 0;

    void Update()
    {
        if (GameManager.Instance.receivedMessage)
        {
            if (ok == true)
            {
                bakery1 = notifs[3];
                bakery2 = notifs[4];
                park = notifs[2];
                shop = notifs[5];
                NotifGroup1 = notifgroups[0];
                NotifGroup2 = notifgroups[1];
                NotifGroup3 = notifgroups[2];
                NotifGroup4 = notifgroups[3];
                NotifGroup5 = notifgroups[4];
                NotifGroup6 = notifgroups[5];
                ok = false;
            }
           
            if (GameManager.Instance.InPark && GameManager.Instance.BeenToPark ==0)
            {
                notifs[GameManager.Instance.messages] = park;
                notifgroups[GameManager.Instance.messages]=NotifGroup3;
                notifgroups[GameManager.Instance.messages].SetActive(true);
                GameManager.Instance.BeenToPark = 1;
            }
            else if (GameManager.Instance.InBakery1 && GameManager.Instance.BeenToBakery1==0)
            {
                notifs[GameManager.Instance.messages] = bakery1;
                notifgroups[GameManager.Instance.messages]=NotifGroup4;
                notifgroups[GameManager.Instance.messages].SetActive(true);
                GameManager.Instance.BeenToBakery1 = 1;
            }
            else if (GameManager.Instance.InBakery2 && GameManager.Instance.BeenToBakery2==0)
            {
                notifs[GameManager.Instance.messages] = bakery2;
                notifgroups[GameManager.Instance.messages] = NotifGroup5;
                notifgroups[GameManager.Instance.messages].SetActive(true);
                GameManager.Instance.BeenToBakery2 = 1;
            }
            else if (GameManager.Instance.InShop && GameManager.Instance.BeenToShop==0)
            {
                notifs[GameManager.Instance.messages] = shop;
                notifgroups[GameManager.Instance.messages] = NotifGroup6;
                notifgroups[GameManager.Instance.messages].SetActive(true);
                GameManager.Instance.BeenToShop = 1;
            }
            else
            {
                notifgroups[GameManager.Instance.messages].SetActive(true);
            }
            if (GameManager.Instance.messages < 4)
            {
                for(int i=0; i<GameManager.Instance.messages; i++)
                {
                    notifs[i].transform.position = new Vector3(notifs[i].transform.position.x, notifs[i].transform.position.y + amount, notifs[i].transform.position.z);
                }
            }
            if(GameManager.Instance.messages > 3) {
                messagesdisplayed = 0;
                multiplier = 0;
                for(int i=GameManager.Instance.messages-1; i>=0;  i--)
                {
                    if (messagesdisplayed == 0){
                        notifs[GameManager.Instance.messages-1].transform.position = new Vector3(-0.5f, 2, 0);
                        messagesdisplayed++;
                    }
                    if (messagesdisplayed <= 4)
                    {
                        Vector3 pos;
                        pos = new Vector3(-0.46f, 2+(amount*multiplier) -0.12f, 0);
                        pos.y += amount;
                        notifs[i].transform.position = pos;
                        messagesdisplayed++;
                        multiplier++;
                    }
                    
                    if (messagesdisplayed > 4)
                    {
                        notifgroups[i].SetActive(false);
                        messagesdisplayed++;
                    }
                }
            }
        }     
    }
}
