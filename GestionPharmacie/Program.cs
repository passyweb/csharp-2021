using System;
using System.Collections.Generic;
using static System.Console;

namespace GestionPharmacie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>();
            List<Medicament> medicaments = new List<Medicament>();

            clients.Add(new Client("Malfichu", 0.0));
            clients.Add(new Client("Palichon", 0.0));
            medicaments.Add(new Medicament("Aspiron", 20.40, 5));
            medicaments.Add(new Medicament("Rhinoplexil", 19.15, 5));

            Pharmacie pharmacie = new Pharmacie(clients, medicaments);

            int choix;
            do
            {
                choix = Menu();
                switch (choix)
                {
                    case 1:
                        pharmacie.Achat();
                        break;
                    case 2:
                        pharmacie.Approvisionnement();
                        break;
                    case 3:
                        pharmacie.Affichage();
                        break;
                    case 4:
                        Quitter();
                        break;
                }
            } while (choix < 4);
        }
    
        static int Menu()
        {
            int choix = 0;
            WriteLine();
            WriteLine();
            WriteLine("1 : Achat de médicament");
            WriteLine("2 : Approvisionnement en médicaments");
            WriteLine("3 : Etats des stocks et des crédits");
            WriteLine("4 : Quitter");
            
            while ((choix != 1) && (choix != 2) && (choix != 3) && (choix != 4))
            {
            choix = Int16.Parse(ReadLine());
            }
            return choix;
        }
        static void Quitter()
        {
            WriteLine("Programme terminé !");
        } 
    }
}
