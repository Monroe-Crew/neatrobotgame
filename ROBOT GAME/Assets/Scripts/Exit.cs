using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour{

    public GameObject spaceshiphud;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    public void ButtonPressed() {
        spaceshiphud.SetActive(false);
    }
}
