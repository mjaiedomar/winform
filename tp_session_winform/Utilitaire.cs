using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp_session_winform.modele;

namespace tp_session_winform
{
    internal class Utilitaire
    {

        internal static void AfficherList(List<Contact> listing)
        {
            foreach (Contact category in listing)
            {
                Console.WriteLine(category);
            }
        }

        public static Contact SaisirCategory()
        {
            Console.WriteLine("Saisir la categorie:");
            string nom = Console.ReadLine();
            Console.WriteLine("Saisir la description:");
            string email= Console.ReadLine();
            

            return new Contact(nom, email);
        }

    }
}
