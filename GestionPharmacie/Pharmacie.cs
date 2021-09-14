using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace GestionPharmacie
{
    public class Pharmacie
    {
        public Pharmacie(List<Client> clients, List<Medicament> medicaments)
        {
            Clients = clients;
            Medicaments = medicaments;
        }

        public List<Client> Clients { get; }
        public List<Medicament> Medicaments { get; }

        public void Achat()
        {
            var client = LireClient();
            var medicament = LireMedicament();

            Write("Quantité: ");
            var quantité = int.Parse(ReadLine());
            Write("Montant: ");
            var montant = double.Parse(ReadLine());

            medicament.Stock -= quantité;
            client.Crédit -= quantité * medicament.Prix;
        }

        public void Approvisionnement()
        {
            Medicament medicament = LireMedicament();

            Write("Quantité : ");
            var stock = int.Parse(ReadLine());
            medicament.Stock += stock;
        }

        public void Affichage()
        {
            WriteLine("Affichage des stocks");
            foreach (var client in Clients)
            {
                WriteLine(client);
            }
            WriteLine("Affichage des crédits");
            foreach (var medicament in Medicaments)
            {
                WriteLine(medicament);
            }
        }

        private Medicament LireMedicament()
        {
            Medicament medicament = null;
            do
            {
                Write("Nom du médicament: ");
                var nom = ReadLine();
                medicament = Medicaments.FirstOrDefault(m => m.Nom.Equals(nom));
            } while (medicament == null);

            return medicament;
        }

        private Client LireClient()
        {
            Client client = null;

            do
            {
                Write("Nom du client: ");
                var nom = ReadLine();
                client = Clients.FirstOrDefault(c => c.Nom.Equals(nom));
            } while (client == null);

            return client;
        }
    }
}