using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeItemSo")]
public class UpgradeItemSO : ScriptableObject{
    public int currentLevel;
    public int baseCost;
    public int currentDuration;
    public AnimationCurve durationCurve;
    
}
