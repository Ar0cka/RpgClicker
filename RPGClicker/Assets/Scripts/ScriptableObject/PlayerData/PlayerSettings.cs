using UnityEngine;

[CreateAssetMenu(fileName = "basePlayer", menuName = "ScriptableObject/Player", order = 0)]
public class PlayerSettings : ScriptableObject
{
    [SerializeField] private int damage;
    [SerializeField] private int idleDamage;
    [SerializeField] private float idleAttackSpeed;

    public int DamagePlayer => damage;
    public int IdleDamagePlayer => idleDamage;

    public float IdleAttackSpeed => idleAttackSpeed;
}