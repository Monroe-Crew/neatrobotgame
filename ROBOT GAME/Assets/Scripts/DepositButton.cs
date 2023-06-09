using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DepositButton : MonoBehaviour{

    public int quartz;
    public GameObject player;
    public GameObject button;
    public GameObject quartzDeposited;
    public GameObject completeDepositPanel;
    public GameObject launchButton;
    public AudioSource buttonClickSound;
    void Start(){
        quartz = 0;
    }

    void Update(){
     
    }

    public void OnButtonPressed(){
        buttonClickSound.Play();
        quartz += player.GetComponent<Stats>().quartz;
        if (quartz > 1500){
            int diff = quartz - 1500;
            player.GetComponent<Stats>().RemoveQuartz(diff);
            quartz = 1500;
        }
        else{
            player.GetComponent<Stats>().RemoveQuartz(player.GetComponent<Stats>().quartz);
        }
        string newText = quartz + "/1500  Quartz";
        quartzDeposited.GetComponent<TextMeshProUGUI>().text = newText;
        button.GetComponent<Button>().interactable = false;
        if (quartz == 1500){
            completeDepositPanel.SetActive(true);
            launchButton.SetActive(true);
        }
    }
}
