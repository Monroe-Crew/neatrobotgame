using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour{
    public int gears;
    public int resourceMultiplier;
    public int quartz;
    void Start(){
    }

    void Update(){
        
    }

    public void SetMulitplier(int num){
        resourceMultiplier *= num;
    }

    public void AddGears(int num){
        gears += num;
    }

    public void RemoveGears(int num){
        gears -= num;
    }

    public void AddQuartz(int num){
        quartz += num;
    }

    public void RemoveQuartz(int num){
        quartz -= num;
    }

}
