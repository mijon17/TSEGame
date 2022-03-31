using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// this script is attached to the player character
/// upon using the 'slay' option at the cage.
/// </summary>
public class drainBuff : MonoBehaviour
{
    public PlayerController playerController;
    public PlayerCombat combat;
    public PlayerHealth health;

    public cageData cage;

    //reference points for when the buff is destroyed and values need reverting
    public int defaultDamage;
    public float defaultAttackRate;
    public float defaultHealth;
    public int defaultMaxHealth;
    public float defaultMovement;

    private void Start()
    {
        float defaultDamage = combat.attackDamage;
        float defaultAttackRate = combat.attackRate;
        float defaultHealth = health.currentHealth;
        float defaultMaxHealth = health.maxHealth;
        float defaultMovement = playerController.MovementSpeed;
    }

    public void buff(){
        //alter the values as you please
        playerController.MovementSpeed = playerController.MovementSpeed * cage.speedBuff;
        combat.attackDamage = combat.attackDamage * cage.damageBuff;
        combat.attackRate = combat.attackRate * cage.attackRateBuff;
        health.maxHealth = cage.healthBuff;
        health.currentHealth = health.maxHealth;
        //alter healthbar
    }

    public void destroyBuff(){
    //reverts the values of the buff
        playerController.MovementSpeed = defaultMovement;
        combat.attackDamage = defaultDamage;
        combat.attackRate = defaultAttackRate;
        if(health.maxHealth > defaultHealth){
            health.maxHealth = defaultMaxHealth;
            health.currentHealth = health.maxHealth;
        }
        health.maxHealth = defaultMaxHealth;
        health.healthBar.SetHealth(health.currentHealth);
        Destroy(this);
        //alter healthBar;

        
        
    }
}
