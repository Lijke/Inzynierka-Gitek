using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ShopPanelDetails : MonoBehaviour{
    [Header("Ui")] 
    [SerializeField] private TextMeshProUGUI itemName;
    [SerializeField] private TextMeshProUGUI currentLevel;
    [SerializeField] private TextMeshProUGUI currentPrice;
    [SerializeField] private TextMeshProUGUI currentDuration;
    [SerializeField] private TextMeshProUGUI desription;
    [SerializeField] private TextMeshProUGUI goldText;
    [Header("Managers/ Containers")] 
    public GoldContainer goldContainer;
    [Header("Item")]
    [SerializeField] private ItemSO item;

    [FormerlySerializedAs("upgradeUis")] [Header("Upgrade1")]
    public UpgradeDurationUi durationUpgradeUi;
    public List<TextMeshProUGUI> upgradeText;

    private void Awake(){
        GameEvents.onAddGold += UpdateUi;
        GameEvents.onLevelUp += UpdateLevelUi;
        GameEvents.onDurationLevelUp += DurationLevelUi;
    }

    private void UpdateUi(){
        goldText.text = goldContainer.GetCurrentGold().ToString();
    }

    private void OnDestroy(){
        GameEvents.onAddGold -= UpdateUi;
        GameEvents.onLevelUp -= UpdateLevelUi;
        GameEvents.onDurationLevelUp -= DurationLevelUi;
    }

    private void DurationLevelUi(ItemSO itemSo){
        currentDuration.text = itemSo.currentDuration.ToString();
    }

    private void UpdateLevelUi(ItemSO itemSo){
        if (itemSo == item){
            currentLevel.text = itemSo.currentLevel.ToString();
        }
    }

    public void SetupView(ItemSO item){
        this.item = item;
        itemName.text = item.itemName;
        currentLevel.text = "Level " + item.currentLevel.ToString();
        currentPrice.text = item.currentPrice.ToString();
        currentDuration.text = item.currentDuration.ToString();
        desription.text = item.description;
        durationUpgradeUi.Init(item, goldContainer, this.item.baseCost);
        durationUpgradeUi.SetUpgrade();
        
    }
}
