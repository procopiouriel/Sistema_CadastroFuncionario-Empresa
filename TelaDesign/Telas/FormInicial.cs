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


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FormFuncionario tela = new FormFuncionario();
            this.Visible = false;
            tela.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormEmpresa tela = new FormEmpresa();
            this.Visible = false;
            tela.ShowDialog();
        }

        private void btnVendas_Click_1(object sender, EventArgs e)
        {
            FormConsultarFuncionario tela = new FormConsultarFuncionario();
            this.Visible = false;
            tela.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormConsultarEmpresa tela = new FormConsultarEmpresa();
            this.Visible = false;
            tela.ShowDialog();
        }
    }
}
