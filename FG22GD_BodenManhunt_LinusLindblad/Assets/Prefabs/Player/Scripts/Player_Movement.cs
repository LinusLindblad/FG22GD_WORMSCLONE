using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class Player_Movement : Player_ActionBaseState
{
    private Vector3 _finalVelocity;
    private Vector2 _input;
    public override void OnCall(Player_OmniController player, InputAction.CallbackContext context)
    {
        _input = context.ReadValue<Vector2>();
    }

    public override void UpdateState(Player_OmniController player)
    {
        _finalVelocity = player.transform.right * _input.x + player.transform.forward * _input.y;

        player.rb.MovePosition(player.transform.position + (_finalVelocity * player.Speed * Time.fixedDeltaTime));
    }

    public override void OnCollisionEnter(Player_OmniController player, Collider other)
    {

    }

    public override void OnReset(Player_OmniController player)
    {
        _input = Vector2.zero;
        _finalVelocity = Vector3.zero;
    }
}
