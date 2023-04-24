using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_session_winform.modele
{
    internal class RegistreContact
    {
        private List<Contact> _contactList;

        public RegistreContact()
        {
            _contactList = new List<Contact>();
        }

        public void AjouterEmploye(Contact contc)
        {
            if (ValiderDoublon(contc))
            {
                Console.WriteLine("Employé doublon");
            }
            else
            {
                _contactList.Add(contc);
            }

        }

        private bool ValiderDoublon(Contact contc)
        {
            foreach (Contact tmp in _contactList)
            {
                if (tmp.Equals(contc))
                {
                    return true;
                }
            }
            return false;
        }

        public void ListerEmployes()
        {
            foreach (Contact tmp in _contactList)
            {
                Console.WriteLine(tmp);
            }
        }
    }
}
