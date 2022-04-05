using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        print($"Object {gameObject.name} detected collision with {col.gameObject.name}");
    }
}
