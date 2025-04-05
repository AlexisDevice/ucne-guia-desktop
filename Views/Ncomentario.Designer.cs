namespace ucne_guia_desktop.Views
{
    partial class Ncomentario
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
            MateriaId_tbx = new TextBox();
            Comentario_tbx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Guardar_btn = new Button();
            SuspendLayout();
            // 
            // MateriaId_tbx
            // 
            MateriaId_tbx.Location = new Point(12, 30);
            MateriaId_tbx.Name = "MateriaId_tbx";
            MateriaId_tbx.Size = new Size(260, 23);
            MateriaId_tbx.TabIndex = 0;
            // 
            // Comentario_tbx
            // 
            Comentario_tbx.Location = new Point(12, 85);
            Comentario_tbx.Multiline = true;
            Comentario_tbx.Name = "Comentario_tbx";
            Comentario_tbx.Size = new Size(260, 218);
            Comentario_tbx.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 2;
            label1.Text = "Id de la materia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "Comentario";
            // 
            // Guardar_btn
            // 
            Guardar_btn.Location = new Point(82, 326);
            Guardar_btn.Name = "Guardar_btn";
            Guardar_btn.Size = new Size(116, 23);
            Guardar_btn.TabIndex = 4;
            Guardar_btn.Text = "Guardar";
            Guardar_btn.UseVisualStyleBackColor = true;
            Guardar_btn.Click += Guardar_btn_Click;
            // 
            // Ncomentario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(Guardar_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Comentario_tbx);
            Controls.Add(MateriaId_tbx);
            Name = "Ncomentario";
            Text = "Nuevo comentario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MateriaId_tbx;
        private TextBox Comentario_tbx;
        private Label label1;
        private Label label2;
        private Button Guardar_btn;
    }
}