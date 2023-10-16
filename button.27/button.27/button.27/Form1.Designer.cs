namespace button._27
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSesSeviyesi = new System.Windows.Forms.Label();
            this.lblSeviyedeger = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(81, 43);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(259, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ses Seviyesi";
            // 
            // lblSesSeviyesi
            // 
            this.lblSesSeviyesi.AutoSize = true;
            this.lblSesSeviyesi.Location = new System.Drawing.Point(119, 132);
            this.lblSesSeviyesi.Name = "lblSesSeviyesi";
            this.lblSesSeviyesi.Size = new System.Drawing.Size(28, 13);
            this.lblSesSeviyesi.TabIndex = 2;
            this.lblSesSeviyesi.Text = "SES";
            // 
            // lblSeviyedeger
            // 
            this.lblSeviyedeger.AutoSize = true;
            this.lblSeviyedeger.Location = new System.Drawing.Point(385, 52);
            this.lblSeviyedeger.Name = "lblSeviyedeger";
            this.lblSeviyedeger.Size = new System.Drawing.Size(71, 13);
            this.lblSeviyedeger.TabIndex = 3;
            this.lblSeviyedeger.Text = "Seviye Değer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 291);
            this.Controls.Add(this.lblSeviyedeger);
            this.Controls.Add(this.lblSesSeviyesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSesSeviyesi;
        private System.Windows.Forms.Label lblSeviyedeger;
    }
}

