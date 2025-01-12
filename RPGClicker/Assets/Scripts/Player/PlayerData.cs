namespace Player
{
    public class PlayerData
    {
        private static PlayerData playerInstance;
        public int Damage { get; private set; }
        public int IdleDamage { get; private set; }
        
        public float IdleAttackSpeed { get; private set; }

        public PlayerData(PlayerSettings playerSettings)
        {
            Damage = playerSettings.DamagePlayer;
            IdleDamage = playerSettings.IdleDamagePlayer;
            IdleAttackSpeed = playerSettings.IdleAttackSpeed;
        }

        public static PlayerData InitializePlayerDataInstance(PlayerSettings playerSettings)
        {
            if (playerInstance == null)
            {
                playerInstance = new PlayerData(playerSettings);
            }

            return playerInstance;
        }

        public static PlayerData GetPlayerData()
        {
            return playerInstance;
        }

        #region UpgradeDamagePlayer

        public void UpgradeDamage(int countUpgrade)
        {
            Damage += countUpgrade;
        }

        public void UpgradeIdleDamage(int countUpgrade)
        {
            IdleDamage += countUpgrade;
        }

        public void UpgradeAttackSpeed(float countUpgrade)
        {
            IdleAttackSpeed -= countUpgrade;
        }

        #endregion
       
    }
}