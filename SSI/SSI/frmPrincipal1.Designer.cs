namespace SSI
{
    partial class frmPrincipal1
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Image = global::SSI.Properties.Resources.educativo3;
            this.pbLogo.Location = new System.Drawing.Point(673, 275);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(75, 79);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            this.pbLogo.UseWaitCursor = true;
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.BackColor = System.Drawing.Color.Transparent;
            this.lbLogo.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbLogo.Location = new System.Drawing.Point(557, 325);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(115, 13);
            this.lbLogo.TabIndex = 2;
            this.lbLogo.Text = "Sistema Educativo SSI";
            // 
            // frmPrincipal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(744, 347);
            this.Controls.Add(this.lbLogo);
            this.Controls.Add(this.pbLogo);
            this.Name = "frmPrincipal1";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.frmPrincipal1_Load);
            this.ResizeEnd += new System.EventHandler(this.frmPrincipal1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbLogo;
    }
}