using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero, villain;
            string heroWeapon, villainWeapon;
            hero = RandomHero();
            heroWeapon = RandomWeapon();
            villain = RandomVillain();
            villainWeapon = RandomWeapon();

            Console.WriteLine($"{hero} will fight {villain} with a {heroWeapon}, while {villain} fights back with a {villainWeapon}.");
            

        }

        private static int RandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string RandomHero()
        {
            string[] heroes = { "Batman", "Spongebob", "Spiderman", "Patric", "Lara Croft" };


            return heroes[RandomIndex(heroes)];
        }

        private static string RandomVillain()
        {
            string[] villains = { "Joker", "Hannibal Lecter", "Norman Bates", "Darth Vader", "Harley Quinn" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villains.Length);

            string randomVillain = villains[randomIndex];
            return randomVillain;
        }

        private static string RandomWeapon()
        {
            string[] weapon = { "spoon", "water gun", "flip-flop", "magic wand", "katana" };

            return weapon[RandomIndex(weapon)];
        }
    }
}
