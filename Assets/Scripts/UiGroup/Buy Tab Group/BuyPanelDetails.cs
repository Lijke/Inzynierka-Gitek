
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

public class BuyPanelDetails : MonoBehaviour{
   public Image backGroundImage;
   public Image iconImage;

   public TextMeshProUGUI itemName_TMP;
   public TextMeshProUGUI price_TMP;
   public TextMeshProUGUI duration_TMP;
   public TextMeshProUGUI bonus_TMP;
   public TextMeshProUGUI currentLevel_TMP;
   public TextMeshProUGUI nextLevelBonus_TMP;

   public List<ItemSO> avalibleItems;
   public ItemSO currentItem;

   public async UniTask LoadContent(int index){
      currentItem = avalibleItems[index];
      iconImage.sprite = await Addressables.LoadAssetAsync<Sprite>($"{currentItem.itemName}");
      backGroundImage.sprite = await Addressables.LoadAssetAsync<Sprite>($"{currentItem.itemName}");
      itemName_TMP.text = currentItem.itemName;
      price_TMP.text = currentItem.currentPrice.ToString();
      duration_TMP.text = currentItem.currentDuration.ToString();
      bonus_TMP.text = currentItem.currentBonus.ToString();
      currentLevel_TMP.text = currentItem.currentLevel.ToString();
      nextLevelBonus_TMP.text = currentItem.nextBonusLevel.ToString();
   }
}
