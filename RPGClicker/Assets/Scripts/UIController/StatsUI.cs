using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class StatsUI : MonoBehaviour
{
    [SerializeField] private List<TextMeshProUGUI> statsUiList;
    [SerializeField] private List<string> startTextInUI;

    private PlayerData _playerData;

    private void Start()
    {
        _playerData = PlayerData.GetPlayerData();

        UpdateUI();
    }

    public void UpdateUI()
    {
        for (int i = 0; i < statsUiList.Count; i++)
        {
            switch (i)
            {
                case 0:
                    statsUiList[i].text = startTextInUI[i] + ": " + _playerData.Damage;
                    break;
                case 1:
                    statsUiList[i].text = startTextInUI[i] + ": " + _playerData.IdleDamage;
                    break;
                case 2:
                    statsUiList[i].text = startTextInUI[i] + ": " + _playerData.IdleAttackSpeed;
                    break;
            }
        }
    }
}
