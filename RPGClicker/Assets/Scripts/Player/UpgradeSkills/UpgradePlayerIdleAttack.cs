using UnityEngine;

namespace Player.UpgradeSkills
{
    public class UpgradePlayerIdleAttack : UpgradeAbstract
    {
        [SerializeField] private int countUpgradeIdleAttack = 2;
        
        public void UpgradeIdleAttack()
        {
            if (_playerData != null)
            {
                _playerData.UpgradeIdleDamage(countUpgradeIdleAttack);
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