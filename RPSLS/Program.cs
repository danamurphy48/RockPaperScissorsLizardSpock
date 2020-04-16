using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.RunGame();
        }
    }//dont use switch case to assign gesture data validation
    //fix while loop cycling and make sure it counts all rounds and breaks when a score >3 - fixed
    //figure out how to indicate which human player's turn it is
    //player two not scoring points - fixed
}
