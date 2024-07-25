using System.Xml.Serialization;
using tp_bem_mais_novo_que_o_muito_mais_novo;

namespace tp_muito_mais_novo_do_q_o_mais_novo
{
    public partial class Form1 : Form
    {
        private Sistema sistema;
        public Form1()
        {
            InitializeComponent();
            sistema = new Sistema();
            desserializarUsuarios();
            atualizarListaUsuarios();
        }

        private void criarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCriarUsuario f2 = new FormCriarUsuario();
            f2.ShowDialog();
        }

        private void desserializarUsuarios()
        {

            if (File.Exists("usuarios.xml"))
            {
                using (TextReader arquivo = new StreamReader("usuarios.xml"))
                {
                    XmlSerializer obj = new XmlSerializer(typeof(List<Usuario>));
                    sistema.usuarios = (List<Usuario>)obj.Deserialize(arquivo);
                }
            }
        }

        private void desserializarEmprestimos()
        {

            if (File.Exists("emprestimos.xml"))
            {
                using (TextReader arquivo = new StreamReader("emprestimos.xml"))
                {
                    XmlSerializer obj = new XmlSerializer(typeof(List<Emprestimo>));
                    sistema.emprestimos = (List<Emprestimo>)obj.Deserialize(arquivo);
                }
            }
        }

        public void atualizarListaUsuarios()
        {
            cbCredor.Items.Clear();
            cbDevedor.Items.Clear();

            foreach (Usuario usuario in sistema.usuarios)
            {
                cbCredor.Items.Add(usuario.nome);
                cbDevedor.Items.Add(usuario.nome);
            }
        }


        private void criarUsuárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormCriarUsuario f2 = new FormCriarUsuario();
            f2.Show();
        }

        private void btnCriarEmprestimo_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbCredor.Text) ||
                string.IsNullOrWhiteSpace(cbDevedor.Text) ||
                string.IsNullOrWhiteSpace(txtValor.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todas as informações necessárias.");
                return;
            }

            DateTime data = dateTimePicker1.Value;
            sistema.criarEmprestimo(cbCredor.Text, cbDevedor.Text, float.Parse(txtValor.Text), data, txtSenha.Text);
        }

        private void btnListarEmprestimos_Click_1(object sender, EventArgs e)
        {
            desserializarEmprestimos();
            if (sistema.emprestimos.Count > 0)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("Credor", "Credor");
                dataGridView1.Columns.Add("Devedor", "Devedor");
                dataGridView1.Columns.Add("Valor", "Valor");
                dataGridView1.Columns.Add("Data", "Data");

                foreach (Emprestimo emprestimo in sistema.emprestimos)
                {
                    dataGridView1.Rows.Add(
                        emprestimo.usuarioCredor.nome,
                        emprestimo.usuarioDevedor.nome,
                        emprestimo.valor,
                        emprestimo.data.ToString("dd/MM/yyyy")
                    );
                }
            }
            else
            {
                MessageBox.Show("Não há empréstimos para exibir.");
            }
        }

        private void lbTitulo_Click_1(object sender, EventArgs e)
        {
            desserializarUsuarios();
            atualizarListaUsuarios();
        }

        private void quitarEmpréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuitarEmprestimoForm f3 = new QuitarEmprestimoForm();
            f3.Show();
        }
    }
}
