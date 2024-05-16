namespace _08_KlassenEnObjecten {
    partial class Form1 {
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
            this.txtMerk = new System.Windows.Forms.TextBox();
            this.txtKleur = new System.Windows.Forms.TextBox();
            this.txtWielen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAuto1 = new System.Windows.Forms.Button();
            this.btnAuto2 = new System.Windows.Forms.Button();
            this.btnAuto3 = new System.Windows.Forms.Button();
            this.lblAuto1 = new System.Windows.Forms.Label();
            this.lblAuto2 = new System.Windows.Forms.Label();
            this.lblAuto3 = new System.Windows.Forms.Label();
            this.btnFiets = new System.Windows.Forms.Button();
            this.chbFietsplakaat = new System.Windows.Forms.CheckBox();
            this.lblFiets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMerk
            // 
            this.txtMerk.Location = new System.Drawing.Point(109, 47);
            this.txtMerk.Name = "txtMerk";
            this.txtMerk.Size = new System.Drawing.Size(100, 20);
            this.txtMerk.TabIndex = 0;
            // 
            // txtKleur
            // 
            this.txtKleur.Location = new System.Drawing.Point(109, 87);
            this.txtKleur.Name = "txtKleur";
            this.txtKleur.Size = new System.Drawing.Size(100, 20);
            this.txtKleur.TabIndex = 0;
            // 
            // txtWielen
            // 
            this.txtWielen.Location = new System.Drawing.Point(109, 126);
            this.txtWielen.Name = "txtWielen";
            this.txtWielen.Size = new System.Drawing.Size(100, 20);
            this.txtWielen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Merk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kleur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Aantal wielen";
            // 
            // btnAuto1
            // 
            this.btnAuto1.Location = new System.Drawing.Point(325, 122);
            this.btnAuto1.Name = "btnAuto1";
            this.btnAuto1.Size = new System.Drawing.Size(75, 23);
            this.btnAuto1.TabIndex = 2;
            this.btnAuto1.Text = "Auto 1";
            this.btnAuto1.UseVisualStyleBackColor = true;
            this.btnAuto1.Click += new System.EventHandler(this.btnAuto1_Click);
            // 
            // btnAuto2
            // 
            this.btnAuto2.Location = new System.Drawing.Point(450, 119);
            this.btnAuto2.Name = "btnAuto2";
            this.btnAuto2.Size = new System.Drawing.Size(75, 23);
            this.btnAuto2.TabIndex = 2;
            this.btnAuto2.Text = "Auto 2";
            this.btnAuto2.UseVisualStyleBackColor = true;
            this.btnAuto2.Click += new System.EventHandler(this.btnAuto2_Click);
            // 
            // btnAuto3
            // 
            this.btnAuto3.Location = new System.Drawing.Point(586, 119);
            this.btnAuto3.Name = "btnAuto3";
            this.btnAuto3.Size = new System.Drawing.Size(75, 23);
            this.btnAuto3.TabIndex = 2;
            this.btnAuto3.Text = "Auto3";
            this.btnAuto3.UseVisualStyleBackColor = true;
            this.btnAuto3.Click += new System.EventHandler(this.btnAuto3_Click);
            // 
            // lblAuto1
            // 
            this.lblAuto1.AutoSize = true;
            this.lblAuto1.Location = new System.Drawing.Point(179, 196);
            this.lblAuto1.Name = "lblAuto1";
            this.lblAuto1.Size = new System.Drawing.Size(10, 13);
            this.lblAuto1.TabIndex = 3;
            this.lblAuto1.Text = ".";
            // 
            // lblAuto2
            // 
            this.lblAuto2.AutoSize = true;
            this.lblAuto2.Location = new System.Drawing.Point(179, 232);
            this.lblAuto2.Name = "lblAuto2";
            this.lblAuto2.Size = new System.Drawing.Size(10, 13);
            this.lblAuto2.TabIndex = 3;
            this.lblAuto2.Text = ".";
            // 
            // lblAuto3
            // 
            this.lblAuto3.AutoSize = true;
            this.lblAuto3.Location = new System.Drawing.Point(179, 258);
            this.lblAuto3.Name = "lblAuto3";
            this.lblAuto3.Size = new System.Drawing.Size(10, 13);
            this.lblAuto3.TabIndex = 3;
            this.lblAuto3.Text = ".";
            // 
            // btnFiets
            // 
            this.btnFiets.Location = new System.Drawing.Point(325, 305);
            this.btnFiets.Name = "btnFiets";
            this.btnFiets.Size = new System.Drawing.Size(75, 23);
            this.btnFiets.TabIndex = 2;
            this.btnFiets.Text = "Fiets";
            this.btnFiets.UseVisualStyleBackColor = true;
            this.btnFiets.Click += new System.EventHandler(this.btnFiets_Click);
            // 
            // chbFietsplakaat
            // 
            this.chbFietsplakaat.AutoSize = true;
            this.chbFietsplakaat.Location = new System.Drawing.Point(92, 305);
            this.chbFietsplakaat.Name = "chbFietsplakaat";
            this.chbFietsplakaat.Size = new System.Drawing.Size(83, 17);
            this.chbFietsplakaat.TabIndex = 4;
            this.chbFietsplakaat.Text = "Fietsplakaat";
            this.chbFietsplakaat.UseVisualStyleBackColor = true;
            // 
            // lblFiets
            // 
            this.lblFiets.AutoSize = true;
            this.lblFiets.Location = new System.Drawing.Point(89, 350);
            this.lblFiets.Name = "lblFiets";
            this.lblFiets.Size = new System.Drawing.Size(10, 13);
            this.lblFiets.TabIndex = 3;
            this.lblFiets.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chbFietsplakaat);
            this.Controls.Add(this.lblFiets);
            this.Controls.Add(this.lblAuto3);
            this.Controls.Add(this.lblAuto2);
            this.Controls.Add(this.lblAuto1);
            this.Controls.Add(this.btnAuto3);
            this.Controls.Add(this.btnAuto2);
            this.Controls.Add(this.btnFiets);
            this.Controls.Add(this.btnAuto1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWielen);
            this.Controls.Add(this.txtKleur);
            this.Controls.Add(this.txtMerk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMerk;
        private System.Windows.Forms.TextBox txtKleur;
        private System.Windows.Forms.TextBox txtWielen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAuto1;
        private System.Windows.Forms.Button btnAuto2;
        private System.Windows.Forms.Button btnAuto3;
        private System.Windows.Forms.Label lblAuto1;
        private System.Windows.Forms.Label lblAuto2;
        private System.Windows.Forms.Label lblAuto3;
        private System.Windows.Forms.Button btnFiets;
        private System.Windows.Forms.CheckBox chbFietsplakaat;
        private System.Windows.Forms.Label lblFiets;
    }
}

