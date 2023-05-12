using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public string sceneName;
    public AudioSource buttonClickSound;

    void Start()
    {
        
    }

    public void ButtonClicked(){
        buttonClickSound.Play();
        SceneManager.LoadScene(sceneName);
    }
}
