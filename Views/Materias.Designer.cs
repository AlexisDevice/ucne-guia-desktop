namespace ucne_guia_desktop.Views
{
    partial class Materias
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
            materiadatagri = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)materiadatagri).BeginInit();
            SuspendLayout();
            // 
            // materiadatagri
            // 
            materiadatagri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            materiadatagri.Location = new Point(4, 62);
            materiadatagri.Name = "materiadatagri";
            materiadatagri.RowHeadersWidth = 62;
            materiadatagri.Size = new Size(1152, 512);
            materiadatagri.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(516, 19);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(160, 25);
            label1.TabIndex = 1;
            label1.Text = "Materia De la Ucne";
            // 
            // Materias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 572);
            Controls.Add(label1);
            Controls.Add(materiadatagri);
            Name = "Materias";
            Text = "Materia";
            Load += Materia_Load;
            ((System.ComponentModel.ISupportInitialize)materiadatagri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView materiadatagri;
        private Label label1;
    }
}