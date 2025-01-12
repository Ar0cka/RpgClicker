using TMPro;
using UnityEngine;

namespace MonsterClick
{
    public class ControlMonsterHitPointUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI monsterHitPointBar;

        public void ControlMonsterBar(int currentHitPoint, int maxHitPoint)
        {
            monsterHitPointBar.text = $"{currentHitPoint}/{maxHitPoint}";
        }
    }
}