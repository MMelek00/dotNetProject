namespace GestionCommandes
{
    partial class AjoutProduit2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TPBox = new System.Windows.Forms.ComboBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtCodeProduit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAnnuler);
            this.panel2.Controls.Add(this.btnValider);
            this.panel2.Location = new System.Drawing.Point(11, 116);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 42);
            this.panel2.TabIndex = 11;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnuler.Location = new System.Drawing.Point(243, 3);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(91, 34);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnValider.Location = new System.Drawing.Point(141, 2);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(97, 36);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TPBox);
            this.panel1.Controls.Add(this.txtDesignation);
            this.panel1.Controls.Add(this.txtCodeProduit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 99);
            this.panel1.TabIndex = 10;
            // 
            // TPBox
            // 
            this.TPBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TPBox.FormattingEnabled = true;
            this.TPBox.Items.AddRange(new object[] {
            "Imprimante",
            "PC",
            "Scanner",
            "Ecran",
            "Camera",
            "Microphone",
            "Accessoires"});
            this.TPBox.Location = new System.Drawing.Point(130, 66);
            this.TPBox.Margin = new System.Windows.Forms.Padding(2);
            this.TPBox.Name = "TPBox";
            this.TPBox.Size = new System.Drawing.Size(195, 21);
            this.TPBox.TabIndex = 34;
            this.TPBox.SelectedIndexChanged += new System.EventHandler(this.TPBox_SelectedIndexChanged);
            // 
            // txtDesignation
            // 
            this.txtDesignation.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDesignation.Location = new System.Drawing.Point(130, 39);
            this.txtDesignation.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(195, 20);
            this.txtDesignation.TabIndex = 8;
            // 
            // txtCodeProduit
            // 
            this.txtCodeProduit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCodeProduit.Location = new System.Drawing.Point(130, 15);
            this.txtCodeProduit.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodeProduit.Name = "txtCodeProduit";
            this.txtCodeProduit.Size = new System.Drawing.Size(52, 20);
            this.txtCodeProduit.TabIndex = 6;
            this.txtCodeProduit.TextChanged += new System.EventHandler(this.txtCodeProduit_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type de produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Désignation";
            // 
            // AjoutProduit2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(389, 182);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AjoutProduit2";
            this.Text = "AjoutProduit2";
            this.Load += new System.EventHandler(this.AjoutProduit2_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox TPBox;
        public System.Windows.Forms.TextBox txtDesignation;
        public System.Windows.Forms.TextBox txtCodeProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnnuler;
    }
}