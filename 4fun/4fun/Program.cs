using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4fun
{
    internal class Program
    {
        static int health;
        static string name;
        static string gamename;
        static int lives;
        static int score;
        static void Main(string[] args)
        {
            name = "dylan";
            gamename = "Cool Game";
            health = 100;
            lives = 3;
            score = 0;

            ShowHud();
            Console.ReadKey(true);

            Console.WriteLine("Shot by a bow");
            Console.WriteLine();
            Console.ReadKey(true);
            HealthTaken(10);
            Console.ReadKey(true);

            ShowHud();
            Console.ReadKey(true);

            Console.WriteLine("Killed Bowman");
            Console.ReadKey(true);
            Console.WriteLine("Drank His Health Potion");
            Console.WriteLine();
            Console.ReadKey(true);
            HealthGained(10);
            Console.ReadKey(true);
            AddScore(10, 1);
            Console.ReadKey(true);

            ShowHud();
            Console.ReadKey(true);

            Console.WriteLine("Bowmans 3 Friends Kill You");
            Console.WriteLine();
            Console.ReadKey(true);
            LoseLife(1);
            Console.ReadKey(true);

            ShowHud();
            Console.ReadKey(true);

            Console.WriteLine("Kill Bowmans 3 Friends After Reviving");
            Console.WriteLine();
            Console.ReadKey(true);
            AddScore(10, 3);
            Console.ReadKey(true);

            ShowHud();
            Console.ReadKey(true);

            Console.WriteLine("THE END");
            Console.ReadKey(true);
        }

        static void LoseLife(int kill)
        {
            lives = lives - kill;
            Console.WriteLine("Lose = " + kill + " Life");
        }

        static void GainLife(int rez)
        {
            lives = lives + rez;
            Console.WriteLine("Gain = " + rez + " Life");
        }

        static void HealthTaken(int damage)
        {
            health = health - damage;
            Console.WriteLine("Lose = " + damage + " Health" );
        }

        static void HealthGained(int heal)
        {
            health = health + heal;
            Console.WriteLine("Gain = " + heal + " Health");
        }

         static void AddScore(int pointsEarned, int scoreMulti)
        {
            score = score + pointsEarned * scoreMulti;
            Console.WriteLine("Gain = " + pointsEarned * scoreMulti + " Score");
        }

        static void ShowHud()
        {
            Console.WriteLine();
            Console.WriteLine(gamename + " | " + name);
            Console.WriteLine("==============================");
            Console.WriteLine("HP: " + health + " | Score: " + score + " | Lives: " + lives);
            Console.WriteLine();
        }

    }
}
