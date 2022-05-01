namespace WindowsFormsApplication1
{
    partial class DialogueForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.TBordi = new System.Windows.Forms.TextBox();
            this.TBclient = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Satisfaction = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(576, 106);
            this.button1.TabIndex = 2;
            this.button1.Text = "Validez ici ou appuyez sur la touche entrée";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBordi
            // 
            this.TBordi.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.TBordi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBordi.BackColor = System.Drawing.SystemColors.Menu;
            this.TBordi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBordi.Location = new System.Drawing.Point(600, 12);
            this.TBordi.Multiline = true;
            this.TBordi.Name = "TBordi";
            this.TBordi.ReadOnly = true;
            this.TBordi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBordi.Size = new System.Drawing.Size(588, 654);
            this.TBordi.TabIndex = 1;
            // 
            // TBclient
            // 
            this.TBclient.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TBclient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBclient.ForeColor = System.Drawing.Color.AliceBlue;
            this.TBclient.Location = new System.Drawing.Point(18, 12);
            this.TBclient.Multiline = true;
            this.TBclient.Name = "TBclient";
            this.TBclient.Size = new System.Drawing.Size(576, 400);
            this.TBclient.TabIndex = 0;
            this.TBclient.Text = "Tapez votre texte ici pour communiquer avec moi. puis appuyez sur ENTREE";
            this.toolTip1.SetToolTip(this.TBclient, "TAPEZ VOTRE TEXTE ICI PUIS APPUYEZ SUR ENTREE");
            this.TBclient.TextChanged += new System.EventHandler(this.TBclient_TextChanged);
            this.TBclient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBclient_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(417, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 78);
            this.button2.TabIndex = 3;
            this.button2.Text = "Signaler un problème";
            this.toolTip1.SetToolTip(this.button2, "SI VOUS APPUYEZ ICI VOTRE CONVERSATION SERA ENREGISTREE \r\nNOUS POURRONS ALORS FAI" +
        "RE EVOLUER BIH POUR QU IL SOIT MOINS STUPIDE\r\nMERCI");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Satisfaction
            // 
            this.Satisfaction.BackColor = System.Drawing.Color.Transparent;
            this.Satisfaction.Location = new System.Drawing.Point(451, 12);
            this.Satisfaction.Name = "Satisfaction";
            this.Satisfaction.Size = new System.Drawing.Size(143, 97);
            this.Satisfaction.TabIndex = 5;
            this.Satisfaction.Text = "Satisfaction";
            this.Satisfaction.UseVisualStyleBackColor = false;
            this.Satisfaction.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.BorderSize = 5;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(54, 418);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(135, 97);
            this.button3.TabIndex = 6;
            this.button3.Text = "oui";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GrayText;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(241, 443);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 65);
            this.button4.TabIndex = 7;
            this.button4.Text = "non";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // DialogueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 674);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Satisfaction);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TBclient);
            this.Controls.Add(this.TBordi);
            this.Controls.Add(this.button1);
            this.Name = "DialogueForm";
            this.Text = "BIH240 Voyant niveau amateur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBclient;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TBordi;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Satisfaction;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer2;
    }
}

