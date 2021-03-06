using System;

namespace ConsoleApp2
{
    class Program
    {

        static void Main()
        {
            float level = 2;
            double lvl = 1;
            double points = 0;
            double output = 0;
            double xpToLevel = 83;
            double xpForLevel = 83;
            double difference = 0;

            while (level < 100 && lvl < 100)
            {
                if (level > 2)
                {
                    xpToLevel += (xpToLevel * 0.1f);
                    int i = (int)Math.Round(xpToLevel);
                    xpForLevel = xpForLevel + i;
                }
                points += Math.Floor(lvl + 300 * Math.Pow(2, lvl / 7f));
                output = Math.Floor(points / 4);
                difference = output - xpForLevel;
                Console.WriteLine("Level: " + level.ToString());
                Console.WriteLine("XP Needed for this Level at 10%: " + String.Format("{0:n0}", xpForLevel) + "xp.");
                Console.WriteLine("Actual XP Needed for this Level in-game: " + String.Format("{0:n0}", output) + "xp.");
                Console.WriteLine("That is a difference of: " + String.Format("{0:n0}", difference) + "xp.");
                Console.WriteLine("");
                level++;
                lvl++;
            }
        }
    }
}
