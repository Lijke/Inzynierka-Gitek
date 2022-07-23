using System.Collections;
using System.Collections.Generic;
using Boxophobic.StyledGUI;
using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(fileName = "DurationSO")]
   public class DurationSO : ScriptableObject{
      public List<DurationListReo> durationListReos;
      public int currentDurationLevel;
      public int baseCost;
      public List<int> expectedLevel;
      [Button()]
      public void CalculateCost(){
         for (int i = 0; i < durationListReos.Count; i++){
            var item = new DurationListReo(){
               level = i,
               expectedLevel = expectedLevel[i],
               // 50 * 100 * ( 10 000 / 50 * 100)
               cost = baseCost* expectedLevel[i]* (10000f/baseCost*expectedLevel[i]),
               time = 30 - i*5
            };
            Debug.Log(expectedLevel[i]);
           durationListReos.Add(item);
            durationListReos.RemoveAt(0);
            
         }
      }
      
   }
