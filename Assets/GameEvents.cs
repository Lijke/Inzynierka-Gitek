using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour{
    public delegate void OnAddGold();
    public static event OnAddGold onAddGold;
    public static  void AddGold() {
        if (onAddGold != null) {
            onAddGold?.Invoke();
        }
    }
    
    public delegate void OnLevelUp(ItemSO item);

    public static event OnLevelUp onLevelUp;

    public static void LevelUp(ItemSO item){
        onLevelUp?.Invoke(item);
    }
    
    public delegate void OnDurationLevelUP(ItemSO item);

    public static event OnDurationLevelUP onDurationLevelUp;

    public static void DurationLevelUp(ItemSO item){
        onDurationLevelUp?.Invoke(item);
    }
}
