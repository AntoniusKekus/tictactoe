using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TicTacToe
{
    internal class Aktualisierung
    {
        public void Aktualisiere(string Feld)
        {
            Console.Clear();
            Console.WriteLine(Feld[0] + "|" + Feld[1] + "|" + Feld[2] + "\n" + Feld[3] + "|" + Feld[4] + "|" + Feld[5] + "\n" + Feld[6] + "|" + Feld[7] + "|" + Feld[8]);

        }
    }


}