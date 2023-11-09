using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] private bool _isPlayerNearEnemy = false; // bool representing that player is in bounds

    public CircleCollider2D enemyDetectionRangeCollider;

    // Collision2DEnter that will set this bool to true
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _isPlayerNearEnemy = true;
        }
    }
    // trigger2DExit that will set this bool to false
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _isPlayerNearEnemy = false;
        }
    }

    // Return the bool
    public bool isPlayerNearEnemy()
    {
        return _isPlayerNearEnemy;
    }
}

