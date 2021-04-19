using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg
{
    internal class Program
    {
        private static Player player = new Player(null,null);
        private static bool GameOver { get; set; } = false;

        private static void Main(string[] args)
        {
            Init();

            Console.ReadKey();
        }
        private static void Init()
        {
            player = new Player(player.GetName(), player.GetClass());
            player.Hp = 10;
            player.Level = 1;
            player.ExpToLevel = 50;
            player.PrintUserInfo();
        }
        private static void Game() { }
    }
}
