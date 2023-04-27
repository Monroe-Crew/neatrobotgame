using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene_MainMenu : MonoBehaviour
{
    public string game;
    public AudioSource buttonClick;

    void Start()
    {
    }

    public void BackButton(){
        buttonClick.Play();
        SceneManager.LoadScene(game);
    }
}