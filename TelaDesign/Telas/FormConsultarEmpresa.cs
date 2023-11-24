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
    public partial class FormConsultarEmpresa : Form
    {
        public FormConsultarEmpresa()
        {
            InitializeComponent();
            Consultar();
            foreach (Empresa str in Program.empresasLista)
            {
                dataGridView1.Rows.Add(str.Cnpj, str.RazaoSocial, str.NomeFantasia, str.SituacaoCadastral, str.RegimeTributario, str.DataInicio, str.Telefone, str.CapitalSocial, str.Endereco, str.Tipo, str.PorteEmpresa, str.NaturezaJuridica, str.Proprietario, str.CPF);
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
                    Empresa conexao1 = new Empresa(leitor.GetString("cnpj_emp"), leitor.GetString("razaoSocial_emp"), leitor.GetString("nomeFantasia_emp"), leitor.GetString("situacaoCadastral_emp"), leitor.GetString("regimeTributario_emp"), Convert.ToDateTime(leitor.GetString("dataInicio_emp")), leitor.GetString("telefone_emp"), Convert.ToDouble(leitor.GetString("capitalSocial_emp")), leitor.GetString("endereco_emp"), leitor.GetString("tipo_emp"), leitor.GetString("porteEmpresa_emp"), leitor.GetString("naturezaJuridica_emp"), leitor.GetString("proprietario_emp"), leitor.GetString("cpf_emp"));
                    Program.empresasLista.Add(conexao1);
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
