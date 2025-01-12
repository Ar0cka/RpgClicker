using System;
using Player.PlayerUI;
using TMPro;
using UnityEngine;
using Zenject;

namespace Player
{
    public class ControlPlayerMoney : MonoBehaviour
    {
        [SerializeField] private float startAmountMoney = 100f;
        [SerializeField] private ControlPlayerUI playerUI;
        public float currentMoney { get; private set;}

        private void Start()
        {
            currentMoney = startAmountMoney;
        }

        public void AddMoney(float countMoney)
        {
            currentMoney += countMoney;
            playerUI.UpdateMoneyUI();
        }

        public void WithdrawMoney(float countMoney)
        {
            if (currentMoney > countMoney)
            {
                currentMoney -= countMoney;
                playerUI.UpdateMoneyUI();
            }
            else
            {
                Debug.LogError("Нехватает денег"); // В будущем сюда надо будет добавить сообщения для вывода на экран
            }
        }
    }
}