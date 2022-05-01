namespace Recherche_dans_une_BDD
{
    partial class Form1
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
            this.ValiderButton = new System.Windows.Forms.Button();
            this.QuitterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.codeFouTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ValiderButton
            // 
            this.ValiderButton.Location = new System.Drawing.Point(33, 66);
            this.ValiderButton.Name = "ValiderButton";
            this.ValiderButton.Size = new System.Drawing.Size(75, 23);
            this.ValiderButton.TabIndex = 3;
            this.ValiderButton.Text = "Valider";
            this.ValiderButton.UseVisualStyleBackColor = true;
            this.ValiderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuitterButton
            // 
            this.QuitterButton.Location = new System.Drawing.Point(144, 66);
            this.QuitterButton.Name = "QuitterButton";
            this.QuitterButton.Size = new System.Drawing.Size(75, 23);
            this.QuitterButton.TabIndex = 2;
            this.QuitterButton.Text = "Quitter";
            this.QuitterButton.UseVisualStyleBackColor = true;
            this.QuitterButton.Click += new System.EventHandler(this.QuitterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code Fournisseur";
            // 
            // codeFouTxtBox
            // 
            this.codeFouTxtBox.AutoCompleteCustomSource.AddRange(new string[] {
            "00120",
            "00123",
            "8700"});
            this.codeFouTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.codeFouTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.codeFouTxtBox.Location = new System.Drawing.Point(144, 23);
            this.codeFouTxtBox.Name = "codeFouTxtBox";
            this.codeFouTxtBox.Size = new System.Drawing.Size(100, 20);
            this.codeFouTxtBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 109);
            this.Controls.Add(this.codeFouTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuitterButton);
            this.Controls.Add(this.ValiderButton);
            this.Name = "Form1";
            this.Text = "Affichage Fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ValiderButton;
        private System.Windows.Forms.Button QuitterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeFouTxtBox;
    }
}

