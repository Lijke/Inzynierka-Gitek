using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> buttons;
    public Sprite tabIdle;
    public Sprite tabHover;
    public Sprite tabSelected;
    public TabButton selectedTab;
    public List<GameObject> objectsToSwap;
    public GameObject pageArea;
    
    private void Start(){
        ResetTabs();
    }

    public void Subscribe(TabButton button) {
        if (button == null) {
            buttons = new List<TabButton>();
        }
        
        buttons.Add(button);
    }

    public void OnTabEnter(TabButton button) {
        ResetTabs();
        if (tabSelected == null && button != tabSelected){
            button.backGround.sprite = tabHover;    
        }
     
    }
    
    public void OnTabExit(TabButton button) {
        ResetTabs();
    }
    
    public void OnTabSelected(TabButton button){
        selectedTab = button;
        ResetTabs();
        button.backGround.sprite = tabSelected;
        int index = button.transform.GetSiblingIndex() - 1;
        for (int i = 0; i < objectsToSwap.Count; i++){
            if (i == index){
                objectsToSwap[i].SetActive(true);
                pageArea.SetActive(true);
            }
            else{
                objectsToSwap[i].SetActive(false);
            }
        }
    }
 
    public void ResetTabs(){
        foreach (TabButton button in buttons){
            if (selectedTab != null && button == selectedTab){
                continue;
            }
            
            button.backGround.sprite = tabIdle;
        }
    }
}
