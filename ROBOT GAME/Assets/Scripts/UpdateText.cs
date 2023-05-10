using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateText : MonoBehaviour
{
    public GameObject player;
    public GameObject quartzText;
    public GameObject gearText;
    public int quartz;
    public int gears;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if (quartz != player.GetComponent<Stats>().quartz){
            quartz = player.GetComponent<Stats>().quartz;
            string newText = "- " + quartz;
            quartzText.GetComponent<TextMeshProUGUI>().text = newText;
        }
        if (gears != player.GetComponent<Stats>().gears){
            gears = player.GetComponent<Stats>().gears;
            string newText = gears + " -";
            gearText.GetComponent<TextMeshProUGUI>().text = newText;
            if (gears >= 100){
                int posX = 525;
                int posY = 220;
                gearText.transform.position = new Vector2(posX, posY);
            }
            else if(gears >= 10){
                int posX = 540;
                int posY = 220;
                gearText.transform.position = new Vector2(posX, posY);
            }
        }
    }
}
