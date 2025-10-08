using System;

namespace Esercizio;

public class Studente
    {
        public int Matricola { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Studente(int matricola, string nome, string cognome)
        {
            Matricola = matricola;
            Nome = nome;
            Cognome = cognome;
        }

        public override string ToString()
        {
            return $"Matricola: {Matricola} | Nome: {Nome} {Cognome}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Studente other)
            {
                return this.Matricola == other.Matricola;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Matricola.GetHashCode();
        }
    }

