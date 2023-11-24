using AppGunaExemplo.Configuracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaDesign;

namespace Venda_Bovina
{
    public partial class FormConsultarFuncionario : Form
    {
        public FormConsultarFuncionario()
        {
            InitializeComponent();
            Consultar();
            foreach (Funcionario str in Program.funcionariosLista)
            {
                dataGridView1.Rows.Add(str.Nome, str.Cpf, str.Rg, str.DataNascimento, str.EstadoCivil, str.Telefone, str.Email, str.Endereco, str.Salario, str.Funcao);
            }

        }
        public void Inserir()
        {


            try
            {
                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO funcionario (nome_fun, cpf_fun, dataNascimento_fun, rg_fun, telefone_fun, email_fun, endereco_fun, estadoCivil_fun, funcao_fun, salario_fun) VALUES (@nome, @cpf, @dataNascimento, @rg, @telefone, @email, @endereco, @estadoCivil, @funcao, @salario)");
                foreach (Funcionario str in Program.funcionarios)
                {
                    comando.Parameters.AddWithValue("@nome", str.Nome.Trim());//O TRIM TIRA O ULTIMO ESPAÇAMENTO CASO TENHA
                    comando.Parameters.AddWithValue("@cpf", str.Cpf);
                    comando.Parameters.AddWithValue("@dataNascimento", str.DataNascimento);
                    comando.Parameters.AddWithValue("@rg", str.Rg);
                    comando.Parameters.AddWithValue("@telefone", str.Telefone);
                    comando.Parameters.AddWithValue("@email", str.Email);
                    comando.Parameters.AddWithValue("@endereco", str.Endereco);
                    comando.Parameters.AddWithValue("@estadoCivil", str.EstadoCivil);
                    comando.Parameters.AddWithValue("@funcao", str.Funcao);
                    comando.Parameters.AddWithValue("@salario", str.Salario);

                }
                Program.funcionarios.Clear();


                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Funcionario Cadastrado com sucesso!");
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM Funcionario");
                var leitor = comando.ExecuteReader();


                while (leitor.Read())
                {
                    Funcionario conexao1 = new Funcionario(leitor.GetString("nome_fun"), leitor.GetString("cpf_fun"), leitor.GetString("rg_fun"), Convert.ToDateTime(leitor.GetString("dataNascimento_fun")), leitor.GetString("estadoCivil_fun"), leitor.GetString("telefone_fun"), leitor.GetString("email_fun"), leitor.GetString("endereco_fun"), Convert.ToDouble(leitor.GetString("salario_fun")), leitor.GetString("funcao_fun"));
                    Program.funcionariosLista.Add(conexao1);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
