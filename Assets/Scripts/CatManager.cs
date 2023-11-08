using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatManager : MonoBehaviour
{
    [SerializeField] private int _catHearts = 3;        // cat health
    [SerializeField] private bool _isFollowing = true;  // bool to follow player
    [SerializeField] private GameObject _player;        // reference to PlayerObject

    //Settings for following player
    [SerializeField] private float _followSpeed;
    public Transform followPlayer;
    [SerializeField] private float _stoppingDistance = 0.10f;

    private void Update()
    {
        if (_isFollowing)
        {
            FollowPlayer();
        }
    }

    // Function to make the cat follow the player
    private void FollowPlayer()
    {
        //     Calculate the cat's movement towards the player
        //     Update cat position to follow the player
        if (followPlayer != null)
        {
            float distance = Vector2.Distance(transform.position, followPlayer.transform.position);

            if (distance > _stoppingDistance)
            {
                transform.position = Vector2.Lerp(transform.position, followPlayer.position, _followSpeed * Time.deltaTime);
            }
        }
    }

    // Function to toggle following behavior on/off (this can only be called when the player is near by)
    // function toggleFollowing() :
    public void ToggleFollowing()
    {
        _isFollowing = !_isFollowing;
    }

    // Function to reduce cat hearts
    private void ReduceHearts()
    {
        //_catHearts -= damage;
    }

    // Function to check if the cat is in range of an enemy
    //function isInRange(enemy) :
    //     Implement logic to check if cat is in enemy's attack range
}
