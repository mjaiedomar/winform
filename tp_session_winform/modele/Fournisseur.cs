using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_session_winform.modele
{
   class Fournisseur : Contact
    {
        public int code_scn { get; set; }

        public Fournisseur (int code_scn, string nom, string email): base(nom, email)
        {
            this.code_scn = code_scn;
        }
        public override string ToString()
        {
            return code_scn  + "  " +  base.ToString()  ;
        }

        public void PasserCommende ()
        {


        }

    }
}
