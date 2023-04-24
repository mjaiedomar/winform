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
    public partial class FormEdition : Form
    {
        public FormEdition()
        {
            InitializeComponent();
        }

        private void btnAjoutContact_Click(object sender, EventArgs e)
        {
            string cs = "server=localhost;user=root;" +
               "database=northwindmysql;port=3306";

            DaoContact dao = new DaoContact(cs);
            
            //insert Contact 
            string nom = txtNom.Text;
            string email = txtEmail.Text;
          

            Contact contc = new Contact(nom,email);
            string cde = "insert into contact(Nom, email)values(@nom," +
                "@email)";

            //Console.WriteLine(cde);
            int lignes = dao.ExecuterCommande(cde, contc);

            MessageBox.Show("Nombre de lignes" + lignes);
        }

        private void btnAjoutFournisseur_Click(object sender, EventArgs e)
        {

        }

        private void btnAjoutFournisseur_Click_1(object sender, EventArgs e)
        {
             string cs = "server=localhost;user=root;" +
               "database=northwindmysql;port=3306";

            DaoContact dao = new DaoContact(cs);

            //insert fournisseur 
            string code = textBox1.Text;
            string nom = textBox2.Text;
            string email = textBox3.Text;
          
            int code_scn =Int32.Parse(code);

            Fournisseur frs= new Fournisseur (code_scn, nom, email);
            string cde = "insert into fournisseur( code_scn, nom, email)values( @code_scn, @nom," +
                "@email)";

            //Console.WriteLine(cde);
            int lignes = dao.ExecuterCommandeFornisseur(cde, frs);

            MessageBox.Show("Nombre de lignes" + lignes);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
