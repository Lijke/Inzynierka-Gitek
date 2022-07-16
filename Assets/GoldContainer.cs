using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GoldContainerSo")]
public class GoldContainer : ScriptableObject{
    public float currentGold;
    public static GoldContainer Instance;
    
    
    private void Awake(){
        Instance = this;
    }

    public void AddGold(float gold){
        currentGold += gold;
        GameEvents.AddGold();
        UiGoldManager.Instance.UpdateText(TypeOfGold.gold, currentGold.ToString());
    }

    public float GetCurrentGold(){
        return currentGold;
    }

    public void SubstractGold(float spentGold){
        currentGold -= spentGold;
        GameEvents.AddGold();
    }
}
