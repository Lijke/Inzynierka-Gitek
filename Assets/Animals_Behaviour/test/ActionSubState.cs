using System;
using UnityEngine;
using ZeroVector.Common.Reorderable;

public class ActionSubState : MonoBehaviour{
    [Reorderable(paginate = true, pageSize = 0, elementNameProperty = "Value")]
    public SubStates dict;

    [Serializable]
    public class SubStates : ReorderableDictionary<float, ActionBase, SubStates.KeyValuePair> {
        public override float DeduplicateKey(float duplicateKey) {
            return duplicateKey + 0.1f;
        }
            
        // ReSharper disable once RedundantNameQualifier
        [Serializable]
        public new class KeyValuePair : ReorderableDictionary<float,ActionBase, KeyValuePair>.KeyValuePair { }
    }

}