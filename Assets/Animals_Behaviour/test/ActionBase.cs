using System;
using UnityEngine;

[Serializable]
public abstract class ActionBase : MonoBehaviour{
    public Animator animator;
    public Action onCompleted;
    public abstract void StarAction(Action onCompleted);
    public abstract void Decision();
    public abstract void OnActionComplete();
    public abstract void FinishAction();

}