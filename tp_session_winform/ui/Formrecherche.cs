using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_session_winform.modele;

namespace tp_session_winform.ui
{
    public partial class Formrecherche : Form
    {
        public Formrecherche()
        {
            InitializeComponent();
        }

        private void btnRechercheContact_Click(object sender, EventArgs e)
        {
            string cs = "server=localhost;user=root;" +
               "database=northwindmysql;port=3306";

            DaoContact dao = new DaoContact(cs);

            //insert Contact 
            string nom = textBox1.Text;

            string requete = "select nom,email from contact where Nom ="+
                "@nom;";


            List<Contact> listing = dao.ExecuterRequeteSearch(requete, nom);
            //Affichage du retour de select dans TxtListing

            foreach (Contact c in listing)
            {
                listBoxContact.Items.Add(c);
            }
        }

        private void btnRechercheFrs_Click(object sender, EventArgs e)
        {
            string cs = "server=localhost;user=root;" +
               "database=northwindmysql;port=3306";

            DaoContact dao = new DaoContact(cs);

            //insert Contact 
            string nom = textBox2.Text;

            string requete = "select code_scn, nom,email from fournisseur where Nom =" +
                "@nom;";


            List<Fournisseur> listing = dao.ExecuterRequeteSearchFrs(requete, nom);
            //Affichage du retour de select dans TxtListing

            foreach (Fournisseur f in listing)
            {
                listBoxFournisseur.Items.Add(f);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
