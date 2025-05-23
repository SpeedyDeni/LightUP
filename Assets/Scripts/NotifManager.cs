using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotifManager : MonoBehaviour
{
    //GameObjects
    public GameObject objectMsg1;
    public GameObject objectMsg2;
    public GameObject objectMsg3;
    public GameObject objectMsg4;

    //Message Components
    public SpriteRenderer msg1;
    public SpriteRenderer msg2;
    public SpriteRenderer msg3;
    public SpriteRenderer msg4;
    
    public SpriteRenderer FMsg1;
    public SpriteRenderer FMsg2;
    public SpriteRenderer FMsg3;
    public SpriteRenderer FMsg4;

    public SpriteRenderer con1;
    public SpriteRenderer con2;
    public SpriteRenderer con3;
    public SpriteRenderer con4;

    public SpriteRenderer FCon1;
    public SpriteRenderer FCon2;
    public SpriteRenderer FCon3;
    public SpriteRenderer FCon4;

    //Message Sprites
    public Sprite spriteMsg1;
    public Sprite spriteMsg2;
    public Sprite spriteMsg3;
    public Sprite spriteMsg4;
    public Sprite spriteMsg5;
    public Sprite spriteMsg6;
    
    public Sprite spriteFMsg1;
    public Sprite spriteFMsg2;
    public Sprite spriteFMsg3;
    public Sprite spriteFMsg4;
    public Sprite spriteFMsg5;
    public Sprite spriteFMsg6;

    public Sprite spriteCon1;
    public Sprite spriteCon2;
    public Sprite spriteCon3;
    public Sprite spriteCon4;
    public Sprite spriteCon5;
    public Sprite spriteCon6; 
    
    public Sprite spriteFCon1;
    public Sprite spriteFCon2;
    public Sprite spriteFCon3;
    public Sprite spriteFCon4;
    public Sprite spriteFCon5;
    public Sprite spriteFCon6;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddSprites(int number)
    {
        if(number == 1)
        {
            objectMsg1.SetActive(true);
            msg1.sprite = spriteMsg1;
            con1.sprite = spriteCon1;
            FMsg1.sprite = spriteFMsg1;
            FCon1.sprite = spriteFCon1;
        }
        if(number == 2)
        {
            objectMsg2.SetActive(true);
            msg2.sprite = msg1.sprite;
            con2.sprite = con1.sprite;
            FMsg2.sprite = FMsg1.sprite;
            FCon2.sprite = FCon1.sprite;

            msg1.sprite = spriteMsg2;
            con1.sprite = spriteCon2;
            FMsg1.sprite = spriteFMsg2;
            FCon1.sprite = spriteFCon2;
        }
        if(number == 3)
        {
            objectMsg3.SetActive(true);
            msg3.sprite = msg2.sprite;
            con3.sprite = con2.sprite;
            FMsg3.sprite = FMsg2.sprite;
            FCon3.sprite = FCon2.sprite;

            msg2.sprite = msg1.sprite;
            con2.sprite = con1.sprite;
            FMsg2.sprite = FMsg1.sprite;
            FCon2.sprite = FCon1.sprite;

            msg1.sprite = spriteMsg3;
            con1.sprite = spriteCon3;
            FMsg1.sprite = spriteFMsg3;
            FCon1.sprite = spriteFCon3;
        }
        if(number == 4)
        {
            objectMsg4.SetActive(true);
            msg4.sprite = msg3.sprite;
            con4.sprite = con3.sprite;
            FMsg4.sprite = FMsg3.sprite;
            FCon4.sprite = FCon3.sprite;

            msg3.sprite = msg2.sprite;
            con3.sprite = con2.sprite;
            FMsg3.sprite = FMsg2.sprite;
            FCon3.sprite = FCon2.sprite;

            msg2.sprite = msg1.sprite;
            con2.sprite = con1.sprite;
            FMsg2.sprite = FMsg1.sprite;
            FCon2.sprite = FCon1.sprite;

            msg1.sprite = spriteMsg4;
            con1.sprite = spriteCon4;
            FMsg1.sprite = spriteFMsg4;
            FCon1.sprite = spriteFCon4;
        }
        if(number == 5)
        {
            msg4.sprite = msg3.sprite;
            con4.sprite = con3.sprite;
            FMsg4.sprite = FMsg3.sprite;
            FCon4.sprite = FCon3.sprite;

            msg3.sprite = msg2.sprite;
            con3.sprite = con2.sprite;
            FMsg3.sprite = FMsg2.sprite;
            FCon3.sprite = FCon2.sprite;

            msg2.sprite = msg1.sprite;
            con2.sprite = con1.sprite;
            FMsg2.sprite = FMsg1.sprite;
            FCon2.sprite = FCon1.sprite;

            msg1.sprite = spriteMsg5;
            con1.sprite = spriteCon5;
            FMsg1.sprite = spriteFMsg5;
            FCon1.sprite = spriteFCon5;
        }
        if (number == 6) 
        {
            msg4.sprite = msg3.sprite;
            con4.sprite = con3.sprite;
            FMsg4.sprite = FMsg3.sprite;
            FCon4.sprite = FCon3.sprite;

            msg3.sprite = msg2.sprite;
            con3.sprite = con2.sprite;
            FMsg3.sprite = FMsg2.sprite;
            FCon3.sprite = FCon2.sprite;

            msg2.sprite = msg1.sprite;
            con2.sprite = con1.sprite;
            FMsg2.sprite = FMsg1.sprite;
            FCon2.sprite = FCon1.sprite;

            msg1.sprite = spriteMsg6;
            con1.sprite = spriteCon6;
            FMsg1.sprite = spriteFMsg6;
            FCon1.sprite = spriteFCon6;
        }
    }
    
}
