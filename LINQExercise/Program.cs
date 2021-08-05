using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var VidGames = new List<string>() { "Fortnite", "Call of Duty", "Battlefield", "GTA", "Fall Guys", "Rocket League","Minecraft" };
            var OrList = VidGames.OrderBy(x => x.Length);
            foreach (var a in OrList)
                Console.WriteLine(a);

        }
    }
}
