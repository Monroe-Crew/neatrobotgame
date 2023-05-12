using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour { 
    public string sceneName;

    void Start(){
        
    }

    public void ButtonClicked(){
        SceneManager.LoadScene(sceneName);
    }
}
