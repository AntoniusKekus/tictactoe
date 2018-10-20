using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //das hier ist die Main-Klasse, die aufgerufen wird, wenn man das Programm startet
            Spiel spiel = new Spiel();

            //Spiel wird gestartet
            spiel.Start();

            //

            Console.ReadKey();
        }
    }
}
