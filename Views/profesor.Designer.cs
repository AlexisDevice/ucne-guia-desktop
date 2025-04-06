namespace ucne_guia_desktop.Views
{
    partial class profesor
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
            profesoresgri = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)profesoresgri).BeginInit();
            SuspendLayout();
            // 
            // profesoresgri
            // 
            profesoresgri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            profesoresgri.Location = new Point(-5, 55);
            profesoresgri.Name = "profesoresgri";
            profesoresgri.RowHeadersWidth = 62;
            profesoresgri.Size = new Size(948, 421);
            profesoresgri.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 27);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 1;
            label1.Text = "Profesores de la ucne";
            // 
            // profesor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 488);
            Controls.Add(label1);
            Controls.Add(profesoresgri);
            Name = "profesor";
            Text = "profesor";
            Load += profesor_Load;
            ((System.ComponentModel.ISupportInitialize)profesoresgri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView profesoresgri;
        private Label label1;
    }
}