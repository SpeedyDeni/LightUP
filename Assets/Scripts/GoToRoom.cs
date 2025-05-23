using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToRoom : MonoBehaviour
{
    public string nextScenePlay;
    void OnMouseDown()
    {
        SceneManager.LoadScene(nextScenePlay);
    }
}
