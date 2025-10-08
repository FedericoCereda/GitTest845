using System;
using System.Collections.Generic;

namespace Esercizio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Studente> studenti = new List<Studente>
            {
                new Studente(101, "Mario", "Rossi"),
                new Studente(102, "Luca", "Bianchi"),
                new Studente(103, "Giulia", "Verdi")
            };

            Console.WriteLine("--- Registro Studenti ---\n");

            foreach (var studente in studenti)
            {
                Console.WriteLine(studente);
            }

            Console.WriteLine("\n--- Test Equals() ---");

            Studente studenteA = new Studente(200, "Anna", "Neri");
            Studente studenteB = new Studente(200, "Anna", "Neri");

            bool uguali = studenteA.Equals(studenteB);
            Console.WriteLine($"I due studenti sono uguali? {uguali}");
            Console.ReadKey();
        }
    }
}
