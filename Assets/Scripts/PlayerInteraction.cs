using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    // Function to interact with the enemy (call this from your player's movement script)
    public void InteractWithEnemy(Transform enemyTransform)
    {
        // Stop the enemy from being pushed around
        Rigidbody2D enemyRb = enemyTransform.GetComponent<Rigidbody2D>();
        if (enemyRb != null)
        {
            enemyRb.velocity = Vector2.zero;
        }
    }
}

