using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_session_winform.modele
{
    class Contact
    {
        public String Nom { get; set; }
        public String Email { get; set; }

        public Contact(string nom, string email)
        {
            Nom = nom;
            Email = email;
        }
        public override string ToString()
        {
            return Nom + "    "+ Email;
        }
    }


}
