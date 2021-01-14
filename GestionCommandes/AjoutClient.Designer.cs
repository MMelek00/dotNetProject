namespace GestionCommandes
{
    partial class ClientAdd
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
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.gridClient = new System.Windows.Forms.DataGridView();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.btnSupprimer.CausesValidation = false;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSupprimer.Location = new System.Drawing.Point(700, 270);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(89, 48);
            this.btnSupprimer.TabIndex = 51;
            this.btnSupprimer.Text = "Supprimer Client";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.comboBox1.Location = new System.Drawing.Point(103, 335);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 21);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(103, 288);
            this.txtCodePostal.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(76, 20);
            this.txtCodePostal.TabIndex = 49;
            this.txtCodePostal.TextChanged += new System.EventHandler(this.txtCodePostal_TextChanged);
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(86, 233);
            this.txtVille.Margin = new System.Windows.Forms.Padding(2);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(93, 20);
            this.txtVille.TabIndex = 48;
            this.txtVille.TextChanged += new System.EventHandler(this.txtVille_TextChanged);
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(86, 194);
            this.txtRue.Margin = new System.Windows.Forms.Padding(2);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(93, 20);
            this.txtRue.TabIndex = 47;
            this.txtRue.TextChanged += new System.EventHandler(this.txtRue_TextChanged);
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(86, 152);
            this.txtClient.Margin = new System.Windows.Forms.Padding(2);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(93, 20);
            this.txtClient.TabIndex = 46;
            this.txtClient.TextChanged += new System.EventHandler(this.txtClient_TextChanged);
            // 
            // btnNewClient
            // 
            this.btnNewClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.btnNewClient.CausesValidation = false;
            this.btnNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewClient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewClient.Location = new System.Drawing.Point(700, 211);
            this.btnNewClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(89, 50);
            this.btnNewClient.TabIndex = 45;
            this.btnNewClient.Text = "Client inexistant";
            this.btnNewClient.UseVisualStyleBackColor = false;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.btnAnnuler.CausesValidation = false;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnuler.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAnnuler.Location = new System.Drawing.Point(700, 152);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(89, 44);
            this.btnAnnuler.TabIndex = 44;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.btnValider.CausesValidation = false;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnValider.Location = new System.Drawing.Point(700, 89);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(89, 47);
            this.btnValider.TabIndex = 43;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // gridClient
            // 
            this.gridClient.AllowUserToAddRows = false;
            this.gridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClient,
            this.NomClient,
            this.Rue,
            this.Ville,
            this.CP,
            this.Tel});
            this.gridClient.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridClient.Location = new System.Drawing.Point(203, 44);
            this.gridClient.Margin = new System.Windows.Forms.Padding(2);
            this.gridClient.Name = "gridClient";
            this.gridClient.RowHeadersWidth = 51;
            this.gridClient.RowTemplate.Height = 24;
            this.gridClient.Size = new System.Drawing.Size(481, 371);
            this.gridClient.TabIndex = 42;
            this.gridClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClient_CellContentClick);
            // 
            // idClient
            // 
            this.idClient.HeaderText = "idClient";
            this.idClient.Name = "idClient";
            this.idClient.Visible = false;
            // 
            // NomClient
            // 
            this.NomClient.HeaderText = "Client";
            this.NomClient.MinimumWidth = 6;
            this.NomClient.Name = "NomClient";
            this.NomClient.Width = 80;
            // 
            // Rue
            // 
            this.Rue.HeaderText = "Rue";
            this.Rue.MinimumWidth = 6;
            this.Rue.Name = "Rue";
            this.Rue.Width = 80;
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.MinimumWidth = 6;
            this.Ville.Name = "Ville";
            this.Ville.Width = 80;
            // 
            // CP
            // 
            this.CP.HeaderText = "Code Postal";
            this.CP.MinimumWidth = 6;
            this.CP.Name = "CP";
            this.CP.Width = 125;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Téléphone";
            this.Tel.MinimumWidth = 6;
            this.Tel.Name = "Tel";
            this.Tel.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(11, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "Rue";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(11, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Ville";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(11, 335);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Operateur";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(11, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Code Postal";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(11, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Client";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(11, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 40);
            this.label1.TabIndex = 36;
            this.label1.Text = "Recherche de Client";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtRue);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.gridClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientAdd";
            this.Text = "ClientAdd";
            this.Load += new System.EventHandler(this.ClientAdd_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gridClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DataGridView gridClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
    }
}