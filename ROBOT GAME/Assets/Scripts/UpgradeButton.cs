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
    void Start()
    {
    }

    void Update()
    {
    }

    public void Upgrade()
    {
        player.GetComponent<Stats>().RemoveGears(200);
        player.GetComponent<Stats>().SetMulitplier(2);
        completePanel.SetActive(true);
        button.GetComponent<Button>().interactable = false;
        //Make complete checkmark visible
    }
}
