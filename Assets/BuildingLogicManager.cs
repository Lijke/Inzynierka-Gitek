using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class BuildingLogicManager : MonoBehaviour{
  public ItemSO item;

  private float currentDuration;
  private float currentGoldPerDuration;
  private void Start(){
    Init();
  }

  public void Init(){
    currentDuration = item.currentDuration;
    currentGoldPerDuration = item.currentPrice;
    GenerateGold();
  }

  public async UniTask GenerateGold(){
    await UniTask.Delay(TimeSpan.FromSeconds(currentDuration));
    GoldContainer.Instance.AddGold(currentGoldPerDuration);
  }
}
