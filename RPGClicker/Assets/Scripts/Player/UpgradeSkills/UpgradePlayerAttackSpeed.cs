using UnityEngine;

namespace Player.UpgradeSkills
{
    public class UpgradePlayerAttackSpeed : UpgradeAbstract
    {
        [SerializeField] private float attackSpeedCount;

        public void UpAttackSpeed()
        {
            if (_playerData != null)
            {
                _playerData.UpgradeAttackSpeed(attackSpeedCount);
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