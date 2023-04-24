using MySql.Data.MySqlClient;
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
    public partial class FormListings : Form
    {
        public FormListings()
        {
            InitializeComponent();
        }

        private void btnListContact_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string cs = "server=localhost;user=root;" +
                 "database=northwindmysql;port=3306";

            DaoContact dao = new DaoContact(cs);

            ////Command avec select
            string requete = "select nom,email from contact;";
          
           
            List<Contact> listing = dao.ExecuterRequete(requete);
            //Affichage du retour de select dans TxtListing

            foreach (Contact c in listing)
            {
                listBox1.Items.Add(c);
            }
        }

        private void btnListFournisseur_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string cs = "server=localhost;user=root;" +
                 "database=northwindmysql;port=3306";

            DaoContact dao = new DaoContact(cs);

            ////Command avec select
            string requete = "select code_scn,nom,email from fournisseur;";


            List<Fournisseur> listing = dao.ExecuterRequeteFrs(requete);
            //Affichage du retour de select dans TxtListing

            foreach (Fournisseur f in listing)
            {
                listBox1.Items.Add(f);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
