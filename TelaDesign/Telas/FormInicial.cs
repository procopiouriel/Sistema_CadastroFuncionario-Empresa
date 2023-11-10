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
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
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
            try
            {
                string nome = txt_nome.Text;
                string cpf = txt_cpf.Text;
                string rg = txt_rg.Text;
                DateTime dataNascimento = Convert.ToDateTime(txt_dataNascimento.Text);
                string estadoCivil = txt_estadoCivil.Text;
                string telefone = txt_telefone.Text;
                string email = txt_email.Text;
                string endereco = txt_endereco.Text;
                double salario = Convert.ToDouble(txt_salario.Text);
                string funcao = txt_funcao.Text;

                if (nome == "" || cpf == "" || rg == "" || dataNascimento == null || telefone == "" || email == "" || endereco == "" || salario == null || funcao == "")
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    if (Validador.CPF(cpf) == true)
                    {
                        Funcionario conexao = new Funcionario(nome, cpf, rg, dataNascimento, estadoCivil, telefone, email, endereco, salario, funcao);
                        Program.funcionarios.Add(conexao);
                        MessageBox.Show("Salvo!");
                    }
                    else
                    {
                        MessageBox.Show("CPF FALSO");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
