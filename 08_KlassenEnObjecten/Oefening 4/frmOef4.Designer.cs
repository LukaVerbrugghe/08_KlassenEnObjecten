namespace _08_KlassenEnObjecten.Oefening_4 {
    partial class frmOef4 {
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
            this.lblAantalFlesjesCola = new System.Windows.Forms.Label();
            this.lblAantalFlesjesWater = new System.Windows.Forms.Label();
            this.btnVulColaAan = new System.Windows.Forms.Button();
            this.btnVulWaterAan = new System.Windows.Forms.Button();
            this.btnKoopCola = new System.Windows.Forms.Button();
            this.btnKoopWater = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAantalFlesjesCola
            // 
            this.lblAantalFlesjesCola.AutoSize = true;
            this.lblAantalFlesjesCola.Location = new System.Drawing.Point(13, 13);
            this.lblAantalFlesjesCola.Name = "lblAantalFlesjesCola";
            this.lblAantalFlesjesCola.Size = new System.Drawing.Size(156, 13);
            this.lblAantalFlesjesCola.TabIndex = 0;
            this.lblAantalFlesjesCola.Text = "Aantal flesjes cola beschikbaar:";
            // 
            // lblAantalFlesjesWater
            // 
            this.lblAantalFlesjesWater.AutoSize = true;
            this.lblAantalFlesjesWater.Location = new System.Drawing.Point(284, 13);
            this.lblAantalFlesjesWater.Name = "lblAantalFlesjesWater";
            this.lblAantalFlesjesWater.Size = new System.Drawing.Size(162, 13);
            this.lblAantalFlesjesWater.TabIndex = 0;
            this.lblAantalFlesjesWater.Text = "Aantal flesjes water beschikbaar:";
            // 
            // btnVulColaAan
            // 
            this.btnVulColaAan.BackColor = System.Drawing.Color.Orange;
            this.btnVulColaAan.Location = new System.Drawing.Point(16, 39);
            this.btnVulColaAan.Name = "btnVulColaAan";
            this.btnVulColaAan.Size = new System.Drawing.Size(186, 36);
            this.btnVulColaAan.TabIndex = 1;
            this.btnVulColaAan.Text = "Vul cola aan";
            this.btnVulColaAan.UseVisualStyleBackColor = false;
            this.btnVulColaAan.Click += new System.EventHandler(this.btnVulColaAan_Click);
            // 
            // btnVulWaterAan
            // 
            this.btnVulWaterAan.BackColor = System.Drawing.Color.Cyan;
            this.btnVulWaterAan.Location = new System.Drawing.Point(287, 39);
            this.btnVulWaterAan.Name = "btnVulWaterAan";
            this.btnVulWaterAan.Size = new System.Drawing.Size(186, 36);
            this.btnVulWaterAan.TabIndex = 1;
            this.btnVulWaterAan.Text = "Vul water aan";
            this.btnVulWaterAan.UseVisualStyleBackColor = false;
            this.btnVulWaterAan.Click += new System.EventHandler(this.btnVulWaterAan_Click);
            // 
            // btnKoopCola
            // 
            this.btnKoopCola.BackColor = System.Drawing.Color.Orange;
            this.btnKoopCola.Location = new System.Drawing.Point(16, 81);
            this.btnKoopCola.Name = "btnKoopCola";
            this.btnKoopCola.Size = new System.Drawing.Size(186, 36);
            this.btnKoopCola.TabIndex = 1;
            this.btnKoopCola.Text = "Koop cola";
            this.btnKoopCola.UseVisualStyleBackColor = false;
            this.btnKoopCola.Click += new System.EventHandler(this.btnKoopCola_Click);
            // 
            // btnKoopWater
            // 
            this.btnKoopWater.BackColor = System.Drawing.Color.Cyan;
            this.btnKoopWater.Location = new System.Drawing.Point(287, 81);
            this.btnKoopWater.Name = "btnKoopWater";
            this.btnKoopWater.Size = new System.Drawing.Size(186, 36);
            this.btnKoopWater.TabIndex = 1;
            this.btnKoopWater.Text = "Koop water";
            this.btnKoopWater.UseVisualStyleBackColor = false;
            this.btnKoopWater.Click += new System.EventHandler(this.btnKoopWater_Click);
            // 
            // frmOef4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(499, 135);
            this.Controls.Add(this.btnVulWaterAan);
            this.Controls.Add(this.btnKoopWater);
            this.Controls.Add(this.btnKoopCola);
            this.Controls.Add(this.btnVulColaAan);
            this.Controls.Add(this.lblAantalFlesjesWater);
            this.Controls.Add(this.lblAantalFlesjesCola);
            this.Name = "frmOef4";
            this.Text = "frmOef4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAantalFlesjesCola;
        private System.Windows.Forms.Label lblAantalFlesjesWater;
        private System.Windows.Forms.Button btnVulColaAan;
        private System.Windows.Forms.Button btnVulWaterAan;
        private System.Windows.Forms.Button btnKoopCola;
        private System.Windows.Forms.Button btnKoopWater;
    }
}