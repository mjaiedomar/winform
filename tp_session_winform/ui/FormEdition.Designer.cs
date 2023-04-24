namespace tp_session_winform.ui
{
    partial class FormEdition
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAjoutContact = new System.Windows.Forms.TabPage();
            this.btnAjoutContact = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAjoutFournisseur = new System.Windows.Forms.TabPage();
            this.btnAjoutFournisseur = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAjoutContact.SuspendLayout();
            this.tabAjoutFournisseur.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAjoutContact);
            this.tabControl1.Controls.Add(this.tabAjoutFournisseur);
            this.tabControl1.Location = new System.Drawing.Point(27, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 337);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAjoutContact
            // 
            this.tabAjoutContact.Controls.Add(this.button1);
            this.tabAjoutContact.Controls.Add(this.btnAjoutContact);
            this.tabAjoutContact.Controls.Add(this.txtEmail);
            this.tabAjoutContact.Controls.Add(this.txtNom);
            this.tabAjoutContact.Controls.Add(this.label2);
            this.tabAjoutContact.Controls.Add(this.label1);
            this.tabAjoutContact.Location = new System.Drawing.Point(8, 39);
            this.tabAjoutContact.Name = "tabAjoutContact";
            this.tabAjoutContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabAjoutContact.Size = new System.Drawing.Size(724, 290);
            this.tabAjoutContact.TabIndex = 0;
            this.tabAjoutContact.Text = "Contact";
            this.tabAjoutContact.UseVisualStyleBackColor = true;
            // 
            // btnAjoutContact
            // 
            this.btnAjoutContact.Location = new System.Drawing.Point(172, 209);
            this.btnAjoutContact.Name = "btnAjoutContact";
            this.btnAjoutContact.Size = new System.Drawing.Size(124, 50);
            this.btnAjoutContact.TabIndex = 4;
            this.btnAjoutContact.Text = "Ajouter";
            this.btnAjoutContact.UseVisualStyleBackColor = true;
            this.btnAjoutContact.Click += new System.EventHandler(this.btnAjoutContact_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(237, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 31);
            this.txtEmail.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(237, 57);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(196, 31);
            this.txtNom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
            // 
            // tabAjoutFournisseur
            // 
            this.tabAjoutFournisseur.Controls.Add(this.btnAjoutFournisseur);
            this.tabAjoutFournisseur.Controls.Add(this.textBox3);
            this.tabAjoutFournisseur.Controls.Add(this.textBox2);
            this.tabAjoutFournisseur.Controls.Add(this.textBox1);
            this.tabAjoutFournisseur.Controls.Add(this.label5);
            this.tabAjoutFournisseur.Controls.Add(this.label4);
            this.tabAjoutFournisseur.Controls.Add(this.label3);
            this.tabAjoutFournisseur.Location = new System.Drawing.Point(8, 39);
            this.tabAjoutFournisseur.Name = "tabAjoutFournisseur";
            this.tabAjoutFournisseur.Padding = new System.Windows.Forms.Padding(3);
            this.tabAjoutFournisseur.Size = new System.Drawing.Size(724, 290);
            this.tabAjoutFournisseur.TabIndex = 1;
            this.tabAjoutFournisseur.Text = "Fournisseur";
            this.tabAjoutFournisseur.UseVisualStyleBackColor = true;
            // 
            // btnAjoutFournisseur
            // 
            this.btnAjoutFournisseur.Location = new System.Drawing.Point(161, 215);
            this.btnAjoutFournisseur.Name = "btnAjoutFournisseur";
            this.btnAjoutFournisseur.Size = new System.Drawing.Size(150, 41);
            this.btnAjoutFournisseur.TabIndex = 6;
            this.btnAjoutFournisseur.Text = "Ajouter";
            this.btnAjoutFournisseur.UseVisualStyleBackColor = true;
            this.btnAjoutFournisseur.Click += new System.EventHandler(this.btnAjoutFournisseur_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(211, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(236, 31);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 31);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 31);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormEdition";
            this.Text = "FormEdition";
            this.tabControl1.ResumeLayout(false);
            this.tabAjoutContact.ResumeLayout(false);
            this.tabAjoutContact.PerformLayout();
            this.tabAjoutFournisseur.ResumeLayout(false);
            this.tabAjoutFournisseur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAjoutContact;
        private System.Windows.Forms.Button btnAjoutContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabAjoutFournisseur;
        private System.Windows.Forms.Button btnAjoutFournisseur;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}