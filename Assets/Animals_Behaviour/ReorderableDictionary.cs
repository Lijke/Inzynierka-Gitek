using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public abstract class ReorderableDictionary<TKey, TValue> : SerializableDictionary<TKey, TValue> {

    public ReorderableDictionary() : base() {
    }

}