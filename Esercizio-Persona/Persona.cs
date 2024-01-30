namespace Esercizio_Persona
{
    internal class Persona
    {
        public string _nome;
        public string _cognome;
        public int _eta;

        public Persona(string nome, string cognome, int eta)
        {
            _nome = nome;
            _cognome = cognome;
            _eta = eta;
        }
        public string GetDettagli()
        {
            //test per commit

            //Console.WriteLine($"Nome :\t {this.Nome}\n cognome:\t {this.Cognome}\n ha:\t {this.Eta} anni");
            return "Nome: " + _nome + "\tCognome: " + _cognome + "\tEta':" + _eta + " anni";
        }
        public string GetNome()
        {
            return _nome;
        }
        public string GetCognome()
        {
            return _cognome;
        }
        public int GetEta()
        {
            return _eta;
        }
    }
}

