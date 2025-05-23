using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    public VidPlayer controller;
    public VideoPlayer player;

    public string nextScenePlay;
    bool played;
    void Update()
    {
        if (player.isPlaying == false && controller.played && !played)
        {
            played = true;
            SceneManager.LoadScene(nextScenePlay);
        }
    }
}
