using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BehaviourControllerBase : BehaviourBase{
    public ActionSubState.SubStates subStates;
    
    public abstract void Decision();
    public abstract void RunChildState();
}
