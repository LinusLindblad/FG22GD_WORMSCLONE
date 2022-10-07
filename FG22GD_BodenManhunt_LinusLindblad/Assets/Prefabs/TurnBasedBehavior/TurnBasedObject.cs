using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TurnBasedObject : MonoBehaviour
{
    //This is the base class for all gameobjects that follow the turnorder. This includes players,
    //and can be used to create any kind of turn dependent object.

    public abstract Transform ObjectCamera();
    public abstract bool AffectedByTimer();
    public abstract void StartTurn();
    public abstract void EndTurn();
}
