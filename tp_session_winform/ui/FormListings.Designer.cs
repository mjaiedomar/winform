namespace tp_session_winform.ui
{
    partial class FormListings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListFournisseur = new System.Windows.Forms.Button();
            this.btnListContact = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnListFournisseur);
            this.panel1.Controls.Add(this.btnListContact);
            this.panel1.Location = new System.Drawing.Point(21, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 96);
            this.panel1.TabIndex = 0;
            // 
            // btnListFournisseur
            // 
            this.btnListFournisseur.Location = new System.Drawing.Point(449, 28);
            this.btnListFournisseur.Name = "btnListFournisseur";
            this.btnListFournisseur.Size = new System.Drawing.Size(230, 46);
            this.btnListFournisseur.TabIndex = 1;
            this.btnListFournisseur.Text = "Fournisseurs";
            this.btnListFournisseur.UseVisualStyleBackColor = true;
            this.btnListFournisseur.Click += new System.EventHandler(this.btnListFournisseur_Click);
            // 
            // btnListContact
            // 
            this.btnListContact.Location = new System.Drawing.Point(87, 28);
            this.btnListContact.Name = "btnListContact";
            this.btnListContact.Size = new System.Drawing.Size(230, 46);
            this.btnListContact.TabIndex = 0;
            this.btnListContact.Text = "Contacts";
            this.btnListContact.UseVisualStyleBackColor = true;
            this.btnListContact.Click += new System.EventHandler(this.btnListContact_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(21, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 230);
            this.panel2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(29, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(700, 179);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormListings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormListings";
            this.Text = "FormListings";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListFournisseur;
        private System.Windows.Forms.Button btnListContact;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}