using Malee.List;
using UnityEngine;
public class Behaviour: ActionBehaviour<int, int>{
    [Reorderable(paginate = true, pageSize = 30)]
    public SubStates m_subStates;
}


public enum ActionType{
    Walk =1,
    Eat =2,
    Sleep = 3
}

