using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("You have to write one argument!");
                return;
            }
            int.TryParse(args[0], out int nInimigos);
            Enemy[] inimigos = new Enemy[nInimigos];

            for (int i = 0; i < nInimigos; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string nome = Console.ReadLine();
                inimigos[i] = new Enemy(nome);
            }

            for (int i = 0; i < nInimigos; i++)
            {
                Console.Write($"{inimigos[i].GetName()} {inimigos[i].GetHealth()} {inimigos[i].GetShield()}");
                Console.WriteLine();
            }
            foreach (Enemy inimigo in inimigos)
            {
                inimigo.PickupPowerUp(PowerUp.Shield, Random.Shared.Next(10, 50));
                Console.WriteLine($"PowerUp Shield: {inimigo.GetName()} {inimigo.GetHealth()} {inimigo.GetShield()}");

                inimigo.TakeDamage(Random.Shared.Next(10, 100));
                Console.WriteLine($"TakeDamage: {inimigo.GetName()} {inimigo.GetHealth()} {inimigo.GetShield()}");

                inimigo.PickupPowerUp(PowerUp.Health, Random.Shared.Next(10, 50));
                Console.WriteLine($"PowerUp Health: {inimigo.GetName()} {inimigo.GetHealth()} {inimigo.GetShield()}\n");
            }

            Console.WriteLine($"\nTotal de PowerUps: {Enemy.GetPowerUpsCollected()}");
        }
    }
}
