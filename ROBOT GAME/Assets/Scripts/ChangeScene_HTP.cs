using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene_HTP : MonoBehaviour
{
    public string game;
    public AudioSource buttonClick;

    void Start(){
    }

    public void StartButton(){
        buttonClick.Play();
        SceneManager.LoadScene(game);
    }
}
