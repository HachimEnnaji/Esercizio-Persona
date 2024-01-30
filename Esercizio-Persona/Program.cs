using System;

namespace Esercizio_Persona
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Inserisci il nome:\t");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome:\t");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci l'eta':\t");
            int eta;
            while (!int.TryParse(Console.ReadLine(), out eta))
            {

                Console.WriteLine("Errore il numero inserito non è corretto, prego reinserire!");
            }

            Persona omar = new Persona(nome, cognome, eta);
            Console.WriteLine(omar.GetDettagli());
            Console.ReadKey();
        }
    }
}
