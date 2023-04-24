using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_session_winform.ui;

namespace tp_session_winform
{
    public partial class FormAceuil : Form
    {
        public FormAceuil()
        {
            InitializeComponent();
        }

        private void BtnAffichage_Click(object sender, EventArgs e)
        {
            FormListings listing = new FormListings();
            listing.Visible = true;
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            FormEdition edition = new FormEdition();
            edition.Visible = true;
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            Formrecherche listing = new Formrecherche();
            listing.Visible = true;
        }
    }
}
