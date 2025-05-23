using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public int messages = 0;
    public bool receivedMessage;

    public GameObject phone;
    public bool phoneisactive;
    public bool InPark = false;
    public bool InBakery1 = false;
    public bool InBakery2 = false;
    public bool InShop = false;
    public bool complete = false;

    public int BeenToPark =0;
    public int BeenToBakery1=0;
    public int BeenToBakery2=0;
    public int BeenToShop=0;
    public bool litUp;

    void Start()
    {
        
    }

    void Update()
    {
        if (receivedMessage)
        {
            litUp = true;
            messages++;
            receivedMessage = false;
            InBakery1 = false;
            InBakery2 = false;
            InPark = false;
            InShop = false;
        }
        if(BeenToPark>0 && BeenToBakery1>0 && BeenToBakery2>0 && BeenToShop > 0)
        {
            complete = true;
        }
    }
}
