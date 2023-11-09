using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    private Transform playerTransform; // Reference to the player's transform

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the movement direction from the enemy to the player
        Vector2 directionToPlayer = playerTransform.position - transform.position;

        // Move the enemy in the opposite direction of the player's movement
        transform.Translate(-directionToPlayer.normalized * Time.deltaTime);
    }
}

