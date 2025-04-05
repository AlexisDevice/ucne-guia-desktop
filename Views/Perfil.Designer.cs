namespace ucne_guia_desktop.Views
{
    partial class Perfil
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
            Nombre_lb = new Label();
            Matricula_lb = new Label();
            Correo_lb = new Label();
            SuspendLayout();
            // 
            // Nombre_lb
            // 
            Nombre_lb.AutoSize = true;
            Nombre_lb.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nombre_lb.Location = new Point(307, 127);
            Nombre_lb.Name = "Nombre_lb";
            Nombre_lb.Size = new Size(103, 32);
            Nombre_lb.TabIndex = 0;
            Nombre_lb.Text = "Nombre";
            // 
            // Matricula_lb
            // 
            Matricula_lb.AutoSize = true;
            Matricula_lb.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Matricula_lb.Location = new Point(307, 180);
            Matricula_lb.Name = "Matricula_lb";
            Matricula_lb.Size = new Size(117, 32);
            Matricula_lb.TabIndex = 1;
            Matricula_lb.Text = "Matricula";
            // 
            // Correo_lb
            // 
            Correo_lb.AutoSize = true;
            Correo_lb.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Correo_lb.Location = new Point(307, 232);
            Correo_lb.Name = "Correo_lb";
            Correo_lb.Size = new Size(88, 32);
            Correo_lb.TabIndex = 2;
            Correo_lb.Text = "Correo";
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Correo_lb);
            Controls.Add(Matricula_lb);
            Controls.Add(Nombre_lb);
            Name = "Perfil";
            Text = "Perfil";
            Load += Perfil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre_lb;
        private Label Matricula_lb;
        private Label Correo_lb;
    }
}