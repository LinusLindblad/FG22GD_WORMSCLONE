using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class Player_ActionBaseState
{
    public abstract void OnCall(Player_OmniController player, InputAction.CallbackContext context);

    public abstract void UpdateState(Player_OmniController player);

    public abstract void OnCollisionEnter(Player_OmniController player, Collider other);

    public abstract void OnReset(Player_OmniController player);
}
