
namespace Venda_Bovina
{
    partial class FormConsultarEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarEmpresa));
            panelCabecalho = new Panel();
            btnFechar = new Button();
            btnRestaurar = new Button();
            btnMaximizar = new Button();
            panelConteudo = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            panelCabecalho.SuspendLayout();
            panelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelCabecalho
            // 
            panelCabecalho.BackColor = Color.Goldenrod;
            panelCabecalho.Controls.Add(btnFechar);
            panelCabecalho.Controls.Add(btnRestaurar);
            panelCabecalho.Controls.Add(btnMaximizar);
            panelCabecalho.Dock = DockStyle.Top;
            panelCabecalho.Location = new Point(0, 0);
            panelCabecalho.Margin = new Padding(4, 3, 4, 3);
            panelCabecalho.Name = "panelCabecalho";
            panelCabecalho.Size = new Size(933, 46);
            panelCabecalho.TabIndex = 0;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.BackgroundImage = (Image)resources.GetObject("btnFechar.BackgroundImage");
            btnFechar.BackgroundImageLayout = ImageLayout.Center;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(883, 3);
            btnFechar.Margin = new Padding(4, 3, 4, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(47, 39);
            btnFechar.TabIndex = 0;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.BackgroundImage = (Image)resources.GetObject("btnRestaurar.BackgroundImage");
            btnRestaurar.BackgroundImageLayout = ImageLayout.Center;
            btnRestaurar.FlatAppearance.BorderSize = 0;
            btnRestaurar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnRestaurar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Location = new Point(776, 3);
            btnRestaurar.Margin = new Padding(4, 3, 4, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(47, 39);
            btnRestaurar.TabIndex = 0;
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackgroundImage = (Image)resources.GetObject("btnMaximizar.BackgroundImage");
            btnMaximizar.BackgroundImageLayout = ImageLayout.Center;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnMaximizar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Location = new Point(830, 3);
            btnMaximizar.Margin = new Padding(4, 3, 4, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(47, 39);
            btnMaximizar.TabIndex = 0;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(dataGridView1);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(0, 46);
            panelConteudo.Margin = new Padding(4, 3, 4, 3);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(933, 567);
            panelConteudo.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14 });
            dataGridView1.Location = new Point(0, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(933, 564);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "CNPJ";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Razão Social";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Nome Fantasia";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Situação Cadastral";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Regime Tributario";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Data Inicio";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Telefone";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Capital Social";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Endereço";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Tipo";
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "Porte Empresa";
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "Natureza Juridica";
            Column12.Name = "Column12";
            // 
            // Column13
            // 
            Column13.HeaderText = "Proprietario";
            Column13.Name = "Column13";
            // 
            // Column14
            // 
            Column14.HeaderText = "CPF";
            Column14.Name = "Column14";
            // 
            // FormConsultarEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 613);
            Controls.Add(panelConteudo);
            Controls.Add(panelCabecalho);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormConsultarEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelCabecalho.ResumeLayout(false);
            panelConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }


        #region Windows Form Designer generated code
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelConteudo;

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
    }
}