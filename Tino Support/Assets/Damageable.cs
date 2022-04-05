using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int maxHealth;
    private int _currentHealth;

    public Collider EnemyCollider;
    public Collider ShieldCollider;

    public void Start()
    {
        _currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        print($"{gameObject.name} is Taking damage");
        
        _currentHealth -= damageAmount;

        if (_currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
