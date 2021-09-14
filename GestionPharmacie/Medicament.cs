namespace GestionPharmacie
{
    public class Medicament
    {
        public Medicament(string nom, double prix, int stock)
        {
            Nom = nom;
            Prix = prix;
            Stock = stock;
        }

        public string Nom { get; }
        public double Prix { get; }
        public int Stock { get; set; }

        public override string ToString() 
            => $"Stock du médicament {Nom}: {Stock:0.00}";
    }
}