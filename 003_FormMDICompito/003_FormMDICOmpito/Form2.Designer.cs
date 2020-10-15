namespace _003_FormMDICOmpito
{
    partial class Form2
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
            this.btnLeggiValore = new System.Windows.Forms.Button();
            this.btnFormFiglia = new System.Windows.Forms.Button();
            this.btnInviaF1 = new System.Windows.Forms.Button();
            this.txtForm2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLeggiValore
            // 
            this.btnLeggiValore.Location = new System.Drawing.Point(27, 13);
            this.btnLeggiValore.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeggiValore.Name = "btnLeggiValore";
            this.btnLeggiValore.Size = new System.Drawing.Size(100, 28);
            this.btnLeggiValore.TabIndex = 1;
            this.btnLeggiValore.Text = "Leggi valore";
            this.btnLeggiValore.UseVisualStyleBackColor = true;
            this.btnLeggiValore.Click += new System.EventHandler(this.btnLeggiValore_Click);
            // 
            // btnFormFiglia
            // 
            this.btnFormFiglia.Location = new System.Drawing.Point(27, 116);
            this.btnFormFiglia.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormFiglia.Name = "btnFormFiglia";
            this.btnFormFiglia.Size = new System.Drawing.Size(133, 28);
            this.btnFormFiglia.TabIndex = 6;
            this.btnFormFiglia.Text = "Apri Form Figlia";
            this.btnFormFiglia.UseVisualStyleBackColor = true;
            this.btnFormFiglia.Click += new System.EventHandler(this.btnFormFiglia_Click);
            // 
            // btnInviaF1
            // 
            this.btnInviaF1.Location = new System.Drawing.Point(168, 71);
            this.btnInviaF1.Margin = new System.Windows.Forms.Padding(4);
            this.btnInviaF1.Name = "btnInviaF1";
            this.btnInviaF1.Size = new System.Drawing.Size(100, 28);
            this.btnInviaF1.TabIndex = 5;
            this.btnInviaF1.Text = "Invia a Form 1";
            this.btnInviaF1.UseVisualStyleBackColor = true;
            this.btnInviaF1.Click += new System.EventHandler(this.btnInviaF1_Click);
            // 
            // txtForm2
            // 
            this.txtForm2.Location = new System.Drawing.Point(27, 71);
            this.txtForm2.Margin = new System.Windows.Forms.Padding(4);
            this.txtForm2.Name = "txtForm2";
            this.txtForm2.Size = new System.Drawing.Size(132, 22);
            this.txtForm2.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 267);
            this.Controls.Add(this.btnFormFiglia);
            this.Controls.Add(this.btnInviaF1);
            this.Controls.Add(this.txtForm2);
            this.Controls.Add(this.btnLeggiValore);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeggiValore;
        private System.Windows.Forms.Button btnFormFiglia;
        private System.Windows.Forms.Button btnInviaF1;
        private System.Windows.Forms.TextBox txtForm2;
    }
}