using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace SpawmMonster
{
    public class SpawnMonster : MonoBehaviour
    {
        [SerializeField] private List<GameObject> monsterPrefabs;
        [SerializeField] private Transform monsterPrefabParent;
        [SerializeField] private float spawnDelay = 2f;
        public static bool _monsterAlive { get; private set; }
        private bool _readySpawn;

        private void Start()
        {
            _monsterAlive = false;
            _readySpawn = true;
        }

        private void FixedUpdate()
        {
            if (!_monsterAlive && _readySpawn)
            {
                StartCoroutine(CreateLevelMonsters());
                _readySpawn = false;
            }
        }

        private IEnumerator CreateLevelMonsters()
        {
            yield return new WaitForSeconds(spawnDelay);
            
            var gameObject = Instantiate(monsterPrefabs[GetRandomCount()]);
            gameObject.transform.SetParent(monsterPrefabParent, false);
            
            ControlBool();
        }

        private void ControlBool()
        {
            _monsterAlive = true;
            _readySpawn = true;
        }

        private int GetRandomCount()
        {
            return Random.Range(0, monsterPrefabs.Count);
        }
        
        public static void MonsterDead()
        {
            _monsterAlive = false;
        }
    }
}