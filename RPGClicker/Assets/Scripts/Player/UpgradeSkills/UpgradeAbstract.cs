using System;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

namespace Player.UpgradeSkills
{
    public class UpgradeAbstract : MonoBehaviour
    {
        [SerializeField] protected int UpCost;
        [SerializeField] protected Button upgradeButton;
        [SerializeField] protected StatsUI _statsUI;
        protected PlayerData _playerData;
        protected ControlPlayerMoney _playerMoney;

        protected void Start()
        {
            _playerData = PlayerData.GetPlayerData();
            _playerMoney = FindObjectOfType<ControlPlayerMoney>();
            if (_statsUI == null) _statsUI = FindObjectOfType<StatsUI>();
        }

        private void Update()
        {
            if (_playerMoney.currentMoney < UpCost)
            {
                upgradeButton.interactable = false;
            }
            else
            {
                upgradeButton.interactable = true;
            }
        }
    }
}