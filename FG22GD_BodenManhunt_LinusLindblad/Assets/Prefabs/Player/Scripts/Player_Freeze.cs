using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Freeze : Player_ActionBaseState
{
    public GameObject water;
    public int FreezeLevel = 0;
    public bool IsInSafeZone = false;

    public override void UpdateState(Player_OmniController player)
    {
        Debug.Log(FreezeLevel);
    }

    public void OnStartTurn(Player_OmniController player)
    {
        if(IsInSafeZone == false)
        {
            FreezeLevel += 1;
        }

        if(FreezeLevel >= 4)
        {
            player.PHealth.TakeDamage(20, player);
            Debug.Log(player.PHealth.health); 
        }
    }


    public override void OnCall(Player_OmniController player, InputAction.CallbackContext context)
    {

    }

    public override void OnCollisionEnter(Player_OmniController player, Collider other)
    {

    }

    public override void OnReset(Player_OmniController player)
    {

    }
}
