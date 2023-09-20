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

            Console.WriteLine("Shot by a bow");
            Console.WriteLine();
            HealthTaken(10);

            ShowHud();

            Console.WriteLine("Killed Bowman");
            Console.WriteLine("Drank His Health Potion");
            Console.WriteLine();
            HealthGained(10);
            AddScore(10, 1);

            ShowHud();

            Console.WriteLine("Bowmans 3 Friends Kill You");
            Console.WriteLine();
            LoseLife(1);

            ShowHud();

            Console.WriteLine("Kill Bowmans 3 Friends After Reviving");
            Console.WriteLine();
            AddScore(10, 3);

            ShowHud();
            
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
            Console.WriteLine(" HP: " + health + " | Score: " + score + " | Lives: " + lives);
            Console.WriteLine();
        }

    }
}
