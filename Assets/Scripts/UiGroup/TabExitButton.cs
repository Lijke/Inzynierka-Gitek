using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabExitButton : MonoBehaviour{
  public GameObject tabGroup;

  public void OnClickExit(){
    tabGroup.SetActive(false);
  }
}
