namespace _005_OOP01
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreaRettangolo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base: ";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(142, 40);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 22);
            this.txtBase.TabIndex = 1;
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(142, 91);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(100, 22);
            this.txtAltezza.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altezza:";
            // 
            // btnCreaRettangolo
            // 
            this.btnCreaRettangolo.Location = new System.Drawing.Point(74, 140);
            this.btnCreaRettangolo.Name = "btnCreaRettangolo";
            this.btnCreaRettangolo.Size = new System.Drawing.Size(168, 23);
            this.btnCreaRettangolo.TabIndex = 4;
            this.btnCreaRettangolo.Text = "Crea";
            this.btnCreaRettangolo.UseVisualStyleBackColor = true;
            this.btnCreaRettangolo.Click += new System.EventHandler(this.btnCreaRettangolo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 199);
            this.Controls.Add(this.btnCreaRettangolo);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreaRettangolo;
    }
}

