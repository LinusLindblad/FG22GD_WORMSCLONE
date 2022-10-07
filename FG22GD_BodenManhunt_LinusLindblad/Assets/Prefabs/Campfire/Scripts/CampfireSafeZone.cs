using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CampfireSafeZone : MonoBehaviour
{
    
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Player_OmniController>() != null)
        {
            other.GetComponent<Player_OmniController>().PFreeze.IsInSafeZone = true;
            other.GetComponent<Player_OmniController>().PFreeze.FreezeLevel = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.GetComponent<Player_OmniController>() != null)
        {
            other.GetComponent<Player_OmniController>().PFreeze.IsInSafeZone = false;
            other.GetComponent<Player_OmniController>().PFreeze.FreezeLevel = 1;
        }
    }
}
