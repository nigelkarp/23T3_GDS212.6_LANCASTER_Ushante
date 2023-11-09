using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float detectionRange = 5f;

    private Transform player;

    [SerializeField] private float _minX = -5f;
    [SerializeField] private float _maxX = 5f;
    [SerializeField] private float _minY = -5f;
    [SerializeField] private float _maxY = 5f;

    void Start()
    {
        // Assuming your player has a "Player" tag. Adjust accordingly.
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // credit gpt
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRange)
        {
            // Move towards the player
            Vector2 direction = (player.position - transform.position).normalized;
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
        else
        {
            // Move randomly or patrol if the player is not in range
            Patrol();
        }
    }

    void Patrol()
    {
        // Implement your own patrol logic here.
        // You can move the enemy randomly or along a predefined path.

        transform.Translate(new Vector2(Random.Range(_minX, _maxX), Random.Range(_minY, _maxY)) * moveSpeed * Time.deltaTime);
    }
}
