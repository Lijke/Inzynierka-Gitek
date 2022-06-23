using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemSO")]
public class ItemSO : ScriptableObject{
    public float currentPrice;
    public float currentDuration;
    public float currentBonus;
    public float currentLevel;
    public float nextBonusLevel;
    public string itemName;
}