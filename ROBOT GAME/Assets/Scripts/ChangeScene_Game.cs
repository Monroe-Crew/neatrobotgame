using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene_Game : MonoBehaviour
{

    public string game;
    public AudioSource buttonClick;
    public AudioSource startAudio;

    void Start()
    {
        startAudio.Play();
    }

    public void StartButton()
    {
        buttonClick.Play();
        startAudio.Stop();
        SceneManager.LoadScene(game);
    }
}
