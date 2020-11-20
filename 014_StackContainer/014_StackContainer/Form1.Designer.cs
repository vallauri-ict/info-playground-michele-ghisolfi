namespace _014_StackContainer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTara = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnEstrai = new System.Windows.Forms.Button();
            this.lblCodice = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblTara = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tara";
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(106, 70);
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(100, 22);
            this.txtTara.TabIndex = 1;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(106, 113);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 22);
            this.txtPeso.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peso";
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(106, 30);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 22);
            this.txtCodice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codice";
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(43, 159);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(163, 29);
            this.btnInserisci.TabIndex = 6;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnEstrai
            // 
            this.btnEstrai.Location = new System.Drawing.Point(316, 33);
            this.btnEstrai.Name = "btnEstrai";
            this.btnEstrai.Size = new System.Drawing.Size(163, 29);
            this.btnEstrai.TabIndex = 7;
            this.btnEstrai.Text = "Estrai";
            this.btnEstrai.UseVisualStyleBackColor = true;
            this.btnEstrai.Click += new System.EventHandler(this.btnEstrai_Click);
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodice.Location = new System.Drawing.Point(313, 80);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(93, 31);
            this.lblCodice.TabIndex = 10;
            this.lblCodice.Text = "Codice";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(313, 147);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(57, 25);
            this.lblPeso.TabIndex = 9;
            this.lblPeso.Text = "Peso";
            // 
            // lblTara
            // 
            this.lblTara.AutoSize = true;
            this.lblTara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTara.Location = new System.Drawing.Point(313, 113);
            this.lblTara.Name = "lblTara";
            this.lblTara.Size = new System.Drawing.Size(53, 25);
            this.lblTara.TabIndex = 8;
            this.lblTara.Text = "Tara";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 226);
            this.Controls.Add(this.lblCodice);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblTara);
            this.Controls.Add(this.btnEstrai);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTara);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnEstrai;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblTara;
    }
}

