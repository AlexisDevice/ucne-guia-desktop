namespace ucne_guia_desktop.Views
{
    partial class Comentarios
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
            Comentarios_dtg = new DataGridView();
            NuevoComentario_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)Comentarios_dtg).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 30);
            label1.TabIndex = 0;
            label1.Text = "Comentarios";
            // 
            // Comentarios_dtg
            // 
            Comentarios_dtg.AllowUserToAddRows = false;
            Comentarios_dtg.AllowUserToDeleteRows = false;
            Comentarios_dtg.AllowUserToOrderColumns = true;
            Comentarios_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Comentarios_dtg.Location = new Point(12, 42);
            Comentarios_dtg.Name = "Comentarios_dtg";
            Comentarios_dtg.ReadOnly = true;
            Comentarios_dtg.Size = new Size(776, 396);
            Comentarios_dtg.TabIndex = 1;
            // 
            // NuevoComentario_btn
            // 
            NuevoComentario_btn.Location = new Point(623, 9);
            NuevoComentario_btn.Name = "NuevoComentario_btn";
            NuevoComentario_btn.Size = new Size(165, 30);
            NuevoComentario_btn.TabIndex = 2;
            NuevoComentario_btn.Text = "Nuevo comentario";
            NuevoComentario_btn.UseVisualStyleBackColor = true;
            NuevoComentario_btn.Click += NuevoComentario_btn_Click;
            // 
            // Comentarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NuevoComentario_btn);
            Controls.Add(Comentarios_dtg);
            Controls.Add(label1);
            Name = "Comentarios";
            Text = "Comentarios";
            Load += Comentarios_Load;
            ((System.ComponentModel.ISupportInitialize)Comentarios_dtg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView Comentarios_dtg;
        private Button NuevoComentario_btn;
    }
}