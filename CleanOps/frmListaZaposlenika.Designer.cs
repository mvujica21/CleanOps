namespace CleanOps {
    partial class frmListaZaposlenika {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.btnUkloniZaposlenika = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPretrazi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.GridColor = System.Drawing.Color.Linen;
            this.dgvZaposlenici.Location = new System.Drawing.Point(12, 61);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.RowHeadersWidth = 51;
            this.dgvZaposlenici.RowTemplate.Height = 24;
            this.dgvZaposlenici.Size = new System.Drawing.Size(776, 282);
            this.dgvZaposlenici.TabIndex = 0;
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.BackColor = System.Drawing.Color.Azure;
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(637, 363);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(151, 56);
            this.btnDodajZaposlenika.TabIndex = 1;
            this.btnDodajZaposlenika.Text = "Dodaj zaposlenika";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = false;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            // 
            // btnUkloniZaposlenika
            // 
            this.btnUkloniZaposlenika.BackColor = System.Drawing.Color.Azure;
            this.btnUkloniZaposlenika.Location = new System.Drawing.Point(326, 363);
            this.btnUkloniZaposlenika.Name = "btnUkloniZaposlenika";
            this.btnUkloniZaposlenika.Size = new System.Drawing.Size(151, 56);
            this.btnUkloniZaposlenika.TabIndex = 2;
            this.btnUkloniZaposlenika.Text = "Ukloni zaposlenika";
            this.btnUkloniZaposlenika.UseVisualStyleBackColor = false;
            this.btnUkloniZaposlenika.Click += new System.EventHandler(this.btnUkloniZaposlenika_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.Azure;
            this.btnAzuriraj.Location = new System.Drawing.Point(12, 363);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(151, 56);
            this.btnAzuriraj.TabIndex = 3;
            this.btnAzuriraj.Text = "Ažuriraj zaposlenika";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Location = new System.Drawing.Point(11, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(161, 22);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Azure;
            this.btnSearch.Location = new System.Drawing.Point(178, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.Location = new System.Drawing.Point(9, 10);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(186, 16);
            this.lblPretrazi.TabIndex = 6;
            this.lblPretrazi.Text = "Pretrazi zaposlenika po imenu";
            // 
            // frmListaZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnUkloniZaposlenika);
            this.Controls.Add(this.btnDodajZaposlenika);
            this.Controls.Add(this.dgvZaposlenici);
            this.Name = "frmListaZaposlenika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.Button btnUkloniZaposlenika;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPretrazi;

    }
}

