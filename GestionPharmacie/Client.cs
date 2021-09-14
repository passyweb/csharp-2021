namespace GestionPharmacie
{
    public class Client
    {
        public Client(string nom, double crédit)
        {
            Nom = nom;
            Crédit = crédit;
        }

        public string Nom { get; }
        public double Crédit { get; set; }

        public override string ToString() 
            => $"Crédit du client {Nom}: {Crédit}";
    }
}