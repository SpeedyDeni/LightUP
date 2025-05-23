using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    public int sec1 = 30;
    public int sec2 = 120;

    public int interval;

    float timer = 0;

    private void Start()
    {
        interval = Random.Range(sec1, sec2);
    }

    public Animator anim;
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > interval)
        {
            anim.Play("Flicker");
            interval = Random.Range(sec1, sec2);
            timer = 0;
        }
    }
}
