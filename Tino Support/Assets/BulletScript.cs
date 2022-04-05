using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    private void Start()
    {
        rb.velocity = transform.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        print($"Hitting {col.gameObject.name}");
        
        if (col.gameObject.CompareTag("Enemy"))
        {
            col.gameObject.GetComponent<Damageable>().TakeDamage(10);
            print($"Sending Damage to {col.gameObject.name}");
        }
        
        Destroy(gameObject);
    }
}
