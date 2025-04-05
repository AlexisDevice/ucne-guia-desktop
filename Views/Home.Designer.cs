namespace ucne_guia_desktop.Views
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            ucneLogo_pbx = new PictureBox();
            label1 = new Label();
            Comentarios_btn = new Button();
            Materias_btn = new Button();
            Maestros_btn = new Button();
            Carreras_btn = new Button();
            Perfil_btn = new Button();
            Salir_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)ucneLogo_pbx).BeginInit();
            SuspendLayout();
            // 
            // ucneLogo_pbx
            // 
            ucneLogo_pbx.Image = (Image)resources.GetObject("ucneLogo_pbx.Image");
            ucneLogo_pbx.Location = new Point(431, 12);
            ucneLogo_pbx.Name = "ucneLogo_pbx";
            ucneLogo_pbx.Size = new Size(76, 82);
            ucneLogo_pbx.SizeMode = PictureBoxSizeMode.Zoom;
            ucneLogo_pbx.TabIndex = 0;
            ucneLogo_pbx.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(513, 40);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 1;
            label1.Text = "UcneGuia";
            // 
            // Comentarios_btn
            // 
            Comentarios_btn.Location = new Point(196, 138);
            Comentarios_btn.Name = "Comentarios_btn";
            Comentarios_btn.Size = new Size(150, 50);
            Comentarios_btn.TabIndex = 2;
            Comentarios_btn.Text = "Comentarios";
            Comentarios_btn.UseVisualStyleBackColor = true;
            Comentarios_btn.Click += Comentarios_btn_Click;
            // 
            // Materias_btn
            // 
            Materias_btn.Location = new Point(421, 138);
            Materias_btn.Name = "Materias_btn";
            Materias_btn.Size = new Size(150, 50);
            Materias_btn.TabIndex = 3;
            Materias_btn.Text = "Materias";
            Materias_btn.UseVisualStyleBackColor = true;
            // 
            // Maestros_btn
            // 
            Maestros_btn.Location = new Point(648, 138);
            Maestros_btn.Name = "Maestros_btn";
            Maestros_btn.Size = new Size(150, 50);
            Maestros_btn.TabIndex = 4;
            Maestros_btn.Text = "Maestros";
            Maestros_btn.UseVisualStyleBackColor = true;
            // 
            // Carreras_btn
            // 
            Carreras_btn.Location = new Point(196, 234);
            Carreras_btn.Name = "Carreras_btn";
            Carreras_btn.Size = new Size(150, 50);
            Carreras_btn.TabIndex = 5;
            Carreras_btn.Text = "Carreras";
            Carreras_btn.UseVisualStyleBackColor = true;
            // 
            // Perfil_btn
            // 
            Perfil_btn.Location = new Point(421, 234);
            Perfil_btn.Name = "Perfil_btn";
            Perfil_btn.Size = new Size(150, 50);
            Perfil_btn.TabIndex = 6;
            Perfil_btn.Text = "Perfil";
            Perfil_btn.UseVisualStyleBackColor = true;
            Perfil_btn.Click += Perfil_btn_Click;
            // 
            // Salir_btn
            // 
            Salir_btn.Location = new Point(648, 234);
            Salir_btn.Name = "Salir_btn";
            Salir_btn.Size = new Size(150, 50);
            Salir_btn.TabIndex = 7;
            Salir_btn.Text = "Salir";
            Salir_btn.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(Salir_btn);
            Controls.Add(Perfil_btn);
            Controls.Add(Carreras_btn);
            Controls.Add(Maestros_btn);
            Controls.Add(Materias_btn);
            Controls.Add(Comentarios_btn);
            Controls.Add(label1);
            Controls.Add(ucneLogo_pbx);
            Name = "Home";
            Text = "Home";
            FormClosing += Home_FormClosing;
            ((System.ComponentModel.ISupportInitialize)ucneLogo_pbx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ucneLogo_pbx;
        private Label label1;
        private Button Comentarios_btn;
        private Button Materias_btn;
        private Button Maestros_btn;
        private Button Carreras_btn;
        private Button Perfil_btn;
        private Button Salir_btn;
    }
}