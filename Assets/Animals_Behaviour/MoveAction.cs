using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class MoveAction : ActionBase{
    public NavMeshAgent navMeshAgent;
    public float walkRadius;
    public Vector3 finalPosition;
    private bool active;
    public float counter;
    
    public override void StarAction(Action onCompleted){
        if (active){
            return;
        }
        active = true;
        counter = 0;
        this.onCompleted = onCompleted;
        Decision();
    }

    public override void Decision(){
        Vector3 randomDirection = Random.insideUnitSphere * walkRadius;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomDirection, out hit, walkRadius, 1);
        finalPosition = hit.position;
        if (finalPosition.x == Mathf.Infinity){
            Decision();
            return;
        }

        counter++;
        Debug.DrawLine(transform.position, finalPosition, new Color(0.83f, 0.64f, 0.4f), 300f);
        navMeshAgent.SetDestination(finalPosition);
        animator.SetBool("Walk", true);
    }

    private void Update(){
        if (!active){
            return;
        }
        if (Vector3.Distance(transform.position, finalPosition) < 0.6f){
            OnActionComplete();
        }
    }

    public override void OnActionComplete(){
        if (counter == 2){
            FinishAction();
            return;
        }
        Decision();
    }

    public override void FinishAction(){
        active = false;
        animator.SetBool("Walk", false);
        counter = 0;
        var copy = onCompleted;
        onCompleted = null;
        copy?.Invoke();
    }
}