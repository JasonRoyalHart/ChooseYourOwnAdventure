using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Loop loop = new Loop();
            Player player = new Player();
            Game game = new Game();
            Map map = new Map();
            Person[] people = new Person[7];
            game.makePeople(people);
            player.setName();
            game.introduction(player);
            loop.mainLoop(player, map, people);
            game.gameOver(player);
            
        }
    }
}
