using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene_HTP : MonoBehaviour
{
    public GameObject htpPanel;
    public GameObject mmPanel;
    public AudioSource buttonClick;

    void Start()
    {
    }

    public void StartButton()
    {
        buttonClick.Play();
        mmPanel.SetActive(false);
        htpPanel.SetActive(true);
    }
}
