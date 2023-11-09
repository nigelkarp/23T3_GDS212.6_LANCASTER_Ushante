using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Transform playerTransform;

    [SerializeField] private GameObject _player;

    private void Start()
    {
        playerTransform = _player.transform;
    }
}
