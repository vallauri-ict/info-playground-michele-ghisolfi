namespace _008_Singleton_Queue
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
            this.txtPush = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPull = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPush
            // 
            this.txtPush.Location = new System.Drawing.Point(26, 33);
            this.txtPush.Name = "txtPush";
            this.txtPush.Size = new System.Drawing.Size(118, 20);
            this.txtPush.TabIndex = 0;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(150, 31);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(147, 23);
            this.btnPush.TabIndex = 1;
            this.btnPush.Text = "Aggiungi coda Stampa";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPull
            // 
            this.btnPull.Location = new System.Drawing.Point(90, 85);
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(147, 23);
            this.btnPull.TabIndex = 2;
            this.btnPull.Text = "Stampa";
            this.btnPull.UseVisualStyleBackColor = true;
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 120);
            this.Controls.Add(this.btnPull);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtPush);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPull;
        public System.Windows.Forms.TextBox txtPush;
    }
}

