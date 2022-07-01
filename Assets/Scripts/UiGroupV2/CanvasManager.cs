using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour{
  public List<GameObject> canvases;
  public List<ItemSO> itemSo;
  public void ChangeVisibleCanvas(int id){
    foreach (var canvas in canvases){
      canvas.SetActive(false);
    }
    canvases[id].SetActive(true);
    canvases[id].GetComponent<ShopPanelDetails>().SetupView(itemSo[0]);
  }
}
