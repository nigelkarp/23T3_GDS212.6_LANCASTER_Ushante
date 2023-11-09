using UnityEngine;

// Reminder to credit chat gpt

public class Enemy : MonoBehaviour
{
    public float speed = 2.0f; // Adjust as needed
    public int enemyHearts = 3; // Adjust as needed
    public float attackRange = 1.5f; // Adjust as needed

    [SerializeField] private Transform _playerTransform;

    private bool _isAttacking = false;

    void Update()
    {
        if (_playerTransform != null)
        {
            // Check if the player is in attack range and the enemy is not currently attacking
            if (IsPlayerInRange() && !_isAttacking)
            {
                // Calculate the direction to move towards the player
                Vector3 direction = CalculateDirectionToPlayer();

                // Move towards the player
                MoveTowardsPlayer(direction);

                // If the enemy is close to the player, initiate an attack
                if (IsCloseToPlayer())
                {
                    AttackPlayer();
                }
            }
            else
            {
                _isAttacking = false;
            }
        }
    }

    Vector3 CalculateDirectionToPlayer()
    {
        Vector3 playerPosition = _playerTransform.position;
        Vector3 enemyPosition = transform.position;
        Vector3 direction = (playerPosition - enemyPosition).normalized;
        return direction;
    }

    void MoveTowardsPlayer(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    bool IsPlayerInRange()
    {
        // up date this so it uses a range given by a collider, to go to the player

        Vector3 playerPosition = _playerTransform.position;
        Vector3 enemyPosition = transform.position;
        float distanceToPlayer = Vector3.Distance(playerPosition, enemyPosition);
        return distanceToPlayer <= attackRange;
    }

    bool IsCloseToPlayer()
    {
        Vector3 playerPosition = _playerTransform.position;
        Vector3 enemyPosition = transform.position;
        float distanceToPlayer = Vector3.Distance(playerPosition, enemyPosition);
        return distanceToPlayer <= attackRange;
    }

    void AttackPlayer()
    {
        _isAttacking = true;
        // Implement enemy's attack behavior, e.g., inflict damage on the player
    }

    public void Initialize(Transform playerTransform, float attackRange)
    {
        _playerTransform = playerTransform;
        this.attackRange = attackRange;
    }

}
