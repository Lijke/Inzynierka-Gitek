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
    [SerializeField] private TextMeshProUGUI nextLevelUpgrade;
    [SerializeField] private TextMeshProUGUI currentPrice;
    [SerializeField] private TextMeshProUGUI currentDuration;
    [SerializeField] private TextMeshProUGUI desription;

    [Header("Item")]
    [SerializeField] private ItemSO item;

    [Header("Upgrade1")] public List<UpgradeUI> upgradeUis;
    public void SetupView(ItemSO item){
        this.item = item;
        itemName.text = item.itemName;
        currentLevel.text = item.currentLevel.ToString();
        nextLevelUpgrade.text = item.nextBonusLevel.ToString();
        currentPrice.text = item.currentPrice.ToString();
        currentDuration.text = item.currentDuration.ToString();
        desription.text = item.description;
        for (int i = 0; i < item.upgradeSo.Count; i++){
            upgradeUis[i].SetUpgrade(item, i);
        }
    }
}
