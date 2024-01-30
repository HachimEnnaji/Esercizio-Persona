using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Persona
{
    internal class Persona
    {
           public string Nome;
           public string Cognome;
           public int Eta;

        public Persona(string nome,string cognome, int eta) {

            this.Nome = nome;
            this.Cognome = cognome;
            this.Eta = eta;
        }
        public  string GetDettagli() {
            //Console.WriteLine($"Nome :\t {this.Nome}\n cognome:\t {this.Cognome}\n ha:\t {this.Eta} anni");
            return this.Nome + " " + this.Cognome + " " + this.Eta;
        }
        public string GetNome()
        {
            return this.Nome;
        }
        public string GetCognome()
        {
            return this.Cognome;
        }
        public int GetEta()
        {
            return this.Eta;
        }
    }
}
