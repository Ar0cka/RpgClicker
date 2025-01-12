using System;
using TMPro;
using UnityEngine;

namespace Player.PlayerUI
{
    public class ControlPlayerUI : MonoBehaviour, IMoneyUI
    {
        [SerializeField] private TextMeshProUGUI playerMoneyUI;

        #region Scripts

        [SerializeField] private ControlPlayerMoney playerMoney;

        #endregion

        private void Awake()
        {
            if (playerMoney == null) playerMoney = GetComponent<ControlPlayerMoney>();
        }

        public void UpdateMoneyUI()
        {
            playerMoneyUI.text = $"Money = {playerMoney.currentMoney}";
        }
    }
}