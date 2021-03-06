﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script goes on player
public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private Slider healthBar;

    public int maxHealth = 100;

    private Animator anim;

    [HideInInspector]
    public  int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        anim = GetComponent<Animator>();

        UpdateHealthBar();
    }

    void Update()
    {
        UpdateHealthBar();
    }

    public void DamagePlayer(int amount)
    {
        /* Damages player by enemy attack amount */
        currentHealth -= amount;

        /* Player dies when health reaches 0 */
        if (currentHealth <= 0)
        {
            //anim.SetTrigger("Die");
            GetComponent<PlayerRespawnScript>().RespawnPlayer();
        }
    }

    public void HealPlayer(int amount)
    {
        /* Heals player by pickup amount */
        currentHealth += amount;

        /* Caps player health at 100% */
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    void UpdateHealthBar()
    {
        /* Updates health bar with current health */
        healthBar.value = currentHealth;
    }
}
