using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class Pickup_BaseState : MonoBehaviour
{
    public abstract void OnEquip(Player_OmniController player, InputAction.CallbackContext context);

    public abstract void OnUse(Player_OmniController player, InputAction.CallbackContext context);

    public abstract void OnSecondaryUse(Player_OmniController player, InputAction.CallbackContext context);

    public abstract void OnUpdate(Player_OmniController player);

    public abstract void OnUnequip(Player_OmniController player);

    public abstract void OnTurnEnd(Player_OmniController player);
}
