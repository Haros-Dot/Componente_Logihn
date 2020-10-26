namespace Componente_Logihn
{
    partial class Login
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.txb_contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(65, 154);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(101, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Iniciar Sesion ";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txb_usuario
            // 
            this.txb_usuario.Location = new System.Drawing.Point(12, 37);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(211, 20);
            this.txb_usuario.TabIndex = 1;
            // 
            // txb_contraseña
            // 
            this.txb_contraseña.Location = new System.Drawing.Point(12, 102);
            this.txb_contraseña.Name = "txb_contraseña";
            this.txb_contraseña.Size = new System.Drawing.Size(211, 20);
            this.txb_contraseña.TabIndex = 2;
            this.txb_contraseña.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña";
            // 
            // Label_Usuario
            // 
            this.Label_Usuario.AutoSize = true;
            this.Label_Usuario.Location = new System.Drawing.Point(9, 21);
            this.Label_Usuario.Name = "Label_Usuario";
            this.Label_Usuario.Size = new System.Drawing.Size(43, 13);
            this.Label_Usuario.TabIndex = 4;
            this.Label_Usuario.Text = "Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label_Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_contraseña);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.btn_login);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(239, 226);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.TextBox txb_contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Usuario;
    }
}
