using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_GameTicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int number = 1;
            int size = 3;
            for (int i=0; i<size; i++)
            {
                for (int j = 0; j<size; j++)
                {
                    Console.WriteLine(number + " ");
                    number++;
                }
            }
            */
            
            TicTacToe game = new TicTacToe();
            game.play();
            Console.ReadKey();
        }
    }
}
