using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TurnBasedInput : MonoBehaviour
{
    private Player_OmniController _currentPlayer;
    private bool _inputEnabled;
    private MultiTargetCamera _camControl;
    public bool InputEnabled { get { return _inputEnabled; } set { _inputEnabled = value; } }

    private void Start()
    {
        _camControl = FindObjectOfType<MultiTargetCamera>();
    }

    //By sending input commands only to the currently active player, situations where multiple players read a single input are avoided.
    public void ChangeTarget(Player_OmniController player)
    {
        _currentPlayer = player;
    }

    //Functions below are used to contact the relevant player controller.
    public void OnJump(InputAction.CallbackContext context)
    {
        if (_camControl.TransitionComplete == true)
        {
            _currentPlayer.PJump.OnCall(_currentPlayer, context);
        }
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        if (_camControl.TransitionComplete == true)
        {
            _currentPlayer.PLook.OnCall(_currentPlayer, context);
        }
            
    }

    public void OnInventory(InputAction.CallbackContext context)
    {
        if (_camControl.TransitionComplete == true)
        {
            _currentPlayer.PInventory.OnCall(_currentPlayer, context);
        }
    }

    public void OnUse(InputAction.CallbackContext context)
    {
        if (_camControl.TransitionComplete == true)
        {
            _currentPlayer.PInventory.OnUsePickup(_currentPlayer, context);
        }
    }

    public void OnSecondaryUse(InputAction.CallbackContext context)
    {
        if(_camControl.TransitionComplete == true)
        {
            _currentPlayer.PInventory.OnUsePickupSecondary(_currentPlayer, context);
        }
    }

    public void OnTetriaryUse(InputAction.CallbackContext context)
    {
        if (_camControl.TransitionComplete == true)
        {
            //_currentPlayer.PInventory.OnUsePickupSecondary(_currentPlayer, context);
        }
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        if (_camControl.TransitionComplete == true)
        {
            _currentPlayer.PMove.OnCall(_currentPlayer, context);
        }
    }

    public void OnAim(InputAction.CallbackContext context)
    {
        if (_camControl.TransitionComplete == true)
        {
            _currentPlayer.PAim.OnCall(_currentPlayer, context);
        }
    }

    public void OnPassTurn(InputAction.CallbackContext context)
    {

    }
}
