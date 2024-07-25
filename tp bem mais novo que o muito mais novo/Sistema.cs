using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tp_muito_mais_novo_do_q_o_mais_novo
{
    public class Sistema
    {
        public float juros = 1.1F;
        public List<Emprestimo> emprestimos = new List<Emprestimo>();
        public List<Usuario> usuarios = new List<Usuario>();


        public void criarEmprestimo(string nomeCredor, string nomeDevedor, float valor, DateTime data, string senha)
        {
            carregarEmprestimos();
            Usuario? credor = null;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.nome == nomeCredor)
                {
                    credor = usuario;
                }
            }

            if (credor == null)
            {
                MessageBox.Show("Insira o credor");
                return;
            }

            Usuario? devedor = null;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.nome == nomeDevedor)
                {
                    devedor = usuario;
                }
            }

            if (devedor == null)
            {
                MessageBox.Show("Insira o devedor");
                return;
            }

            if (credor.nome == devedor.nome)
            {
                MessageBox.Show("Credor e Devedor devem ser diferentes!");
                return;
            }


            if (data > DateTime.Now)
            {
                MessageBox.Show("Data futura. Insira uma data válida.");
                return;
            }

            if(valor <= 0)
            {
                MessageBox.Show("Insira um valor positivo!");
                return;
            }

            if (devedor.senha != senha)
            {
                MessageBox.Show("Senha incorreta");
                return;
            }
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.usuarioCredor = credor;
            emprestimo.usuarioDevedor = devedor;
            emprestimo.valor = valor;
            emprestimo.data = data;
            emprestimos.Add(emprestimo);
            serializarEmprestimos();
            MessageBox.Show("Empréstimo criado com sucesso!");
        }
        public void criarUsuario(string nome, string senha)
        {
            CarregarUsuarios();

            bool usuarioExistente = false;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.nome == nome)
                {
                    usuarioExistente = true;
                    break;
                }
            }

            if (usuarioExistente)
            {
                MessageBox.Show("Usuário já existente!");
                return;
            }


            Usuario usuario1 = new Usuario();
            usuario1.nome = nome;
            usuario1.senha = senha;
            usuarios.Add(usuario1);
            SerializarUsuarios();
            MessageBox.Show("Usuário criado com sucesso!");
        }




        public void quitarEmprestimo(Emprestimo emprestimoSelecionado, string senhaCredor)
        {
            emprestimos.Remove(emprestimoSelecionado);
            serializarEmprestimos();
            MessageBox.Show("Empréstimo quitado com sucesso.");
            return;
        }

        public float obterValorAtualizado(Emprestimo emprestimoSelecionado)
        {
            return emprestimoSelecionado.valor * juros;
        }

        public List<Emprestimo>? obterEmprestimos(string nomeCredor, string nomeDevedor)
        {
            carregarEmprestimos();
            Usuario? credor = null;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.nome == nomeCredor)
                {
                    credor = usuario;
                }
            }

            if (credor == null)
            {
                MessageBox.Show("Insira um credor existente!");
                return null;
            }

            Usuario? devedor = null;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.nome == nomeDevedor)
                {
                    devedor = usuario;
                }
            }

            if (devedor == null)
            {
                MessageBox.Show("Insira um devedor existente!");
                return null;
            }

            if(credor.nome == devedor.nome)
            {
                MessageBox.Show("Credor e Devedor devem ser diferentes!");
                return null;
            }

            List<Emprestimo> emprestimosFiltrados = new List<Emprestimo>();

            foreach (Emprestimo emprestimo in emprestimos)
            {
                if (emprestimo.usuarioCredor.nome == nomeCredor && emprestimo.usuarioDevedor.nome == nomeDevedor)
                {
                    emprestimosFiltrados.Add(emprestimo);
                }
            }
            return emprestimosFiltrados;
        }




        private void SerializarUsuarios()
        {
            using (TextWriter arquivo = new StreamWriter("usuarios.xml"))
            {
                XmlSerializer obj = new XmlSerializer(usuarios.GetType());
                obj.Serialize(arquivo, usuarios);
            }
        }

        public void CarregarUsuarios()
        {
            if (File.Exists("usuarios.xml"))
            {
                using (TextReader arquivo = new StreamReader("usuarios.xml"))
                {
                    XmlSerializer obj = new XmlSerializer(typeof(List<Usuario>));
                    usuarios = (List<Usuario>)obj.Deserialize(arquivo);
                }
            }
        }

        public void serializarEmprestimos()
        {
            using (TextWriter arquivo = new StreamWriter("emprestimos.xml"))
            {
                XmlSerializer obj = new XmlSerializer(emprestimos.GetType());
                obj.Serialize(arquivo, emprestimos);
            }
        }

        public void carregarEmprestimos()
        {
            if (File.Exists("emprestimos.xml"))
            {
                using (TextReader arquivo = new StreamReader("emprestimos.xml"))
                {
                    XmlSerializer obj = new XmlSerializer(typeof(List<Emprestimo>));
                    emprestimos = (List<Emprestimo>)obj.Deserialize(arquivo);
                }
            }
        }
    }
}
