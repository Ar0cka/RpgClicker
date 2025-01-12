using System;
using UnityEngine;

namespace Player.UpgradeSkills
{
    public class UpgradePlayerAttack : UpgradeAbstract
    {
        [SerializeField] private int countUpgradeAttack = 2;
        
        public void UpgradeAttack()
        {
            if (_playerData != null)
            {
                _playerData.UpgradeDamage(countUpgradeAttack);
                _playerMoney.WithdrawMoney(UpCost);
            }
            else
            {
                _playerData = PlayerData.GetPlayerData();
                Debug.LogError("Повторная инициализация информации игрока");
            }
            _statsUI.UpdateUI();
        }
    }
} 