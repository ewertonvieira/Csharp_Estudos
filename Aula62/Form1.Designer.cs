namespace Aula62
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_adicionar = new Button();
            tb_adicionar = new TextBox();
            tb_listaVeiculos = new TextBox();
            btn_limpar = new Button();
            label1 = new Label();
            btn_mostrar = new Button();
            btn_ValNum = new Button();
            SuspendLayout();
            // 
            // btn_adicionar
            // 
            resources.ApplyResources(btn_adicionar, "btn_adicionar");
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // tb_adicionar
            // 
            resources.ApplyResources(tb_adicionar, "tb_adicionar");
            tb_adicionar.Name = "tb_adicionar";
            // 
            // tb_listaVeiculos
            // 
            resources.ApplyResources(tb_listaVeiculos, "tb_listaVeiculos");
            tb_listaVeiculos.Name = "tb_listaVeiculos";
            tb_listaVeiculos.ReadOnly = true;
            // 
            // btn_limpar
            // 
            resources.ApplyResources(btn_limpar, "btn_limpar");
            btn_limpar.Name = "btn_limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // btn_mostrar
            // 
            resources.ApplyResources(btn_mostrar, "btn_mostrar");
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // btn_ValNum
            // 
            resources.ApplyResources(btn_ValNum, "btn_ValNum");
            btn_ValNum.Name = "btn_ValNum";
            btn_ValNum.UseVisualStyleBackColor = true;
            btn_ValNum.Click += btn_ValNum_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.Window;
            Controls.Add(btn_ValNum);
            Controls.Add(btn_mostrar);
            Controls.Add(btn_limpar);
            Controls.Add(label1);
            Controls.Add(tb_listaVeiculos);
            Controls.Add(tb_adicionar);
            Controls.Add(btn_adicionar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_adicionar;
        private TextBox tb_adicionar;
        private Button btn_limpar;
        private Label label1;
        private Button btn_mostrar;
        private Button btn_ValNum;
        public TextBox tb_listaVeiculos;
    }
}