using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Player
{
    public class PlayerObject : MonoBehaviour
    {
        [SerializeField] private PlayerSettings playerSettings;
        private PlayerData _playerData;

        private void Awake()
        {
            if (_playerData == null) _playerData = PlayerData.InitializePlayerDataInstance(playerSettings);
            DontDestroyOnLoad(gameObject);
        }
    }
}