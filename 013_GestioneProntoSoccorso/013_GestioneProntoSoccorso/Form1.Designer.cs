namespace _013_GestioneProntoSoccorso
{
    partial class Form1
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
            this.Nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbColore = new System.Windows.Forms.ComboBox();
            this.btnRegistra = new System.Windows.Forms.Button();
            this.btnInfermiere = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUltimoPazienteVisitato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(57, 33);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(49, 17);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(136, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 1;
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(136, 67);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 22);
            this.txtEta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Età:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Colore";
            // 
            // cmbColore
            // 
            this.cmbColore.FormattingEnabled = true;
            this.cmbColore.Items.AddRange(new object[] {
            "Rosso",
            "Giallo",
            "Verde",
            "Bianco"});
            this.cmbColore.Location = new System.Drawing.Point(136, 109);
            this.cmbColore.Name = "cmbColore";
            this.cmbColore.Size = new System.Drawing.Size(100, 24);
            this.cmbColore.TabIndex = 5;
            // 
            // btnRegistra
            // 
            this.btnRegistra.Location = new System.Drawing.Point(60, 163);
            this.btnRegistra.Name = "btnRegistra";
            this.btnRegistra.Size = new System.Drawing.Size(176, 27);
            this.btnRegistra.TabIndex = 6;
            this.btnRegistra.Text = "Registra";
            this.btnRegistra.UseVisualStyleBackColor = true;
            this.btnRegistra.Click += new System.EventHandler(this.btnRegistra_Click);
            // 
            // btnInfermiere
            // 
            this.btnInfermiere.Location = new System.Drawing.Point(358, 58);
            this.btnInfermiere.Name = "btnInfermiere";
            this.btnInfermiere.Size = new System.Drawing.Size(125, 125);
            this.btnInfermiere.TabIndex = 7;
            this.btnInfermiere.Text = "LIBERA INFERMIERE";
            this.btnInfermiere.UseVisualStyleBackColor = true;
            this.btnInfermiere.Click += new System.EventHandler(this.btnInfermiere_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ulimo pazoente visitato: ";
            // 
            // lblUltimoPazienteVisitato
            // 
            this.lblUltimoPazienteVisitato.AutoSize = true;
            this.lblUltimoPazienteVisitato.Location = new System.Drawing.Point(201, 223);
            this.lblUltimoPazienteVisitato.Name = "lblUltimoPazienteVisitato";
            this.lblUltimoPazienteVisitato.Size = new System.Drawing.Size(0, 21);
            this.lblUltimoPazienteVisitato.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 271);
            this.Controls.Add(this.lblUltimoPazienteVisitato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInfermiere);
            this.Controls.Add(this.btnRegistra);
            this.Controls.Add(this.cmbColore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbColore;
        private System.Windows.Forms.Button btnRegistra;
        private System.Windows.Forms.Button btnInfermiere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUltimoPazienteVisitato;
    }
}

