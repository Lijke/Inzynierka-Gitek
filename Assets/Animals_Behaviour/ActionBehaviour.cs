using UnityEngine;

public abstract class ActionBehaviour<Tkey, UValue> : MonoBehaviour {

    [System.Serializable]
    public class SubStates : ReorderableDictionary<int, UValue> { }
}