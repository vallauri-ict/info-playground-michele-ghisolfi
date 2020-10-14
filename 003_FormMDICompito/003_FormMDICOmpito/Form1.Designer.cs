namespace _003_FormMDICOmpito
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.apriForm2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriForm2bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriFormModleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEtaFM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeFM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPassaTxt = new System.Windows.Forms.Button();
            this.txtPassata = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 342);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(599, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLbl
            // 
            this.toolStripStatusLbl.Name = "toolStripStatusLbl";
            this.toolStripStatusLbl.Size = new System.Drawing.Size(82, 20);
            this.toolStripStatusLbl.Text = "Ciao a tutti";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriForm2ToolStripMenuItem,
            this.apriForm2bToolStripMenuItem,
            this.apriFormModleToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem1.Text = "&Menu";
            // 
            // apriForm2ToolStripMenuItem
            // 
            this.apriForm2ToolStripMenuItem.Name = "apriForm2ToolStripMenuItem";
            this.apriForm2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.apriForm2ToolStripMenuItem.Text = "Apri Form 2";
            this.apriForm2ToolStripMenuItem.Click += new System.EventHandler(this.apriForm2ToolStripMenuItem_Click);
            // 
            // apriForm2bToolStripMenuItem
            // 
            this.apriForm2bToolStripMenuItem.Name = "apriForm2bToolStripMenuItem";
            this.apriForm2bToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.apriForm2bToolStripMenuItem.Text = "Apri Form 2b";
            this.apriForm2bToolStripMenuItem.Click += new System.EventHandler(this.apriForm2bToolStripMenuItem_Click);
            // 
            // apriFormModleToolStripMenuItem
            // 
            this.apriFormModleToolStripMenuItem.Name = "apriFormModleToolStripMenuItem";
            this.apriFormModleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.apriFormModleToolStripMenuItem.Text = "Apri form modale";
            this.apriFormModleToolStripMenuItem.Click += new System.EventHandler(this.apriFormModleToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.esciToolStripMenuItem.Text = "&Esci";
            // 
            // txtEtaFM
            // 
            this.txtEtaFM.Location = new System.Drawing.Point(276, 68);
            this.txtEtaFM.Margin = new System.Windows.Forms.Padding(4);
            this.txtEtaFM.Name = "txtEtaFM";
            this.txtEtaFM.ReadOnly = true;
            this.txtEtaFM.Size = new System.Drawing.Size(132, 22);
            this.txtEtaFM.TabIndex = 16;
            this.txtEtaFM.TextChanged += new System.EventHandler(this.txtEtaFM_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Età";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNomeFM
            // 
            this.txtNomeFM.Location = new System.Drawing.Point(66, 70);
            this.txtNomeFM.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeFM.Name = "txtNomeFM";
            this.txtNomeFM.ReadOnly = true;
            this.txtNomeFM.Size = new System.Drawing.Size(132, 22);
            this.txtNomeFM.TabIndex = 14;
            this.txtNomeFM.TextChanged += new System.EventHandler(this.txtNomeFM_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPassaTxt
            // 
            this.btnPassaTxt.Location = new System.Drawing.Point(152, 29);
            this.btnPassaTxt.Margin = new System.Windows.Forms.Padding(4);
            this.btnPassaTxt.Name = "btnPassaTxt";
            this.btnPassaTxt.Size = new System.Drawing.Size(161, 28);
            this.btnPassaTxt.TabIndex = 11;
            this.btnPassaTxt.Text = "Passa TXT a F2";
            this.btnPassaTxt.UseVisualStyleBackColor = true;
            this.btnPassaTxt.Click += new System.EventHandler(this.btnPassaTxt_Click);
            // 
            // txtPassata
            // 
            this.txtPassata.Location = new System.Drawing.Point(12, 32);
            this.txtPassata.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassata.Name = "txtPassata";
            this.txtPassata.Size = new System.Drawing.Size(132, 22);
            this.txtPassata.TabIndex = 10;
            this.txtPassata.TextChanged += new System.EventHandler(this.txtPassata_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 368);
            this.Controls.Add(this.txtEtaFM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeFM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPassaTxt);
            this.Controls.Add(this.txtPassata);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem apriForm2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriForm2bToolStripMenuItem;
        private System.Windows.Forms.TextBox txtEtaFM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeFM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPassaTxt;
        private System.Windows.Forms.TextBox txtPassata;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriFormModleToolStripMenuItem;
    }
}

