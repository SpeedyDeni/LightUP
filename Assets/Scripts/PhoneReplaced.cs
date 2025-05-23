using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class PhoneReplaced : MonoBehaviour
{
    public List <GameObject> problems;
    public List <GameObject> stupids;

    public bool areProblemsOn;
    public int problemsOff;
    void Update()
    {
        for (int i = 0; i < problems.Count; i++)
        {
            if (problems[i].activeInHierarchy)
            {
                areProblemsOn = true;
            }
            else
            {
                problemsOff++;
            }
        }
        if(problemsOff == problems.Count)
        {
            areProblemsOn = false;
            problemsOff = 0;
        }
        else
        {
            problemsOff = 0;
        }
        if (areProblemsOn || GameManager.Instance.phoneisactive)
        {
            for(int i=0;i < stupids.Count; i++)
            {
                stupids[i].SetActive(false);
            }
        }
        else if(!areProblemsOn && !GameManager.Instance.phoneisactive)
        {
            for (int i = 0; i < stupids.Count; i++)
            {
                stupids[i].SetActive(true);
            }
        }
    }
}
