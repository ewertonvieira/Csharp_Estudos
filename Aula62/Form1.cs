using System.Data;

namespace Aula62
{
    public partial class Form1 : Form
    {
        public int num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_adicionar.Text) || string.IsNullOrWhiteSpace(tb_adicionar.Text))
            {
                MessageBox.Show("Digite um veiculo...");
                tb_adicionar.Focus();
                return;
            }
            tb_listaVeiculos.Text = tb_listaVeiculos.Text + tb_adicionar.Text + ", ";
            tb_adicionar.Clear();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaVeiculos.Clear();
            tb_adicionar.Clear();
            tb_adicionar.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(tb_listaVeiculos.Text, this); // Instancia da classe F_Veiculos, tem como paramentro o que quero manda para a nova interface.
            f_Veiculos.ShowDialog(); // Show permite acessar a pagina anteior e ShowDialong nao permite;

        }

        private void btn_ValNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

    }
}