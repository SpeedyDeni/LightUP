using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMsg : MonoBehaviour
{
    public int nrofmsg;
    void Start()
    {
        nrofmsg = GameManager.Instance.messages;
    }
    void Update()
    {
        if (nrofmsg!=GameManager.Instance.messages)
        {
            Destroy(gameObject);
        }
    }
}
