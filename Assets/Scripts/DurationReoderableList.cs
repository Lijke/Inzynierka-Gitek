using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public struct DurationListReo{
    public int level;
    public int time;
    public float cost;
    public float expectedLevel;
    public DurationListReo(int level, int time, float cost, float expectedLevel){
        this.level = level;
        this.time = time;
        this.cost = cost;
        this.expectedLevel = expectedLevel;
    }
    
    public void SetGold(float cost){
        this.cost = cost;
    }
}