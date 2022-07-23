using System;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using Malee.List;

public abstract class AnimalController: MonoBehaviour{
    
    public abstract void Decision();
    public abstract void RunAction();
    public abstract void OnActionComplete();
  

}
