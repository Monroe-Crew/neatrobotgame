using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spaceship : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject spaceshiphud;
    public GameObject ship;
    public GameObject player;
    public GameObject upgradeButton;
    public GameObject completeUpgradePanel;
    public GameObject depositButton;
    public GameObject completeDepositPanel;
    Camera m_Camera;
    void Start(){
        m_Camera = Camera.main;
        spaceshiphud.SetActive(false);
}

    void Update(){
        if (Input.GetMouseButtonDown(0)){
            Vector3 mousePosition = Input.mousePosition;
            Ray ray = m_Camera.ScreenPointToRay(mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit)){
                if(GameObject.ReferenceEquals(hit.transform.gameObject, ship)){
                    spaceshiphud.SetActive(true);
                    completeUpgradePanel.SetActive(false);
                    completeDepositPanel.SetActive(false);
                    if (player.GetComponent<Stats>().gears < 200){
                        upgradeButton.GetComponent<Button>().interactable = false;
                    }
                    if(player.GetComponent<Stats>().quartz == 0){
                        depositButton.GetComponent<Button>().interactable = false;
                    }
                    if (player.GetComponent<Stats>().resourceMultiplier > 1){
                        completeUpgradePanel.SetActive(true);
                        upgradeButton.GetComponent<Button>().interactable = false;
                    }
                    if (player.GetComponent<Stats>().completeDeposit == true){
                        completeDepositPanel.SetActive(true);
                        depositButton.GetComponent<Button>().interactable = false;
                    }
                }
            }
        }
    }
}
