namespace Multiform01
{
    partial class Form1
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
            this.btnAproF2 = new System.Windows.Forms.Button();
            this.btnApriF2b = new System.Windows.Forms.Button();
            this.txtPassata = new System.Windows.Forms.TextBox();
            this.btnPassaTxt = new System.Windows.Forms.Button();
            this.btnFormModale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeFM = new System.Windows.Forms.TextBox();
            this.txtEtaFM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAproF2
            // 
            this.btnAproF2.Location = new System.Drawing.Point(47, 24);
            this.btnAproF2.Name = "btnAproF2";
            this.btnAproF2.Size = new System.Drawing.Size(75, 23);
            this.btnAproF2.TabIndex = 0;
            this.btnAproF2.Text = "Apri Form 2";
            this.btnAproF2.UseVisualStyleBackColor = true;
            this.btnAproF2.Click += new System.EventHandler(this.btnApriF2_Click);
            // 
            // btnApriF2b
            // 
            this.btnApriF2b.Location = new System.Drawing.Point(166, 24);
            this.btnApriF2b.Name = "btnApriF2b";
            this.btnApriF2b.Size = new System.Drawing.Size(75, 23);
            this.btnApriF2b.TabIndex = 1;
            this.btnApriF2b.Text = "Apri Form 2b";
            this.btnApriF2b.UseVisualStyleBackColor = true;
            this.btnApriF2b.Click += new System.EventHandler(this.btnApriF2b_Click);
            // 
            // txtPassata
            // 
            this.txtPassata.Location = new System.Drawing.Point(47, 67);
            this.txtPassata.Name = "txtPassata";
            this.txtPassata.Size = new System.Drawing.Size(100, 20);
            this.txtPassata.TabIndex = 2;
            // 
            // btnPassaTxt
            // 
            this.btnPassaTxt.Location = new System.Drawing.Point(153, 67);
            this.btnPassaTxt.Name = "btnPassaTxt";
            this.btnPassaTxt.Size = new System.Drawing.Size(121, 23);
            this.btnPassaTxt.TabIndex = 3;
            this.btnPassaTxt.Text = "Passa TXT a F2";
            this.btnPassaTxt.UseVisualStyleBackColor = true;
            this.btnPassaTxt.Click += new System.EventHandler(this.btnPassaTxt_Click);
            // 
            // btnFormModale
            // 
            this.btnFormModale.Location = new System.Drawing.Point(47, 133);
            this.btnFormModale.Name = "btnFormModale";
            this.btnFormModale.Size = new System.Drawing.Size(116, 23);
            this.btnFormModale.TabIndex = 4;
            this.btnFormModale.Text = "Apri Form Modale";
            this.btnFormModale.UseVisualStyleBackColor = true;
            this.btnFormModale.Click += new System.EventHandler(this.btnFormModale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // txtNomeFM
            // 
            this.txtNomeFM.Location = new System.Drawing.Point(85, 96);
            this.txtNomeFM.Name = "txtNomeFM";
            this.txtNomeFM.ReadOnly = true;
            this.txtNomeFM.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFM.TabIndex = 7;
            // 
            // txtEtaFM
            // 
            this.txtEtaFM.Location = new System.Drawing.Point(274, 96);
            this.txtEtaFM.Name = "txtEtaFM";
            this.txtEtaFM.ReadOnly = true;
            this.txtEtaFM.Size = new System.Drawing.Size(100, 20);
            this.txtEtaFM.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Età";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 243);
            this.Controls.Add(this.txtEtaFM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeFM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFormModale);
            this.Controls.Add(this.btnPassaTxt);
            this.Controls.Add(this.txtPassata);
            this.Controls.Add(this.btnApriF2b);
            this.Controls.Add(this.btnAproF2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAproF2;
        private System.Windows.Forms.Button btnApriF2b;
        private System.Windows.Forms.TextBox txtPassata;
        private System.Windows.Forms.Button btnPassaTxt;
        private System.Windows.Forms.Button btnFormModale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeFM;
        private System.Windows.Forms.TextBox txtEtaFM;
        private System.Windows.Forms.Label label2;
    }
}

