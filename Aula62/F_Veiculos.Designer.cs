namespace Aula62
{
    partial class F_Veiculos
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
            tb_listaVeiculos = new TextBox();
            SuspendLayout();
            // 
            // tb_listaVeiculos
            // 
            tb_listaVeiculos.BorderStyle = BorderStyle.FixedSingle;
            tb_listaVeiculos.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_listaVeiculos.Location = new Point(12, 33);
            tb_listaVeiculos.Multiline = true;
            tb_listaVeiculos.Name = "tb_listaVeiculos";
            tb_listaVeiculos.Size = new Size(543, 405);
            tb_listaVeiculos.TabIndex = 0;
            // 
            // F_Veiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 447);
            Controls.Add(tb_listaVeiculos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "F_Veiculos";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Veiculos";
            FormClosed += F_Veiculos_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox tb_listaVeiculos;
    }
}