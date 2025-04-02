namespace ucne_guia_desktop.Views
{
    partial class Signup
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
            label1 = new Label();
            Nombre_tbx = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Matricula_tbx = new TextBox();
            label4 = new Label();
            Email_tbx = new TextBox();
            label5 = new Label();
            password_tbx = new TextBox();
            Signup_btn = new Button();
            Signin_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 21);
            label1.Name = "label1";
            label1.Size = new Size(121, 45);
            label1.TabIndex = 0;
            label1.Text = "Signup";
            // 
            // Nombre_tbx
            // 
            Nombre_tbx.Location = new Point(90, 92);
            Nombre_tbx.Name = "Nombre_tbx";
            Nombre_tbx.Size = new Size(200, 23);
            Nombre_tbx.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 74);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(90, 123);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Matricula";
            // 
            // Matricula_tbx
            // 
            Matricula_tbx.Location = new Point(90, 141);
            Matricula_tbx.Name = "Matricula_tbx";
            Matricula_tbx.Size = new Size(200, 23);
            Matricula_tbx.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(90, 173);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // Email_tbx
            // 
            Email_tbx.Location = new Point(90, 191);
            Email_tbx.Name = "Email_tbx";
            Email_tbx.Size = new Size(200, 23);
            Email_tbx.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(90, 221);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // password_tbx
            // 
            password_tbx.Location = new Point(90, 239);
            password_tbx.Name = "password_tbx";
            password_tbx.Size = new Size(200, 23);
            password_tbx.TabIndex = 7;
            password_tbx.UseSystemPasswordChar = true;
            // 
            // Signup_btn
            // 
            Signup_btn.Location = new Point(90, 278);
            Signup_btn.Name = "Signup_btn";
            Signup_btn.Size = new Size(200, 30);
            Signup_btn.TabIndex = 9;
            Signup_btn.Text = "Registrarse";
            Signup_btn.UseVisualStyleBackColor = true;
            Signup_btn.Click += Signup_btn_Click;
            // 
            // Signin_btn
            // 
            Signin_btn.BackColor = SystemColors.Window;
            Signin_btn.Location = new Point(90, 314);
            Signin_btn.Name = "Signin_btn";
            Signin_btn.Size = new Size(200, 25);
            Signin_btn.TabIndex = 10;
            Signin_btn.Text = "Iniciar sesion";
            Signin_btn.UseVisualStyleBackColor = false;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(Signin_btn);
            Controls.Add(Signup_btn);
            Controls.Add(label5);
            Controls.Add(password_tbx);
            Controls.Add(label4);
            Controls.Add(Email_tbx);
            Controls.Add(label3);
            Controls.Add(Matricula_tbx);
            Controls.Add(label2);
            Controls.Add(Nombre_tbx);
            Controls.Add(label1);
            Name = "Signup";
            Text = "Signup";
            FormClosing += Signup_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Nombre_tbx;
        private Label label2;
        private Label label3;
        private TextBox Matricula_tbx;
        private Label label4;
        private TextBox Email_tbx;
        private Label label5;
        private TextBox password_tbx;
        private Button Signup_btn;
        private Button Signin_btn;
    }
}