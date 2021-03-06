using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    private bool _isTouchingPlayer;
    public GameObject player;

    private void FixedUpdate()
    {
        if (_isTouchingPlayer)
            return;
        
        Vector2 playerPos  = (Vector2)player.transform.position - rb.position;
        rb.rotation = Mathf.Atan2(playerPos .y, playerPos .x) * Mathf.Rad2Deg - 90f;
        rb.velocity = transform.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
            _isTouchingPlayer = true;
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
            _isTouchingPlayer = false;
    }
}
