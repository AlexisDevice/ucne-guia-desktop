namespace ucne_guia_desktop.Views
{
    partial class Login
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
            Email_tbx = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Password_tbx = new TextBox();
            Signin_btn = new Button();
            Signup_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 41);
            label1.Name = "label1";
            label1.Size = new Size(101, 45);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // Email_tbx
            // 
            Email_tbx.Font = new Font("Segoe UI", 12F);
            Email_tbx.Location = new Point(90, 115);
            Email_tbx.Name = "Email_tbx";
            Email_tbx.Size = new Size(200, 29);
            Email_tbx.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 97);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(90, 155);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // Password_tbx
            // 
            Password_tbx.Font = new Font("Segoe UI", 12F);
            Password_tbx.Location = new Point(90, 173);
            Password_tbx.Name = "Password_tbx";
            Password_tbx.Size = new Size(200, 29);
            Password_tbx.TabIndex = 3;
            Password_tbx.UseSystemPasswordChar = true;
            // 
            // Signin_btn
            // 
            Signin_btn.Location = new Point(90, 219);
            Signin_btn.Name = "Signin_btn";
            Signin_btn.Size = new Size(200, 30);
            Signin_btn.TabIndex = 5;
            Signin_btn.Text = "Iniciar sesion";
            Signin_btn.UseVisualStyleBackColor = true;
            Signin_btn.Click += Signin_btn_Click;
            // 
            // Signup_btn
            // 
            Signup_btn.BackColor = SystemColors.Window;
            Signup_btn.Location = new Point(90, 265);
            Signup_btn.Name = "Signup_btn";
            Signup_btn.Size = new Size(200, 25);
            Signup_btn.TabIndex = 6;
            Signup_btn.Text = "Registrarse";
            Signup_btn.UseVisualStyleBackColor = false;
            Signup_btn.Click += Signup_btn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(Signup_btn);
            Controls.Add(Signin_btn);
            Controls.Add(label3);
            Controls.Add(Password_tbx);
            Controls.Add(label2);
            Controls.Add(Email_tbx);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Email_tbx;
        private Label label2;
        private Label label3;
        private TextBox Password_tbx;
        private Button Signin_btn;
        private Button Signup_btn;
    }
}