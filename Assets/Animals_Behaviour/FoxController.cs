using System;
using System.Collections;
using System.Collections.Generic;
using Malee.List;
using NaughtyAttributes;
using UnityEngine;
using ZeroVector.Common.Reorderable;
using Random = UnityEngine.Random;


public class FoxController : AnimalController{
    public BehaviourSubStates.SubStates subStates;
    public Action onCompleted;
    private void Awake(){
        onCompleted += OnActionComplete;
        Decision();
    }

    public override void Decision(){
        RunAction();
    }

    public override void RunAction(){
        int nextAction = Random.Range(0, subStates.Count);
        Debug.Log(nextAction + "CONTROLLER");
        subStates[nextAction].StartState(onCompleted);
    }

    public override void OnActionComplete(){
        Decision();
    }
}
public enum BehaviourType{
    Idle =0,
    Walk = 1,
    Eat = 2,
    Drink = 3
}