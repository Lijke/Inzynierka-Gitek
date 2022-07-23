using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class BuildingLogicManager : MonoBehaviour{
  public ItemSO item;
  [SerializeField] private float currentDuration;
  private float currentGoldPerDuration;
  public GoldContainer goldContainer;

  private void Awake(){
    GameEvents.onDurationLevelUp += UpdateDurationTime;
  }

  private void OnDestroy(){
    GameEvents.onDurationLevelUp -= UpdateDurationTime;
  }

  private void UpdateDurationTime(ItemSO itemSo){
    currentDuration = item.currentDuration;
  }

  private void Start(){
    item.SetCurrentDuration();
    currentDuration = item.currentDuration;
    currentGoldPerDuration = item.currentPrice;
    GenerateGold();

  }
  public async UniTask GenerateGold(){
    while (true){
      await UniTask.Delay(TimeSpan.FromSeconds(currentDuration));
      if (goldContainer != null){
        currentGoldPerDuration = item.currentPrice;
        goldContainer.AddGold(currentGoldPerDuration);
#if UNITY_EDITOR
        Debug.Log(currentGoldPerDuration);
#endif
      }
      else{
#if UNITY_EDITOR
        Debug.LogError($"Gold container null in {GetType().Name}");
#endif
      }
      
    }
  }
}
