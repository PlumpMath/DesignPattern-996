using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternII
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new DVDPlayer();

            player.PressPlayButton();
            player.PressMenuButton();
            player.PressPlayButton();
            player.PressPlayButton();
            player.PressMenuButton();
            player.PressPlayButton();
            player.PressPlayButton();
        }
    }
}
