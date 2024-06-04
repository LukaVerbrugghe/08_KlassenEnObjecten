namespace _08_KlassenEnObjecten.Oefening_3
{
    partial class frmOef3
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
            this.txtDier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGewicht = new System.Windows.Forms.TextBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblBoodschap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geef een dier in: Koe, Slang of Varken";
            // 
            // txtDier
            // 
            this.txtDier.Location = new System.Drawing.Point(16, 56);
            this.txtDier.Name = "txtDier";
            this.txtDier.Size = new System.Drawing.Size(186, 20);
            this.txtDier.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Schat het gewicht (geheel getal)";
            // 
            // txtGewicht
            // 
            this.txtGewicht.Location = new System.Drawing.Point(16, 113);
            this.txtGewicht.Name = "txtGewicht";
            this.txtGewicht.Size = new System.Drawing.Size(186, 20);
            this.txtGewicht.TabIndex = 1;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(240, 56);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Info?";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblBoodschap
            // 
            this.lblBoodschap.AutoSize = true;
            this.lblBoodschap.Location = new System.Drawing.Point(16, 168);
            this.lblBoodschap.Name = "lblBoodschap";
            this.lblBoodschap.Size = new System.Drawing.Size(35, 13);
            this.lblBoodschap.TabIndex = 3;
            this.lblBoodschap.Text = "label3";
            // 
            // frmOef3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 215);
            this.Controls.Add(this.lblBoodschap);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.txtGewicht);
            this.Controls.Add(this.txtDier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOef3";
            this.Text = "frmOef3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGewicht;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblBoodschap;
    }
}