namespace _08_KlassenEnObjecten.Oefening_1
{
    partial class frmOef1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiepte = new System.Windows.Forms.TextBox();
            this.txtLengte = new System.Windows.Forms.TextBox();
            this.txtBreedte = new System.Windows.Forms.TextBox();
            this.txtRandafstand = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblPoolinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diepte (in m)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lengte (in m)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Breedte (in m)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Randafstand (in m)";
            // 
            // txtDiepte
            // 
            this.txtDiepte.Location = new System.Drawing.Point(116, 19);
            this.txtDiepte.Name = "txtDiepte";
            this.txtDiepte.Size = new System.Drawing.Size(100, 20);
            this.txtDiepte.TabIndex = 1;
            // 
            // txtLengte
            // 
            this.txtLengte.Location = new System.Drawing.Point(116, 52);
            this.txtLengte.Name = "txtLengte";
            this.txtLengte.Size = new System.Drawing.Size(100, 20);
            this.txtLengte.TabIndex = 1;
            // 
            // txtBreedte
            // 
            this.txtBreedte.Location = new System.Drawing.Point(116, 91);
            this.txtBreedte.Name = "txtBreedte";
            this.txtBreedte.Size = new System.Drawing.Size(100, 20);
            this.txtBreedte.TabIndex = 1;
            // 
            // txtRandafstand
            // 
            this.txtRandafstand.Location = new System.Drawing.Point(116, 130);
            this.txtRandafstand.Name = "txtRandafstand";
            this.txtRandafstand.Size = new System.Drawing.Size(100, 20);
            this.txtRandafstand.TabIndex = 1;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(16, 160);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(200, 23);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // lblPoolinfo
            // 
            this.lblPoolinfo.AutoSize = true;
            this.lblPoolinfo.Location = new System.Drawing.Point(16, 207);
            this.lblPoolinfo.Name = "lblPoolinfo";
            this.lblPoolinfo.Size = new System.Drawing.Size(10, 13);
            this.lblPoolinfo.TabIndex = 3;
            this.lblPoolinfo.Text = ".";
            // 
            // frmOef1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 397);
            this.Controls.Add(this.lblPoolinfo);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtRandafstand);
            this.Controls.Add(this.txtBreedte);
            this.Controls.Add(this.txtLengte);
            this.Controls.Add(this.txtDiepte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOef1";
            this.Text = "Zwembad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiepte;
        private System.Windows.Forms.TextBox txtLengte;
        private System.Windows.Forms.TextBox txtBreedte;
        private System.Windows.Forms.TextBox txtRandafstand;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblPoolinfo;
    }
}