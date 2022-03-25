using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drainBuff : MonoBehaviour
{
    public PlayerController playerController;
    public PlayerCombat combat;
    public PlayerHealth health;

    public cageData cage;

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
        playerController.MovementSpeed = playerController.MovementSpeed * cage.speedBuff;
        combat.attackDamage = combat.attackDamage * cage.damageBuff;
        combat.attackRate = combat.attackRate * cage.attackRateBuff;
        health.maxHealth = cage.healthBuff;
        health.currentHealth = health.maxHealth;
        //alter healthbar
    }

    public void destroyBuff(){
        playerController.MovementSpeed = defaultMovement;
        combat.attackDamage = defaultDamage;
        combat.attackRate = defaultAttackRate;
        if(health.maxHealth > defaultHealth){
            health.maxHealth = defaultMaxHealth;
            health.currentHealth = health.maxHealth;
        }
        health.maxHealth = defaultMaxHealth;
        //alter healthBar;
        
        
    }
}
