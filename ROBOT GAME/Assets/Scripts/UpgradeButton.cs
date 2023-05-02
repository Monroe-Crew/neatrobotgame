using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeButton : MonoBehaviour{
    private bool visible;
    public GameObject button;
    public GameObject upgradePanel;
    void Start()
    {
        visible = false;
        //Make button greyed out and not clickable
    }

    void Update(){
        if (!visible){
            //Check to see if player has enough gears
                //If so, make button clickable and not greyed out
        }
    }

    public void Upgrade(){
        //remove gears from player
        //double the resource mulitplier
        upgradePanel.SetActive(false);
        //make image of upgrade dissapear
        //Update HUD layout? (If extra time)
    }
}
