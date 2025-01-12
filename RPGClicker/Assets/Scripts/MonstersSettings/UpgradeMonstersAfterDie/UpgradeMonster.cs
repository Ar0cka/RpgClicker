using UnityEngine;

namespace MonsterClick.UpgradeMonstersAfterDie
{
    public class UpgradeMonster : MonoBehaviour
    {
        [SerializeField] private MonsterSettings monsterSettings;
        [SerializeField] private int CountUpdateHitPointAfterDie = 10;
        
        public void UpdateMonsterXP()
        {
            monsterSettings.UpdateMonsterAfterDead();
        }
    }
}