using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using MonsterClick;
using MonsterClick.UpgradeMonstersAfterDie;
using Player;
using SpawmMonster;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class HitMonster : MonoBehaviour, ITakeDamage
{
    [SerializeField] private MonsterSettings monsterSettings;
    [SerializeField] private ControlMonsterHitPointUI monsterUI;
    [SerializeField] private UpgradeMonster upgradeMonster;
    private ControlPlayerMoney playerMoney;
    
    public int CurrentHitPoint { get; private set;}

    private float cooldownAttack;

    private void Update()
    {
        if (cooldownAttack <= 0)
        {
            IdleHitEnemy();
        }
        else
        {
            cooldownAttack -= Time.deltaTime;
        }
    }

    private void Awake()
    {
        if (monsterUI == null)
        {
            monsterUI = GetComponent<ControlMonsterHitPointUI>();
        }

        playerMoney = FindObjectOfType<ControlPlayerMoney>();
        
        CurrentHitPoint = monsterSettings.HitPoint;
        UpdateUI();
    }

    public void TakeDamage()
    {
        var playerData = PlayerData.GetPlayerData();

        if (playerData != null)
        {
            CurrentHitPoint -= playerData.Damage;
            UpdateUI();

            if (CurrentHitPoint <= 0)
            {
                MonsterDead();
            }
        }
        else
        {
            Debug.LogError("Player data instance dont realize");
        }
    }

    private void IdleHitEnemy()
    {
        var playerData = PlayerData.GetPlayerData();

        if (playerData != null)
        {
            CurrentHitPoint -= playerData.IdleDamage;

            if (CurrentHitPoint <= 0)
            {
                MonsterDead();
            }
            
            cooldownAttack = playerData.IdleAttackSpeed;
            UpdateUI();
        }
    }

    private void MonsterDead()
    {
        playerMoney.AddMoney(monsterSettings.MoneyFromMonster);
        upgradeMonster.UpdateMonsterXP();
        Destroy(gameObject);
        SpawnMonster.MonsterDead();
    }

    private void UpdateUI()
    {
        monsterUI.ControlMonsterBar(CurrentHitPoint, monsterSettings.HitPoint);
    }
}
