using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatManager : MonoBehaviour
{
    [SerializeField] private int _catHearts = 3;        //catHearts = 3
    [SerializeField] private bool _isFollowing = true;  //isFollowing = true
    [SerializeField] private GameObject _player;        //player = reference to PlayerObject

    private void Update()
    {
        if (_isFollowing)
        {
            FollowPlayer();
        }
    }

    // Function to make the cat follow the player
    //function followPlayer():
    private void FollowPlayer()
    {
        //     Calculate the cat's movement towards the player
        //     Update cat position to follow the player
        gameObject.transform.position = _player.transform.position;
    }

    //     Function to toggle following behavior on/off
    //function toggleFollowing() :
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
