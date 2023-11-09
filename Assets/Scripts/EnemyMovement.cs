using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float detectionRange = 3f;

    private Transform currentMovePoint;
    private bool isMoving = false;
    
    [SerializeField] private GameObject insideBounds; // Reference to box collider 2D of insidebounds
    [SerializeField] EnemyCollision enemyCollision;

    private Transform player;

    [SerializeField] private Transform[] _movePoints; // Array of move point transforms

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
            // Choose a random transform point from the array
            Transform currentMovePoint = _movePoints[Random.Range(0, _movePoints.Length)];

            // move towards that transform
            transform.position = Vector2.MoveTowards(transform.position, currentMovePoint.position, moveSpeed * Time.deltaTime);
        }

    }
}
