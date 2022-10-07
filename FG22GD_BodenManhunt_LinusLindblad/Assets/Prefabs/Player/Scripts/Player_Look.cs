using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Look : Player_ActionBaseState
{
    private Vector3 _newBodyRot;
    private Vector3 _newCameraRot;
    private Vector2 _lookInput;
    private Vector2 _smoothedLookInput;
    private Vector2 _smoothingVelocity;
    private float _smoothingStr = 0.025f;

    public void OnStart(Player_OmniController player)
    {
        _newCameraRot = player.HeadCam.localRotation.eulerAngles;
    }

    public override void OnCall(Player_OmniController player, InputAction.CallbackContext context)
    {
        _lookInput = context.ReadValue<Vector2>();
    }

    public override void UpdateState(Player_OmniController player)
    {
        //Interpolates mouse input, as the inputsystem outputs an unsmoothed value
        _smoothedLookInput = Vector2.SmoothDamp(_smoothedLookInput, _lookInput, ref _smoothingVelocity, _smoothingStr);

        //Rotates the entire player on the Y axis to ensure movement is connected to rotation
        _newBodyRot.y += (_smoothedLookInput.x * player.LookSensitivityHorizontal * 0.001f) / Time.deltaTime;
        player.rb.MoveRotation(Quaternion.Euler(_newBodyRot));

        //Rotates player head on X axis, all view oriented components are attached to the head
        _newCameraRot.x += (player.LookSensitivityVertical * 0.001f) * _smoothedLookInput.y * -1f / Time.deltaTime;
        _newCameraRot.x = Mathf.Clamp(_newCameraRot.x, -90f, 70f);
        player.HeadCam.localRotation = Quaternion.Euler(_newCameraRot);
    }

    public override void OnCollisionEnter(Player_OmniController player, Collider other)
    {

    }

    public override void OnReset(Player_OmniController player)
    {
        //_newBodyRot = Vector3.zero;
        //_lookInput = Vector2.zero;
        //_smoothedLookInput = Vector2.zero;
    }
}
