using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingUpgradeSO : MonoBehaviour{
   public ItemSO item;

   public float CalculateUpgradeLevel(){
      var baseCost = item.baseCost;
      var currentLevel = item.currentLevel;
      var multiplayer = 1 + currentLevel / 5000;
      return baseCost * currentLevel * 2 * multiplayer;
   }
}
