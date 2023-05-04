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
    public GameObject upgradePanel;
    public GameObject upgradeButton;
    public GameObject completePanel;
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
                    completePanel.SetActive(false);
                    if (player.GetComponent<Stats>().gears < 200){
                        upgradeButton.GetComponent<Button>().interactable = false;
                    }
                    if (player.GetComponent<Stats>().resourceMultiplier > 1){
                        completePanel.SetActive(true);
                        upgradeButton.GetComponent<Button>().interactable = false;
                    }
                }
            }
        }
    }
}
