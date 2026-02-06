namespace TrabajoClase
{
    partial class formularioHijo1
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
            Usuario = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label2 = new Label();
            btnIngreso = new Button();
            SuspendLayout();
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Location = new Point(168, 136);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(47, 15);
            Usuario.TabIndex = 0;
            Usuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(241, 136);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(433, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(241, 175);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(433, 23);
            txtContraseña.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 175);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // btnIngreso
            // 
            btnIngreso.Location = new Point(292, 234);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(220, 57);
            btnIngreso.TabIndex = 4;
            btnIngreso.Text = "Ingresar";
            btnIngreso.UseVisualStyleBackColor = true;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // formularioHijo1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngreso);
            Controls.Add(txtContraseña);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(Usuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formularioHijo1";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Usuario;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label2;
        private Button btnIngreso;
    }
}