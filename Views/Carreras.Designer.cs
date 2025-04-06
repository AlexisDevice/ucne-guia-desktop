namespace ucne_guia_desktop.Views
{
    partial class Carreras
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
            Carreragril = new DataGridView();
            Carrera = new Label();
            ((System.ComponentModel.ISupportInitialize)Carreragril).BeginInit();
            SuspendLayout();
            // 
            // Carreragril
            // 
            Carreragril.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Carreragril.Location = new Point(0, 59);
            Carreragril.Name = "Carreragril";
            Carreragril.RowHeadersWidth = 62;
            Carreragril.Size = new Size(1049, 389);
            Carreragril.TabIndex = 0;
            // 
            // Carrera
            // 
            Carrera.AutoSize = true;
            Carrera.Location = new Point(431, 20);
            Carrera.Name = "Carrera";
            Carrera.Size = new Size(155, 25);
            Carrera.TabIndex = 1;
            Carrera.Text = "Carrera de la Ucne";
            // 
            // Carreras
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 450);
            Controls.Add(Carrera);
            Controls.Add(Carreragril);
            Name = "Carreras";
            Text = "Carreras";
            Load += Carreras_Load;
            ((System.ComponentModel.ISupportInitialize)Carreragril).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Carreragril;
        private Label Carrera;
    }
}