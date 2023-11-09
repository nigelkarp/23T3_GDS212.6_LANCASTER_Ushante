using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private int _enemyHealth = 2; //    enemy Health 
    
    [SerializeField] private bool _isAttacking = false; //isAttacking = false
    [SerializeField] private GameObject _player;        //player = reference to PlayerObject

    //// Update function for enemy AI
    //function Update() :
    private void Update()
    {
        //    if (player.isInRange() and !player.isGameOver()):
        //        isAttacking = true
        //        attackPlayer()
        //    else:
        //        isAttacking = false
    }


    //// Function to make the enemy attack the player
    //function attackPlayer():
    //    // Calculate enemy's attack behavior
    //    // Inflict damage on the player

    //    // Function to get the damage value for the enemy
    //function getDamage():
    //    return enemyHealth / 10

    //// Function to check if the enemy is in the player's attack range
    //function isInRange():
    //    // Implement logic to check if enemy is in player's attack range
}
