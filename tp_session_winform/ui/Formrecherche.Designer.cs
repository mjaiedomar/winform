namespace tp_session_winform.ui
{
    partial class Formrecherche
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlContact = new System.Windows.Forms.TabControl();
            this.tabPageContact = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxContact = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRechercheContact = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageFrs = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBoxFournisseur = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRechercheFrs = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControlContact.SuspendLayout();
            this.tabPageContact.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageFrs.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlContact
            // 
            this.tabControlContact.Controls.Add(this.tabPageContact);
            this.tabControlContact.Controls.Add(this.tabPageFrs);
            this.tabControlContact.Location = new System.Drawing.Point(35, 37);
            this.tabControlContact.Name = "tabControlContact";
            this.tabControlContact.SelectedIndex = 0;
            this.tabControlContact.Size = new System.Drawing.Size(722, 370);
            this.tabControlContact.TabIndex = 0;
            // 
            // tabPageContact
            // 
            this.tabPageContact.Controls.Add(this.panel2);
            this.tabPageContact.Controls.Add(this.panel1);
            this.tabPageContact.Location = new System.Drawing.Point(8, 39);
            this.tabPageContact.Name = "tabPageContact";
            this.tabPageContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContact.Size = new System.Drawing.Size(706, 323);
            this.tabPageContact.TabIndex = 0;
            this.tabPageContact.Text = "Contact";
            this.tabPageContact.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBoxContact);
            this.panel2.Location = new System.Drawing.Point(28, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 159);
            this.panel2.TabIndex = 1;
            // 
            // listBoxContact
            // 
            this.listBoxContact.FormattingEnabled = true;
            this.listBoxContact.ItemHeight = 25;
            this.listBoxContact.Location = new System.Drawing.Point(23, 18);
            this.listBoxContact.Name = "listBoxContact";
            this.listBoxContact.Size = new System.Drawing.Size(615, 104);
            this.listBoxContact.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRechercheContact);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 106);
            this.panel1.TabIndex = 0;
            // 
            // btnRechercheContact
            // 
            this.btnRechercheContact.Location = new System.Drawing.Point(419, 32);
            this.btnRechercheContact.Name = "btnRechercheContact";
            this.btnRechercheContact.Size = new System.Drawing.Size(164, 42);
            this.btnRechercheContact.TabIndex = 3;
            this.btnRechercheContact.Text = "Chercher";
            this.btnRechercheContact.UseVisualStyleBackColor = true;
            this.btnRechercheContact.Click += new System.EventHandler(this.btnRechercheContact_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 31);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom:";
            // 
            // tabPageFrs
            // 
            this.tabPageFrs.Controls.Add(this.panel4);
            this.tabPageFrs.Controls.Add(this.panel3);
            this.tabPageFrs.Location = new System.Drawing.Point(8, 39);
            this.tabPageFrs.Name = "tabPageFrs";
            this.tabPageFrs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFrs.Size = new System.Drawing.Size(706, 323);
            this.tabPageFrs.TabIndex = 1;
            this.tabPageFrs.Text = "Fournisseur";
            this.tabPageFrs.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listBoxFournisseur);
            this.panel4.Location = new System.Drawing.Point(12, 145);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(679, 153);
            this.panel4.TabIndex = 1;
            // 
            // listBoxFournisseur
            // 
            this.listBoxFournisseur.FormattingEnabled = true;
            this.listBoxFournisseur.ItemHeight = 25;
            this.listBoxFournisseur.Location = new System.Drawing.Point(17, 20);
            this.listBoxFournisseur.Name = "listBoxFournisseur";
            this.listBoxFournisseur.Size = new System.Drawing.Size(644, 129);
            this.listBoxFournisseur.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRechercheFrs);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(679, 112);
            this.panel3.TabIndex = 0;
            // 
            // btnRechercheFrs
            // 
            this.btnRechercheFrs.Location = new System.Drawing.Point(401, 30);
            this.btnRechercheFrs.Name = "btnRechercheFrs";
            this.btnRechercheFrs.Size = new System.Drawing.Size(178, 44);
            this.btnRechercheFrs.TabIndex = 2;
            this.btnRechercheFrs.Text = "Chercher";
            this.btnRechercheFrs.UseVisualStyleBackColor = true;
            this.btnRechercheFrs.Click += new System.EventHandler(this.btnRechercheFrs_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 31);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Formrecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControlContact);
            this.Name = "Formrecherche";
            this.Text = "Formrecherche";
            this.tabControlContact.ResumeLayout(false);
            this.tabPageContact.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageFrs.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlContact;
        private System.Windows.Forms.TabPage tabPageContact;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxContact;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRechercheContact;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageFrs;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox listBoxFournisseur;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRechercheFrs;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}