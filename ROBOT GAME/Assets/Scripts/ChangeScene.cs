using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public string game;
    public AudioSource buttonClick;
    public AudioSource startAudio;

    // Start is called before the first frame update
    void Start()
    {
        startAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void StartButton()
    {
        buttonClick.Play();
        startAudio.Stop();
        SceneManager.LoadScene(game);
    }
}
