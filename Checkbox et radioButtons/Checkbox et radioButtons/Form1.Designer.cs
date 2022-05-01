namespace Checkbox_et_radioButtons
{
    partial class CheckBoxEtRadioButton
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
            this.label1 = new System.Windows.Forms.Label();
            this.textSaisi = new System.Windows.Forms.TextBox();
            this.Fond = new System.Windows.Forms.GroupBox();
            this.Bleu = new System.Windows.Forms.RadioButton();
            this.Vert = new System.Windows.Forms.RadioButton();
            this.Rouge = new System.Windows.Forms.RadioButton();
            this.caracteres = new System.Windows.Forms.GroupBox();
            this.Noir = new System.Windows.Forms.RadioButton();
            this.Blanc = new System.Windows.Forms.RadioButton();
            this.Rouge2 = new System.Windows.Forms.RadioButton();
            this.Majuscules = new System.Windows.Forms.RadioButton();
            this.Casse = new System.Windows.Forms.GroupBox();
            this.Minuscules = new System.Windows.Forms.RadioButton();
            this.Choix = new System.Windows.Forms.GroupBox();
            this.checkCasse = new System.Windows.Forms.CheckBox();
            this.CouleurDesCaracteres = new System.Windows.Forms.CheckBox();
            this.CouleurDuFond = new System.Windows.Forms.CheckBox();
            this.Resultat = new System.Windows.Forms.Label();
            this.Fond.SuspendLayout();
            this.caracteres.SuspendLayout();
            this.Casse.SuspendLayout();
            this.Choix.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tapez votre texte";
           
            // 
            // textSaisi
            // 
            this.textSaisi.Location = new System.Drawing.Point(16, 29);
            this.textSaisi.Name = "textSaisi";
            this.textSaisi.Size = new System.Drawing.Size(236, 20);
            this.textSaisi.TabIndex = 1;
            this.textSaisi.TextChanged += new System.EventHandler(this.textSaisi_TextChanged);
            // 
            // Fond
            // 
            this.Fond.Controls.Add(this.Bleu);
            this.Fond.Controls.Add(this.Vert);
            this.Fond.Controls.Add(this.Rouge);
            this.Fond.Location = new System.Drawing.Point(16, 136);
            this.Fond.Name = "Fond";
            this.Fond.Size = new System.Drawing.Size(110, 99);
            this.Fond.TabIndex = 2;
            this.Fond.TabStop = false;
            this.Fond.Text = "Fond";
            // 
            // Bleu
            // 
            this.Bleu.AutoSize = true;
            this.Bleu.Location = new System.Drawing.Point(7, 68);
            this.Bleu.Name = "Bleu";
            this.Bleu.Size = new System.Drawing.Size(46, 17);
            this.Bleu.TabIndex = 2;
            this.Bleu.TabStop = true;
            this.Bleu.Text = "Bleu";
            this.Bleu.UseVisualStyleBackColor = true;
            this.Bleu.CheckedChanged += new System.EventHandler(this.Bleu_CheckedChanged);
            // 
            // Vert
            // 
            this.Vert.AutoSize = true;
            this.Vert.Location = new System.Drawing.Point(7, 44);
            this.Vert.Name = "Vert";
            this.Vert.Size = new System.Drawing.Size(44, 17);
            this.Vert.TabIndex = 1;
            this.Vert.TabStop = true;
            this.Vert.Text = "Vert";
            this.Vert.UseVisualStyleBackColor = true;
            this.Vert.CheckedChanged += new System.EventHandler(this.Vert_CheckedChanged);
            // 
            // Rouge
            // 
            this.Rouge.AutoSize = true;
            this.Rouge.Location = new System.Drawing.Point(7, 20);
            this.Rouge.Name = "Rouge";
            this.Rouge.Size = new System.Drawing.Size(57, 17);
            this.Rouge.TabIndex = 0;
            this.Rouge.TabStop = true;
            this.Rouge.Text = "Rouge";
            this.Rouge.UseVisualStyleBackColor = true;
            this.Rouge.CheckedChanged += new System.EventHandler(this.Rouge_CheckedChanged);
            // 
            // caracteres
            // 
            this.caracteres.Controls.Add(this.Noir);
            this.caracteres.Controls.Add(this.Blanc);
            this.caracteres.Controls.Add(this.Rouge2);
            this.caracteres.Location = new System.Drawing.Point(142, 136);
            this.caracteres.Name = "caracteres";
            this.caracteres.Size = new System.Drawing.Size(110, 99);
            this.caracteres.TabIndex = 3;
            this.caracteres.TabStop = false;
            this.caracteres.Text = "Caractère";
            // 
            // Noir
            // 
            this.Noir.AutoSize = true;
            this.Noir.Location = new System.Drawing.Point(7, 68);
            this.Noir.Name = "Noir";
            this.Noir.Size = new System.Drawing.Size(44, 17);
            this.Noir.TabIndex = 2;
            this.Noir.TabStop = true;
            this.Noir.Text = "Noir";
            this.Noir.UseVisualStyleBackColor = true;
            this.Noir.CheckedChanged += new System.EventHandler(this.Noir_CheckedChanged);
            // 
            // Blanc
            // 
            this.Blanc.AutoSize = true;
            this.Blanc.Location = new System.Drawing.Point(7, 44);
            this.Blanc.Name = "Blanc";
            this.Blanc.Size = new System.Drawing.Size(52, 17);
            this.Blanc.TabIndex = 1;
            this.Blanc.TabStop = true;
            this.Blanc.Text = "Blanc";
            this.Blanc.UseVisualStyleBackColor = true;
            this.Blanc.CheckedChanged += new System.EventHandler(this.Blanc_CheckedChanged);
            // 
            // Rouge2
            // 
            this.Rouge2.AutoSize = true;
            this.Rouge2.Location = new System.Drawing.Point(6, 21);
            this.Rouge2.Name = "Rouge2";
            this.Rouge2.Size = new System.Drawing.Size(57, 17);
            this.Rouge2.TabIndex = 0;
            this.Rouge2.TabStop = true;
            this.Rouge2.Text = "Rouge";
            this.Rouge2.UseVisualStyleBackColor = true;
            this.Rouge2.CheckedChanged += new System.EventHandler(this.Rouge2_CheckedChanged);
            // 
            // Majuscules
            // 
            this.Majuscules.AutoSize = true;
            this.Majuscules.Location = new System.Drawing.Point(7, 44);
            this.Majuscules.Name = "Majuscules";
            this.Majuscules.Size = new System.Drawing.Size(78, 17);
            this.Majuscules.TabIndex = 1;
            this.Majuscules.TabStop = true;
            this.Majuscules.Text = "Majuscules";
            this.Majuscules.UseVisualStyleBackColor = true;
            this.Majuscules.CheckedChanged += new System.EventHandler(this.Majuscules_CheckedChanged);
            // 
            // Casse
            // 
            this.Casse.Controls.Add(this.Majuscules);
            this.Casse.Controls.Add(this.Minuscules);
            this.Casse.Location = new System.Drawing.Point(275, 157);
            this.Casse.Name = "Casse";
            this.Casse.Size = new System.Drawing.Size(110, 78);
            this.Casse.TabIndex = 4;
            this.Casse.TabStop = false;
            this.Casse.Text = "Casse";
            // 
            // Minuscules
            // 
            this.Minuscules.AutoSize = true;
            this.Minuscules.Location = new System.Drawing.Point(6, 21);
            this.Minuscules.Name = "Minuscules";
            this.Minuscules.Size = new System.Drawing.Size(78, 17);
            this.Minuscules.TabIndex = 0;
            this.Minuscules.TabStop = true;
            this.Minuscules.Text = "Minuscules";
            this.Minuscules.UseVisualStyleBackColor = true;
            this.Minuscules.CheckedChanged += new System.EventHandler(this.Minuscules_CheckedChanged);
            // 
            // Choix
            // 
            this.Choix.Controls.Add(this.checkCasse);
            this.Choix.Controls.Add(this.CouleurDesCaracteres);
            this.Choix.Controls.Add(this.CouleurDuFond);
            this.Choix.Location = new System.Drawing.Point(275, 29);
            this.Choix.Name = "Choix";
            this.Choix.Size = new System.Drawing.Size(167, 100);
            this.Choix.TabIndex = 5;
            this.Choix.TabStop = false;
            this.Choix.Text = "Choix";
            // 
            // checkCasse
            // 
            this.checkCasse.AutoSize = true;
            this.checkCasse.Location = new System.Drawing.Point(7, 68);
            this.checkCasse.Name = "checkCasse";
            this.checkCasse.Size = new System.Drawing.Size(55, 17);
            this.checkCasse.TabIndex = 2;
            this.checkCasse.Text = "Casse";
            this.checkCasse.UseVisualStyleBackColor = true;
            this.checkCasse.CheckedChanged += new System.EventHandler(this.checkCasse_CheckedChanged);
            // 
            // CouleurDesCaracteres
            // 
            this.CouleurDesCaracteres.AutoSize = true;
            this.CouleurDesCaracteres.Location = new System.Drawing.Point(7, 44);
            this.CouleurDesCaracteres.Name = "CouleurDesCaracteres";
            this.CouleurDesCaracteres.Size = new System.Drawing.Size(135, 17);
            this.CouleurDesCaracteres.TabIndex = 1;
            this.CouleurDesCaracteres.Text = "Couleur des caractères";
            this.CouleurDesCaracteres.UseVisualStyleBackColor = true;
            this.CouleurDesCaracteres.CheckedChanged += new System.EventHandler(this.CouleurDesCaracteres_CheckedChanged);
            // 
            // CouleurDuFond
            // 
            this.CouleurDuFond.AutoSize = true;
            this.CouleurDuFond.Location = new System.Drawing.Point(7, 20);
            this.CouleurDuFond.Name = "CouleurDuFond";
            this.CouleurDuFond.Size = new System.Drawing.Size(101, 17);
            this.CouleurDuFond.TabIndex = 0;
            this.CouleurDuFond.Text = "Couleur du fond";
            this.CouleurDuFond.UseVisualStyleBackColor = true;
            this.CouleurDuFond.CheckedChanged += new System.EventHandler(this.CouleurDuFond_CheckedChanged);
            // 
            // Resultat
            // 
            this.Resultat.AutoSize = true;
            this.Resultat.BackColor = System.Drawing.SystemColors.Control;
            this.Resultat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Resultat.Location = new System.Drawing.Point(13, 73);
            this.Resultat.Name = "Resultat";
            this.Resultat.Size = new System.Drawing.Size(0, 13);
            this.Resultat.TabIndex = 6;
           
            // 
            // CheckBoxEtRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 254);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.Choix);
            this.Controls.Add(this.Casse);
            this.Controls.Add(this.caracteres);
            this.Controls.Add(this.Fond);
            this.Controls.Add(this.textSaisi);
            this.Controls.Add(this.label1);
            this.Name = "CheckBoxEtRadioButton";
            this.ShowIcon = false;
            this.Text = "CheckBox et RadioButton";
            
            this.Fond.ResumeLayout(false);
            this.Fond.PerformLayout();
            this.caracteres.ResumeLayout(false);
            this.caracteres.PerformLayout();
            this.Casse.ResumeLayout(false);
            this.Casse.PerformLayout();
            this.Choix.ResumeLayout(false);
            this.Choix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSaisi;
        private System.Windows.Forms.GroupBox Fond;
        private System.Windows.Forms.RadioButton Bleu;
        private System.Windows.Forms.RadioButton Vert;
        private System.Windows.Forms.RadioButton Rouge;
        private System.Windows.Forms.GroupBox caracteres;
        private System.Windows.Forms.RadioButton Noir;
        private System.Windows.Forms.RadioButton Blanc;
        private System.Windows.Forms.RadioButton Rouge2;
        private System.Windows.Forms.RadioButton Majuscules;
        private System.Windows.Forms.GroupBox Casse;
        private System.Windows.Forms.RadioButton Minuscules;
        private System.Windows.Forms.GroupBox Choix;
        private System.Windows.Forms.CheckBox checkCasse;
        private System.Windows.Forms.CheckBox CouleurDesCaracteres;
        private System.Windows.Forms.CheckBox CouleurDuFond;
        private System.Windows.Forms.Label Resultat;
    }
}

