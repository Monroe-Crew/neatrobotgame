using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public GameObject button;
    public GameObject upgradePanel;
    public GameObject player;
    public GameObject completePanel;
    public AudioSource upgradeSound;
    void Start()
    {
    }

    void Update()
    {
    }

    public void Upgrade(){
        upgradeSound.Play();
        player.GetComponent<Stats>().RemoveGears(200);
        player.GetComponent<Stats>().SetMulitplier(2);
        completePanel.SetActive(true);
        button.GetComponent<Button>().interactable = false;
        //Make complete checkmark visible
    }
}
