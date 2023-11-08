using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private GameObject _cat;       // reference cat object
    [SerializeField] private EnemyManager _enemy;   // reference enemy object

    private int _playerHearts = 5; // set player health

    [SerializeField] private Rigidbody2D _body;

    private float _horizontal;
    private float _vertical;
    private float _moveLimiter = 0.7f;

    public float runSpeed = 20.0f;
    private void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Handle player input movement (wasd)
        // If (input (w)) movefoward()
        //if (input(A)) moveLeft()
        //if (input(S)) moveBackward()
        //if (input(D)) moveRight()

        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");

        // Handle interaction with the cat
        //if (input(E)):
        //    interactWithCat()

        // Handle taking damage from enemies
        //if (enemy.isInRange() and enemy.isAttacking()):
        //    playerHearts -= enemy.getDamage()

        // Check for player health reaching zero
        //if (playerHearts <= 0):
        //    gameOver()
    }
    
    void FixedUpdate()
    {
        if (_horizontal != 0 && _vertical != 0) // CHecking for diagonal movement
        {
            // Limit movement speed diagonally, so you move at 70% speed
            _horizontal *= _moveLimiter; 
            _vertical *= _moveLimiter;
        }
        _body.velocity = new Vector2(_horizontal * runSpeed, _vertical * runSpeed);
    }

    //// Interact with the cat
    //function interactWithCat():
    //cat.toggleFollowing()

    //// Handle game over conditions
    //function gameOver() :
    //    // Implement game over logic
    //    // Display game over screen

}
