using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepositButton : MonoBehaviour{

    private int quartz;
    public GameObject player;
    public GameObject button;
    public GameObject quartzDeposited;
    void Start(){
        quartz = 0;
    }

    void Update(){
     
    }

    public void OnButtonPressed(){
        quartz += player.GetComponent<Stats>().quartz;
        player.GetComponent<Stats>().RemoveQuartz(player.GetComponent<Stats>().quartz);
        string newText = quartz + "//1500 /n Quartz";
        quartzDeposited.GetComponent<Text>().text = newText;
    }
}
