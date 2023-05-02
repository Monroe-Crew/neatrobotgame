using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject htpPanel;
    public GameObject mmPanel;
    void Start()
    {
        htpPanel.SetActive(false);
        mmPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
