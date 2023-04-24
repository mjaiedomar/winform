namespace tp_session_winform
{
    partial class FormAceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAffichage = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAffichage
            // 
            this.BtnAffichage.Location = new System.Drawing.Point(96, 117);
            this.BtnAffichage.Name = "BtnAffichage";
            this.BtnAffichage.Size = new System.Drawing.Size(130, 124);
            this.BtnAffichage.TabIndex = 0;
            this.BtnAffichage.Text = "Listing";
            this.BtnAffichage.UseVisualStyleBackColor = true;
            this.BtnAffichage.Click += new System.EventHandler(this.BtnAffichage_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(338, 117);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(130, 124);
            this.btnAjout.TabIndex = 1;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(574, 117);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(130, 124);
            this.btnRecherche.TabIndex = 2;
            this.btnRecherche.Text = "chercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // FormAceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.BtnAffichage);
            this.Name = "FormAceuil";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAffichage;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnRecherche;
    }
}

