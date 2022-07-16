using System;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "ItemSO")]
public class ItemSO : ScriptableObject{
    public float currentPrice;
    public float currentDuration;
    public float currentBonus;
    public float currentLevel;
    public float nextBonusLevel;
    public string itemName;
    [TextArea(5, 20)] 
    public string description;

    public float baseCost;
    

    public UpgradeDurationSO upgradeDurationSO;

    public bool maxLevelReached;


    public void LevelUp(){
        currentLevel += 1;
        UpdateVariables();
        GameEvents.LevelUp(this);
        GameEvents.AddGold();
    }
    [Button()]
    public void UpdateVariables(){
        currentPrice = baseCost * currentLevel;
    }

    public void SetCurrentDuration(){
        currentDuration = upgradeDurationSO.GetCurrentDurationTimer();
    }
    public void MaxLevelReached(){
        GameEvents.LevelUp(this);
        maxLevelReached = true;
    }
}


