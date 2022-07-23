using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BehaviourController : BehaviourControllerBase{
    public Action onComplete;

    public override void StartState(Action onCompleted){
        this.onComplete = onCompleted;
        RunChildState();
    }

    private void OnActionComplete(){
        var copy = onComplete;
        onComplete = null;
        copy?.Invoke();
    }

    public override void Decision(){
        throw new System.NotImplementedException();
    }

    public override void RunChildState(){
        int nextAction = Random.Range(0, subStates.Count);
        Debug.Log(nextAction + "BEH");
        subStates[nextAction].StarAction(onComplete);
    }


    
}
