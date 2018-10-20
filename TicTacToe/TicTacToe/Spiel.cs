using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TicTacToe
{
    internal class Spiel
    {
        private int spieler;
        private string feld;
        private Aktualisierung aktualisierung;
        private Eingabe eingabe;
        //das hier ist die Klasse Spiel
        public Spiel()
        {
            //das ist der Konstruktor
            //das Anfangsfeld besteht anfangs nur aus '='
            feld = "=========";
            aktualisierung = new Aktualisierung();
            eingabe = new Eingabe();
        }

        private void Start()
        {
            //(x) zufall wer dran
            //neue runde
                //aktualisiere (spielfeld)
                //eingabe
                    //abwechseln
                    //überprüfung der eingabe
                    //ausführung der eingabe(1-9)
                    //ausgang von eingabe (spiel vorbei?)



            Random rdm = new Random();
            //Zahl zwischen 1-3(3 NICHT eingeschlossen) wird generiert
            int i = rdm.Next(1,3);
            if(i == 1)//Wenn die Zahl = 1 ist, ist Spieler 1 dran, sonst Spieler 2
            {
                spieler = 1;
            }//Ende then
            else
            {
                spieler = 2;
            }//Ende else

            neueRunde();
        }

        private void neueRunde()
        {
            //Feld wird aktualisiert
            aktualisierung.Aktualisiere(feld);
            //Eingabe


        }

        public string gibFeld() => feld;

        public int gibSpieler() => spieler;

    }
}