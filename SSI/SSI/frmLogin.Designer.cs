namespace SSI
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btIngreso = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbConex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btIngreso
            // 
            this.btIngreso.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btIngreso.Location = new System.Drawing.Point(42, 107);
            this.btIngreso.Name = "btIngreso";
            this.btIngreso.Size = new System.Drawing.Size(75, 23);
            this.btIngreso.TabIndex = 1;
            this.btIngreso.Text = "Ingreso";
            this.btIngreso.UseVisualStyleBackColor = true;
            this.btIngreso.UseWaitCursor = true;
            this.btIngreso.Click += new System.EventHandler(this.btIngreso_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(150, 107);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 2;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.UseWaitCursor = true;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(98, 46);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(130, 20);
            this.tbUsuario.TabIndex = 3;
            this.tbUsuario.UseWaitCursor = true;
            this.tbUsuario.Enter += new System.EventHandler(this.tbUsuario_Enter);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(98, 73);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(130, 22);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseWaitCursor = true;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Image = global::SSI.Properties.Resources.educativo3;
            this.pbLogo.Location = new System.Drawing.Point(234, 89);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(75, 79);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.UseWaitCursor = true;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbUsuario.Location = new System.Drawing.Point(18, 46);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(61, 19);
            this.lbUsuario.TabIndex = 5;
            this.lbUsuario.Text = "Usuario";
            this.lbUsuario.UseWaitCursor = true;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbPassword.Location = new System.Drawing.Point(3, 73);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(86, 19);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Contraseña";
            this.lbPassword.UseWaitCursor = true;
            // 
            // lbConex
            // 
            this.lbConex.AutoSize = true;
            this.lbConex.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbConex.Location = new System.Drawing.Point(4, 155);
            this.lbConex.Name = "lbConex";
            this.lbConex.Size = new System.Drawing.Size(0, 13);
            this.lbConex.TabIndex = 7;
            this.lbConex.UseWaitCursor = true;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btIngreso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(308, 168);
            this.Controls.Add(this.lbConex);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btIngreso);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Ingreso de usuarios";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btIngreso;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbConex;
    }
}

