using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Jump : Player_ActionBaseState
{
    public override void OnCall(Player_OmniController player, InputAction.CallbackContext context)
    {
        Transform _pT = player.transform;
        RaycastHit hit;
        Physics.Raycast(_pT.position, _pT.up * -1, out hit, 2f);

        if(hit.collider != null)
        {
            if (hit.collider.tag == "Ground")
            {
                player.rb.AddForce(new Vector3(0f, 2.5f, 0f), ForceMode.Impulse);
            }
        }
    }

    public override void UpdateState(Player_OmniController player)
    {

    }

    public override void OnCollisionEnter(Player_OmniController player, Collider other)
    {

    }

    public override void OnReset(Player_OmniController player)
    {

    }
}
