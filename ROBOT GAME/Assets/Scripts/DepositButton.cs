using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepositButton : MonoBehaviour{

    private int quartz;
    public GameObject player;
    public GameObject button;
    void Start(){
        
    }

    void Update(){
        if(button.GetComponent<Button>().interactable = false && player.GetComponent<Stats>().quartz > 0){
            button.GetComponent<Button>().interactable = true;
        }
        if(button.GetComponent<Button>().interactable = true && player.GetComponent<Stats>().quartz == 0){
            button.GetComponent<Button>().interactable = false;
        }
    }

    public void Deposit(){
        quartz += player.GetComponent<Stats>().quartz;
        player.GetComponent<Stats>().RemoveQuartz(player.GetComponent<Stats>().quartz);
    }
}
