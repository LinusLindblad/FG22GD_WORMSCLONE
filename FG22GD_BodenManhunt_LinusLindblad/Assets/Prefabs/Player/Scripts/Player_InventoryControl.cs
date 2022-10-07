using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_InventoryControl : Player_ActionBaseState
{
    private List<Pickup_BaseState> _pickups = new List<Pickup_BaseState>();
    private int _equippedPickupID = 1;
    private Pickup_BaseState _equippedPickup;
    private Pickup_EmptySlot _emptySlot;

    public void OnStart(Player_OmniController player)
    {
        _emptySlot = player.DefaultPickup.GetComponent<Pickup_EmptySlot>();
        _pickups.Add(_emptySlot);
        _equippedPickup = _emptySlot;
        Debug.Log(_equippedPickup);
    }

    public void OnUsePickup(Player_OmniController player, InputAction.CallbackContext context)
    {
        _equippedPickup.OnUse(player, context);
    }

    public void OnUsePickupSecondary(Player_OmniController player, InputAction.CallbackContext context)
    {
        _equippedPickup.OnSecondaryUse(player, context);
    }

    public override void OnCall(Player_OmniController player, InputAction.CallbackContext context)
    {
        if(context.performed && _pickups.Count > 1)
        {
            //Debug.Log("Trying to swap");
            if (_equippedPickup != null)
            {
                _equippedPickup.OnUnequip(player);
            }

            _equippedPickup = _pickups[_equippedPickupID].GetComponent<Pickup_BaseState>();
            _equippedPickup.OnEquip(player, context);

            _equippedPickupID++;

            if (_equippedPickupID >= _pickups.Count)
            {
                _equippedPickupID = 0;
            }
        }
    }

    public override void UpdateState(Player_OmniController player)
    {
        _equippedPickup.OnUpdate(player);
    }

    public override void OnCollisionEnter(Player_OmniController player, Collider other) 
    {

        if (other.GetComponent<Pickup_BaseState>() != null)
        {
            /*
            var newPickup = other.gameObject;
            newPickup.GetComponent<Collider>().enabled = false;
            newPickup.transform.parent = player.PickupHolder.transform;
            newPickup.transform.localPosition = Vector3.zero;
            newPickup.transform.localRotation = Quaternion.Euler(Vector3.zero);
            //newPickup.gameObject.SetActive(false);
            _pickups.Add(newPickup);
            */

            var newPickup = other.gameObject.GetComponent<Pickup_BaseState>();
            newPickup.GetComponent<Collider>().enabled = false;
            newPickup.transform.parent = player.PickupHolder.transform;
            newPickup.transform.localPosition = Vector3.zero;
            newPickup.transform.localRotation = Quaternion.Euler(Vector3.zero);
            newPickup.gameObject.SetActive(false);
            _pickups.Add(newPickup);
        }
    }

    public override void OnReset(Player_OmniController player)
    {
        _equippedPickup.OnTurnEnd(player);
    }
}
