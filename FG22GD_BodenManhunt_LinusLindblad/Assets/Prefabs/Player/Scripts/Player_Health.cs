using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Health
{
    public float health = 99f;
    public float MaxHealth = 99f;

    public void Heal(float healing, Player_OmniController player)
    {
        health += healing;
        health = health >= MaxHealth ? MaxHealth : health;
    }

    public void TakeDamage(float damage, Player_OmniController player)
    {
        health -= damage;

        if(health < 0)
        {
            Die(player);
        }
    }

    private void Die(Player_OmniController player)
    {
        player.TurnController.RemoveFromTurnOrder(player);
    }
}