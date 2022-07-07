using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeUI : MonoBehaviour
{
   public TextMeshProUGUI header;
   public TextMeshProUGUI description; 
   public Image upgradeItem;
   public Button button;
   public void SetUpgrade(ItemSO item, int index){
      header.text = item.upgradeSo[index].upgradeHeader;
      description.text = item.upgradeSo[index].upgradeDescription;
      upgradeItem.sprite = item.upgradeSo[index].upgradeImage;
      button.onClick.AddListener(item.LevelUp);
   }
}
