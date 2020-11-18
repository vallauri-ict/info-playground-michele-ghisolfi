namespace _011_Lista
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
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnAggiungiObj = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.btnVisualizzaObj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDaCercare = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(138, 34);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 22);
            this.txtTitolo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titolo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autore";
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(138, 76);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 22);
            this.txtAutore.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(138, 118);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Aggiungi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(147, 187);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(91, 23);
            this.btnVisualizza.TabIndex = 7;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // btnAggiungiObj
            // 
            this.btnAggiungiObj.Location = new System.Drawing.Point(35, 232);
            this.btnAggiungiObj.Name = "btnAggiungiObj";
            this.btnAggiungiObj.Size = new System.Drawing.Size(99, 31);
            this.btnAggiungiObj.TabIndex = 8;
            this.btnAggiungiObj.Text = "Aggiungi Obj";
            this.btnAggiungiObj.UseVisualStyleBackColor = true;
            this.btnAggiungiObj.Click += new System.EventHandler(this.btnAggiungiObj_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(59, 319);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFindAll
            // 
            this.btnFindAll.Location = new System.Drawing.Point(160, 315);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(75, 23);
            this.btnFindAll.TabIndex = 10;
            this.btnFindAll.Text = "Find All";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // btnVisualizzaObj
            // 
            this.btnVisualizzaObj.Location = new System.Drawing.Point(163, 232);
            this.btnVisualizzaObj.Name = "btnVisualizzaObj";
            this.btnVisualizzaObj.Size = new System.Drawing.Size(99, 31);
            this.btnVisualizzaObj.TabIndex = 11;
            this.btnVisualizzaObj.Text = "Visualizza Obj";
            this.btnVisualizzaObj.UseVisualStyleBackColor = true;
            this.btnVisualizzaObj.Click += new System.EventHandler(this.btnVisualizzaObj_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "titolo/autore";
            // 
            // txtDaCercare
            // 
            this.txtDaCercare.Location = new System.Drawing.Point(163, 277);
            this.txtDaCercare.Name = "txtDaCercare";
            this.txtDaCercare.Size = new System.Drawing.Size(100, 22);
            this.txtDaCercare.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 354);
            this.Controls.Add(this.txtDaCercare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVisualizzaObj);
            this.Controls.Add(this.btnFindAll);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnAggiungiObj);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnAggiungiObj;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnFindAll;
        private System.Windows.Forms.Button btnVisualizzaObj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDaCercare;
    }
}

