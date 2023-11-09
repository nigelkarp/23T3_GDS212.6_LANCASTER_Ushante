using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float detectionRange = 5f;

    // Reference to box collider 2D of insidebounds
    [SerializeField] private GameObject insideBounds;

    [SerializeField] EnemyCollision enemyCollision;

    private Transform player;

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
        //transform.Translate(new Vector2(Random.Range(_minX, _maxX), Random.Range(_minY, _maxY)) * moveSpeed * Time.deltaTime);
        BoxCollider2D insideBoundsBoxCollider = insideBounds.GetComponent<BoxCollider2D>();

        if (enemyCollision.enemyInBounds())
        {
            // Define the bounds first
            Vector2 minBounds = (Vector2)insideBoundsBoxCollider.bounds.min;
            Vector2 maxBounds = (Vector2)insideBoundsBoxCollider.bounds.max;

            // Make enemy patrol around this box
            transform.Translate(new Vector2(Random.Range(insideBoundsBoxCollider.size.x, insideBoundsBoxCollider.size.y)) * moveSpeed * Time.deltaTime);
        }
    
    }
}
