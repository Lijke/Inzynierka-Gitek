using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitAction : ActionBase{
    public float actionTime;
    private bool active;
    public override void StarAction(Action onCompleted){
        this.onCompleted = onCompleted;
        actionTime = 10f;
        active = true;

        Decision();
    }

    public override void Decision(){
        animator.SetBool("Sit", true);
        
    }

    private void Update(){
        if (!active){
            return;
        }
        
        actionTime -= Time.deltaTime;
        if (actionTime <= 0){
            OnActionComplete();
        }
    }

    public override void OnActionComplete(){
        active = false;
        animator.SetBool("Sit", false);
        FinishAction();
    }

    public override void FinishAction(){

        onCompleted?.Invoke();
    }
}
