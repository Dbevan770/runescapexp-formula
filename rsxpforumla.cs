using System;

namespace ConsoleApp2
{
    class Program
    {

        static void Main()
        {
            float level = 1;
            double lvl = 1;
            double points = 0;
            double output = 0;
            double currentXP = 0;
            double xpToLevel = 83;
            double xpForLevel = 83;
            double difference = 0;

            while (level < 99 && lvl < 99)
            {
                if (level == 1)
                {
                    currentXP += xpToLevel;
                }
                else
                {
                    currentXP += xpToLevel;
                    xpToLevel += (xpToLevel * 0.1f);
                    int i = (int)Math.Round(xpToLevel);
                    xpForLevel = xpForLevel + i;
                }
                points += Math.Floor(lvl + 300 * Math.Pow(2, lvl / 7f));
                output = Math.Floor(points / 4);
                difference = output - xpForLevel;
                Console.WriteLine("Level: " + level.ToString());
                Console.WriteLine("XP Needed for next Level at 10%: " + String.Format("{0:n0}", xpForLevel) + "xp.");
                Console.WriteLine("Actual XP Needed for next Level in-game: " + String.Format("{0:n0}", output) + "xp.");
                Console.WriteLine("That is a difference of: " + String.Format("{0:n0}", difference) + "xp.");
                Console.WriteLine("");
                level++;
                lvl++;
            }
        }
    }
}