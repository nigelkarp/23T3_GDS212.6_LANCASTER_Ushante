using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] private bool _isEnemyInBounds; // bool representing that player is in bounds

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))   
        {  
            _isEnemyInBounds = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            _isEnemyInBounds = false;

            Debug.LogError("enemy out of bounds");
        }
    }

    // Return the bool
    public bool enemyInBounds()
    {
        return _isEnemyInBounds;
    }
}

