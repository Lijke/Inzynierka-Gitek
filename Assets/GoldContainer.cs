using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GoldContainerSo")]
public class GoldContainer : ScriptableObject{
    private float currentGold;
    public static GoldContainer Instance;

    private void Awake(){
        Instance = this;
    }

    public void AddGold(float gold){
        currentGold += gold;
    }
}
