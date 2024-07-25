using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_muito_mais_novo_do_q_o_mais_novo;

namespace tp_bem_mais_novo_que_o_muito_mais_novo
{
    public partial class QuitarEmprestimoForm : Form
    {
        Sistema sistema;
        public QuitarEmprestimoForm()
        {
            InitializeComponent();
            sistema = new Sistema();
            sistema.CarregarUsuarios();
            atualizarUsuarios();
            dataGridView1.AllowUserToAddRows = false;
        }

        public void atualizarUsuarios()
        {
            cbCredor.Items.Clear();
            cbDevedor.Items.Clear();

            foreach (Usuario usuario in sistema.usuarios)
            {
                cbCredor.Items.Add(usuario.nome);
                cbDevedor.Items.Add(usuario.nome);
            }
        }


        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbCredor.Text) || string.IsNullOrWhiteSpace(cbDevedor.Text))
            {
                MessageBox.Show("Por favor, preencha todas as informações necessárias.");
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            List<Emprestimo>? emprestimosEncontrados = sistema.obterEmprestimos(cbCredor.Text, cbDevedor.Text);
            if (emprestimosEncontrados == null)
            {
                return;
            }
            if (emprestimosEncontrados.Count > 0)
            {
                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("Valor", "Valor");
                    dataGridView1.Columns.Add("Data", "Data");
                    dataGridView1.Columns.Add("Valor Reajustado", "Valor Reajustado");
                    dataGridView1.Columns["Valor Reajustado"].Visible = false;
                }
                foreach (Emprestimo emprestimo in emprestimosEncontrados)
                {
                    dataGridView1.Rows.Add(emprestimo.valor, emprestimo.data.ToString("dd/MM/yyyy"), "");
                }
            }
            else
            {
                MessageBox.Show("Nenhum empréstimo encontrado.");
            }

        }

        private void btnQuitarEmprestimo_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Emprestimo emprestimoSelecionado = sistema.obterEmprestimos(cbCredor.Text, cbDevedor.Text)[dataGridView1.SelectedRows[0].Index];
                if (emprestimoSelecionado.usuarioCredor.senha != txtSenha.Text)
                {
                    MessageBox.Show("Senha incorreta.");
                    return;
                }
                sistema.quitarEmprestimo(emprestimoSelecionado, txtSenha.Text);
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Selecione um empréstimo para quitar.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                List<Emprestimo> emprestimosSelecionados = sistema.obterEmprestimos(cbCredor.Text, cbDevedor.Text);

                if (e.RowIndex < emprestimosSelecionados.Count)
                {
                    Emprestimo emprestimoSelecionado = emprestimosSelecionados[e.RowIndex];
                    float valorReajustado = sistema.obterValorAtualizado(emprestimoSelecionado);
                    string valorReajustadoFormatado = valorReajustado.ToString("F2");
                    dataGridView1.Rows[e.RowIndex].Cells["Valor Reajustado"].Value = valorReajustadoFormatado;
                    dataGridView1.Columns["Valor Reajustado"].Visible = true;
                }
            }
        }

        private void cbCredor_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }

        private void cbDevedor_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }
    }
}
