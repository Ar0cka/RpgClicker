using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Monster", menuName = "ScriptableObject/Monster")]
public class MonsterSettings : ScriptableObject
{
    [SerializeField] private int hitPoint;
    [SerializeField] private int countUpdateHpMonsters;

    [SerializeField] private float moneyForKill;
    [SerializeField] private float updateMoneyCount;

    public int HitPoint => hitPoint;
    public float MoneyFromMonster => moneyForKill;

    public void UpdateMonsterAfterDead()
    {
        hitPoint += countUpdateHpMonsters;
        moneyForKill += updateMoneyCount;
    }
}