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
    public partial class FormEmpresa : Form
    {
        public FormEmpresa()
        {
            InitializeComponent();


        }
        public void Inserir()
        {


            try
            {
                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO empresa (cnpj_emp, razaoSocial_emp, nomeFantasia_emp, situacaoCadastral_emp, regimeTributario_emp, dataInicio_emp, telefone_emp, capitalSocial_emp, endereco_emp, tipo_emp, porteEmpresa_emp, naturezaJuridica_emp, proprietario_emp, cpf_emp) VALUES (@cnpj, @razaoSocial, @nomeFantasia, @situacaoCadastral, @regimeTributario, @dataInicio, @telefone, @capitalSocial, @endereco, @tipo, @porteEmpresa, @naturezaJuridica, @proprietario, @cpf)");
                foreach (Empresa str in Program.empresas)
                {
                    comando.Parameters.AddWithValue("@cnpj", str.Cnpj.Trim());//O TRIM TIRA O ULTIMO ESPAÇAMENTO CASO TENHA
                    comando.Parameters.AddWithValue("@razaoSocial", str.RazaoSocial);
                    comando.Parameters.AddWithValue("@nomeFantasia", str.NomeFantasia);
                    comando.Parameters.AddWithValue("@situacaoCadastral", str.SituacaoCadastral);
                    comando.Parameters.AddWithValue("@regimeTributario", str.RegimeTributario);
                    comando.Parameters.AddWithValue("@dataInicio", str.DataInicio);
                    comando.Parameters.AddWithValue("@telefone", str.Telefone);
                    comando.Parameters.AddWithValue("@capitalSocial", str.CapitalSocial);
                    comando.Parameters.AddWithValue("@endereco", str.Endereco);
                    comando.Parameters.AddWithValue("@tipo", str.Tipo);
                    comando.Parameters.AddWithValue("@porteEmpresa", str.PorteEmpresa);
                    comando.Parameters.AddWithValue("@naturezaJuridica", str.NaturezaJuridica);
                    comando.Parameters.AddWithValue("@proprietario", str.Proprietario);
                    comando.Parameters.AddWithValue("@cpf", str.CPF);

                }
                Program.empresas.Clear();


                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Empresa Cadastrado com sucesso!");
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
                var comando = conexao.Comando("SELECT * FROM Empresa");
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
            try
            {
                string cnpj = txt_cnpj.Text;
                string razaoSocial = txt_razaoSocial.Text;
                string nomeFantasia = txt_nomeFantasia.Text;
                string situacaoCadastral = combo_situacaoCadastral.Text;
                string regimeTributario = "";

                if (btn_simplesNacional.Checked)
                {
                    regimeTributario = btn_simplesNacional.Text;
                }
                else
                {
                    regimeTributario = btn_lucroReal.Text;
                }

                DateTime dataInicio = Convert.ToDateTime(txt_dataInicio.Text);
                string telefone = txt_telefone.Text;
                double capitalSocial = Convert.ToDouble(txt_capital.Text);
                string endereco = combo_endereco.Text;
                string tipo = "";

                if (btn_matriz.Checked)
                {
                    tipo = btn_matriz.Text;
                }
                else
                {
                    tipo = btn_filial.Text;
                }

                string porteEmpresa = "";

                if (btn_pequeno.Checked)
                {
                    porteEmpresa = btn_pequeno.Text;
                }
                else if (btn_medio.Checked)
                {
                    porteEmpresa = btn_medio.Text;
                }
                else if (btn_grande.Checked)
                {
                    porteEmpresa = btn_grande.Text;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                string naturezaJuridica = combo_naturezaJuridica.Text;
                string proprietario = txt_proprietario.Text;
                string cpf = txt_cpf.Text;

                Empresa conexao = new Empresa(cnpj, razaoSocial, nomeFantasia, situacaoCadastral, regimeTributario, dataInicio, telefone, capitalSocial, endereco, tipo, porteEmpresa, naturezaJuridica, proprietario, cpf);
                Program.empresas.Add(conexao);





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
