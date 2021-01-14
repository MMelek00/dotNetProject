namespace GestionCommandes
{
    partial class AjoutProduit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNewProduit1 = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridProduit = new System.Windows.Forms.DataGridView();
            this.NumProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnNewProduit1);
            this.panel2.Controls.Add(this.btnSupprimer);
            this.panel2.Controls.Add(this.btnAnnuler);
            this.panel2.Controls.Add(this.btnValider);
            this.panel2.Location = new System.Drawing.Point(648, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 279);
            this.panel2.TabIndex = 56;
            // 
            // btnNewProduit1
            // 
            this.btnNewProduit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.btnNewProduit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProduit1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewProduit1.Location = new System.Drawing.Point(24, 145);
            this.btnNewProduit1.Name = "btnNewProduit1";
            this.btnNewProduit1.Size = new System.Drawing.Size(110, 51);
            this.btnNewProduit1.TabIndex = 56;
            this.btnNewProduit1.Text = "Produit inexistant";
            this.btnNewProduit1.UseVisualStyleBackColor = false;
            this.btnNewProduit1.Click += new System.EventHandler(this.btnNewProduit1_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupprimer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSupprimer.Location = new System.Drawing.Point(24, 201);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(111, 54);
            this.btnSupprimer.TabIndex = 55;
            this.btnSupprimer.Text = "Supprimer Produit";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnuler.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAnnuler.Location = new System.Drawing.Point(24, 91);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(110, 49);
            this.btnAnnuler.TabIndex = 53;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnValider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnValider.Location = new System.Drawing.Point(24, 34);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(110, 46);
            this.btnValider.TabIndex = 52;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDesignation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 116);
            this.panel1.TabIndex = 55;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(110, 62);
            this.txtDesignation.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(76, 20);
            this.txtDesignation.TabIndex = 49;
            this.txtDesignation.TextChanged += new System.EventHandler(this.txtDesignation_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Désignation";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 39);
            this.label1.TabIndex = 47;
            this.label1.Text = "Recherche de produit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gridProduit
            // 
            this.gridProduit.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProduit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumProduit,
            this.Produit,
            this.Designation});
            this.gridProduit.Location = new System.Drawing.Point(208, 40);
            this.gridProduit.Margin = new System.Windows.Forms.Padding(2);
            this.gridProduit.Name = "gridProduit";
            this.gridProduit.RowHeadersWidth = 51;
            this.gridProduit.RowTemplate.Height = 24;
            this.gridProduit.Size = new System.Drawing.Size(436, 388);
            this.gridProduit.TabIndex = 54;
            this.gridProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProduit_CellContentClick);
            // 
            // NumProduit
            // 
            this.NumProduit.HeaderText = "Code Produit";
            this.NumProduit.MinimumWidth = 6;
            this.NumProduit.Name = "NumProduit";
            this.NumProduit.Width = 140;
            // 
            // Produit
            // 
            this.Produit.HeaderText = "Produit";
            this.Produit.MinimumWidth = 6;
            this.Produit.Name = "Produit";
            this.Produit.Width = 140;
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Type Produit";
            this.Designation.MinimumWidth = 6;
            this.Designation.Name = "Designation";
            this.Designation.Width = 140;
            // 
            // AjoutProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridProduit);
            this.Name = "AjoutProduit";
            this.Text = "AjoutProduit";
            this.Load += new System.EventHandler(this.AjoutProduit_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridProduit;
        private System.Windows.Forms.Button btnNewProduit1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
    }
}