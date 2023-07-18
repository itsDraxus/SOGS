using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth = 8;
    public float missingHealth;

    public Material healthbarMaterial;

    private void Start()
    {
        health = maxHealth;
        healthbarMaterial.SetFloat("_RemovedSegments", 0);
    }

    public void Damage(float damagePoints)
    {
        if (health > 0)
        {
            health -= damagePoints;
            missingHealth += damagePoints;
            healthbarMaterial.SetFloat("_RemovedSegments", missingHealth);
        }
    }

    public void Heal(float healingPoints)
    {
        if (health < maxHealth)
        {
            health += healingPoints;
            missingHealth -= healingPoints;
            healthbarMaterial.SetFloat("_RemovedSegments", missingHealth);
        }
    }
}
