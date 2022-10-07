using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class River_Freeze : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player_OmniController>() != null)
        {
            other.GetComponent<Player_OmniController>().PFreeze.FreezeLevel += 2;
        }
    }
}
