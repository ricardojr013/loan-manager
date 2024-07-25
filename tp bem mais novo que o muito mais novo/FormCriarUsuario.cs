using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_muito_mais_novo_do_q_o_mais_novo
{
    public partial class FormCriarUsuario : Form
    {
        Sistema sistema;
        public FormCriarUsuario()
        {
            InitializeComponent();
            sistema = new Sistema();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "") { MessageBox.Show("Preencha todos os campos!"); return; }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            sistema.criarUsuario(txtNome.Text, txtSenha.Text);
        }
    }
}
