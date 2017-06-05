namespace appDB
{
    partial class frmDB
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCmd = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnCancella = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCmd
            // 
            this.txtCmd.Location = new System.Drawing.Point(13, 45);
            this.txtCmd.Multiline = true;
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.Size = new System.Drawing.Size(407, 72);
            this.txtCmd.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(426, 94);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(426, 17);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(88, 23);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "Scegli File";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnCancella
            // 
            this.btnCancella.Location = new System.Drawing.Point(520, 94);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(88, 23);
            this.btnCancella.TabIndex = 3;
            this.btnCancella.Text = "Cancella";
            this.btnCancella.UseVisualStyleBackColor = true;
            this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(13, 19);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(407, 20);
            this.txtPath.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 380);
            this.dataGridView1.TabIndex = 5;
            // 
            // frmDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnCancella);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCmd);
            this.Name = "frmDB";
            this.Text = "Data Base";
            this.Load += new System.EventHandler(this.frmDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCmd;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnCancella;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

