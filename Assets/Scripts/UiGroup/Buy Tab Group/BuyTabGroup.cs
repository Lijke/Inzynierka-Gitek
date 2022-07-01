using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyTabGroup : MonoBehaviour{
    public List<BuyTabButton> buttons;
    public BuyTabButton selectedTab;
    public List<GameObject> objectsToSwap;
    
    public void Subscribe(BuyTabButton buyTabButton){
        ResetTabs();
    }
    public void OnTabEnter(BuyTabButton button) {
        ResetTabs();
    }
    public void OnTabExit(BuyTabButton button) {
        ResetTabs();
    }
    
    public void OnTabSelected(BuyTabButton button){
        selectedTab = button;
        ResetTabs();
        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < objectsToSwap.Count; i++){
            if (i == index){
                objectsToSwap[i].SetActive(true);
            }
            else{
                objectsToSwap[i].SetActive(false);
            }
        }
    }
    public void ResetTabs(){
        foreach (BuyTabButton button in buttons){
            if (selectedTab != null && button == selectedTab){
                continue;
            }
        }
    }
}
