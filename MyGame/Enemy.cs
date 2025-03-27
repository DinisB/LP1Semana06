using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        private static int powerupsCollected;

        static Enemy() {
            powerupsCollected = 0;
        }

        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void SetName(string setname) {
            name = setname.Substring(0, Math.Min(8, setname.Length));
        }

        public void PickupPowerUp(PowerUp powerup, float n)
        {
            if (powerup == PowerUp.Health)
            {
                health = Math.Min(100, health + n);
            }
            else if (powerup == PowerUp.Shield)
            {
                shield = Math.Min(100, shield + n);
            }
            powerupsCollected++;
        }

        public static int GetPowerUpsCollected() {
            return powerupsCollected;
        }
    }
}
