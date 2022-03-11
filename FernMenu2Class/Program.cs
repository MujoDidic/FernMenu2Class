/*################################################
 * Einsendeaufgabe 5.1
 * #############################################*/
using System;

namespace Fernseher
{
    class Program
    {
        static void Main(string[] args)
        {

            EinAusGeschaltet FernEin = new EinAusGeschaltet();
            LautsprecherClass LautSprecherInput = new LautsprecherClass();
            ProgramAendern NeuProgram = new ProgramAendern();

            do
            {

                if (FernEin.EinSchalten() == true)
                {
                    Console.WriteLine("Fernseher ist Eingeschaltet!!!");
                }
                else
                {
                    Console.WriteLine("Fernseher ist Ausgeschaltet!!!");
                }

                Console.WriteLine("Program: {0}", NeuProgram.ProgrammNummer());

                Console.WriteLine("Lautstärke: {0}", LautSprecherInput.LautsprecherZustand());

                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
                Console.WriteLine("Fernseher Einschalten [1] ");
                Console.WriteLine("Lautstärke ändern     [2] ");
                Console.WriteLine("Programm ändern       [3] ");
                Console.WriteLine("Fernseher ausschalten [4] ");
                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
                int eingabe = Convert.ToInt32(Console.ReadLine());

                switch (eingabe)
                {
                    case 1:
                        if (FernEin.EinSchalten() == false)
                        {
                            FernEin.FerStart();
                        }
                        else
                        {
                           // Console.Clear();
                            Console.WriteLine("Fernseher ist schon Eingeschaltet!!!");
                        }


                        break;
                    case 2:
                        if (FernEin.EinSchalten() == true)
                        {
                            LautSprecherInput.Lautstaerke();

                        }
                        else
                        {
                            Console.WriteLine("Schalten Sie bitte erst Fernseher ein!!!");
                        }


                        break;

                    case 3:
                        if (FernEin.EinSchalten() == true)
                        {
                            NeuProgram.ProgrammSteuerung();

                        }
                        else
                        {
                            Console.WriteLine("Schalten Sie bitte erst Fernseher ein!!!");

                        }
                            break;
                    case 4:

                        FernEin.FerStop();
                        break;

                }
            } while (true);






        }//Ende Main Methode


    } //Ende class Program

    class EinAusGeschaltet
    {

        bool einAus = false;

        public void ZustandAendern(bool einAus) // Änderen der Zustand von "bool einAus" in false oder true
        {
            this.einAus = einAus;
        }

        public bool EinSchalten() // Zurück geben wert von "bool einAus"
        {
            return einAus;
        }

        public void FerStart() //Fernseher einschalten
        {
            if (einAus == false)

                ZustandAendern(true);

        } //Ende Methode FerStart()


        public void FerStop() //Fernseher auschalten
        {

            Console.Clear();
            Console.WriteLine(EinSchalten());

            if (einAus != false)
                ZustandAendern(false);





        } // Ende Methode FerStop()



        
    }//Ende class EinAusgeschaltet



    class LautsprecherClass
    {
        private int lautSprecherInt = 0;

        public void LautsprecherZustandAendern(int lautSprecherInt) // Änderen der Zustand von "bool einAus" in false oder true
        {
            this.lautSprecherInt = lautSprecherInt;
        }

        public int LautsprecherZustand() // Zurück geben wert von "bool einAus"
        {
            return lautSprecherInt;
        }
        public void Lautstaerke()
        {
            

            Console.WriteLine("-------------------------------");
            Console.Write("Lautstärke zu ändern geben Sie Nummer von 0 bis 10 ein:");

            int eingabeNummer = Convert.ToInt32(Console.ReadLine());

            LautsprecherZustandAendern(eingabeNummer);

                int[] Lautsprecher = new int[eingabeNummer + 1];

                if (eingabeNummer < 11)
                {
                    Console.Write("Lautstärtke:");
                    for (int i = 1; i < Lautsprecher.Length; i++)
                    {
                        Console.Write(i + " ");
                    }

                }
                else
                {
                    Console.WriteLine("Geben Sie erlaubte Nummer ein!!!");
                }


                Console.WriteLine("\n-------------------------------");


        }//Ende Methode Lautstaerke

    }//Ende class  LautsprecherClass 


    class ProgramAendern
    {
        private int programmNummerInt = 0;

        public void ProgrammNummerAendern(int programNummerInt) // Änderen Programnummer
        {
            this.programmNummerInt = programNummerInt;
        }

        public int ProgrammNummer() // Zeigt Programmnummer
        {
            return programmNummerInt;
        }

        public void ProgrammSteuerung()
        {


            Console.WriteLine("-------------------------------");
            Console.Write("Program zu ändern geben Sie Nummer von 0 bis 10 ein:");

            int eingabeProgrammNummer = Convert.ToInt32(Console.ReadLine());

            ProgrammNummerAendern(eingabeProgrammNummer);

            int[] Lautsprecher = new int[eingabeProgrammNummer + 1];

            if (eingabeProgrammNummer < 11)
            {
                Console.Write("Programm:");
                for (int i = 1; i < Lautsprecher.Length; i++)
                {
                    Console.Write(i + " ");
                }

            }
            else
            {
                Console.WriteLine("Geben Sie erlaubte Programmnummer ein!!!");
            }
            Console.WriteLine("\n-------------------------------");


        }//Ende Methode ProgrammSteuerung

    }//Ende class ProgramAendern

}//Ende Namespace Fernseher


