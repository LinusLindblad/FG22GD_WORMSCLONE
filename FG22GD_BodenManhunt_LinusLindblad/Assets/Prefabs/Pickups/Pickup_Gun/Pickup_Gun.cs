using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pickup_Gun : Pickup_BaseState
{
    public GameObject Projectile;
    public GameObject MuzzleFlash;
    public GameObject BulletImpact;
    public Transform LaunchPoint;
    public Transform Rifle;
    public Transform DefaultPosition;
    public Transform AimPosition;

    private bool _isAiming = false;
    private bool _shotThisTurn = false;

    private void Start()
    {
        MuzzleFlash.SetActive(false);
    }

    public override void OnEquip(Player_OmniController player, InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            this.gameObject.SetActive(true);
            this.GetComponent<Collider>().enabled = false;
            this.transform.parent = player.PickupHolder.transform;
            this.transform.localPosition = Vector3.zero;
            this.transform.localRotation = Quaternion.Euler(Vector3.zero);
        }
    }

    public override void OnUse(Player_OmniController player, InputAction.CallbackContext context)
    {
        if (context.performed && _shotThisTurn == false)
        {
            RaycastHit hit;
            Physics.Raycast(LaunchPoint.position, LaunchPoint.forward, out hit);

            if(hit.collider != null)
            {
                Instantiate(BulletImpact, hit.point, LaunchPoint.rotation);

                if(hit.collider.GetComponent<Player_OmniController>() != null)
                {
                    hit.collider.GetComponent<Player_OmniController>().PHealth.TakeDamage(33f, hit.collider.GetComponent<Player_OmniController>());
                }
            }

            Rifle.localPosition = new Vector3(Rifle.localPosition.x, Rifle.localPosition.y, _isAiming == true ? Rifle.localPosition.z - 0.25f : Rifle.localPosition.z - 0.5f);
            MuzzleFlash.SetActive(true);
            StartCoroutine(TurnOffMuzzleFlash());

            _shotThisTurn = true;
        }
    }

    public override void OnSecondaryUse(Player_OmniController player, InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            if(_isAiming == true)
            {
                _isAiming = false;
            }
            else
            {
                _isAiming = true;
            }
        }
    }

    public override void OnUpdate(Player_OmniController player)
    {
        if(_isAiming == true)
        {
            //Rifle.position = AimPosition.position;
            Rifle.position = Vector3.Lerp(Rifle.position, AimPosition.position, 8f * Time.deltaTime);
        }
        else
        {
            //Rifle.position = DefaultPosition.position;
            Rifle.position = Vector3.Lerp(Rifle.position, DefaultPosition.position, 8f * Time.deltaTime);
        }
    }

    public override void OnUnequip(Player_OmniController player)
    {
        this.gameObject.SetActive(false);
    }

    public override void OnTurnEnd(Player_OmniController player)
    {
        _shotThisTurn = false;
    }

    private IEnumerator TurnOffMuzzleFlash()
    {
        yield return new WaitForSeconds(0.1f);
        MuzzleFlash.SetActive(false);
    }
}
