
namespace Venda_Bovina
{
    partial class FormEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpresa));
            panelCabecalho = new Panel();
            btnFechar = new Button();
            btnRestaurar = new Button();
            btnMaximizar = new Button();
            panelMenu = new Panel();
            panelConteudo = new Panel();
            txt_cpf = new TextBox();
            txt_proprietario = new TextBox();
            btn_grande = new RadioButton();
            btn_medio = new RadioButton();
            btn_pequeno = new RadioButton();
            btn_filial = new RadioButton();
            btn_matriz = new RadioButton();
            txt_telefone = new MaskedTextBox();
            btn_lucroReal = new RadioButton();
            btn_simplesNacional = new RadioButton();
            combo_situacaoCadastral = new ComboBox();
            combo_endereco = new ComboBox();
            combo_naturezaJuridica = new ComboBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            btnVendas = new Button();
            txt_capital = new TextBox();
            txt_dataInicio = new TextBox();
            txt_nomeFantasia = new TextBox();
            txt_razaoSocial = new TextBox();
            txt_cnpj = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label11 = new Label();
            panelCabecalho.SuspendLayout();
            panelConteudo.SuspendLayout();
            SuspendLayout();
            // 
            // panelCabecalho
            // 
            panelCabecalho.BackColor = Color.Goldenrod;
            panelCabecalho.Controls.Add(label11);
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
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(37, 46, 59);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 46);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(339, 567);
            panelMenu.TabIndex = 1;
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(txt_cpf);
            panelConteudo.Controls.Add(txt_proprietario);
            panelConteudo.Controls.Add(btn_grande);
            panelConteudo.Controls.Add(btn_medio);
            panelConteudo.Controls.Add(btn_pequeno);
            panelConteudo.Controls.Add(btn_filial);
            panelConteudo.Controls.Add(btn_matriz);
            panelConteudo.Controls.Add(txt_telefone);
            panelConteudo.Controls.Add(btn_lucroReal);
            panelConteudo.Controls.Add(btn_simplesNacional);
            panelConteudo.Controls.Add(combo_situacaoCadastral);
            panelConteudo.Controls.Add(combo_endereco);
            panelConteudo.Controls.Add(combo_naturezaJuridica);
            panelConteudo.Controls.Add(label15);
            panelConteudo.Controls.Add(label14);
            panelConteudo.Controls.Add(label13);
            panelConteudo.Controls.Add(label12);
            panelConteudo.Controls.Add(btnVendas);
            panelConteudo.Controls.Add(txt_capital);
            panelConteudo.Controls.Add(txt_dataInicio);
            panelConteudo.Controls.Add(txt_nomeFantasia);
            panelConteudo.Controls.Add(txt_razaoSocial);
            panelConteudo.Controls.Add(txt_cnpj);
            panelConteudo.Controls.Add(label10);
            panelConteudo.Controls.Add(label9);
            panelConteudo.Controls.Add(label8);
            panelConteudo.Controls.Add(label7);
            panelConteudo.Controls.Add(label6);
            panelConteudo.Controls.Add(label5);
            panelConteudo.Controls.Add(label4);
            panelConteudo.Controls.Add(label3);
            panelConteudo.Controls.Add(label1);
            panelConteudo.Controls.Add(label2);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(339, 46);
            panelConteudo.Margin = new Padding(4, 3, 4, 3);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(594, 567);
            panelConteudo.TabIndex = 2;
            // 
            // txt_cpf
            // 
            txt_cpf.Location = new Point(434, 427);
            txt_cpf.Name = "txt_cpf";
            txt_cpf.Size = new Size(154, 23);
            txt_cpf.TabIndex = 45;
            // 
            // txt_proprietario
            // 
            txt_proprietario.Location = new Point(226, 427);
            txt_proprietario.Name = "txt_proprietario";
            txt_proprietario.Size = new Size(138, 23);
            txt_proprietario.TabIndex = 44;
            // 
            // btn_grande
            // 
            btn_grande.AutoSize = true;
            btn_grande.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_grande.Location = new Point(405, 350);
            btn_grande.Name = "btn_grande";
            btn_grande.Size = new Size(69, 21);
            btn_grande.TabIndex = 43;
            btn_grande.TabStop = true;
            btn_grande.Text = "Grande";
            btn_grande.UseVisualStyleBackColor = true;
            // 
            // btn_medio
            // 
            btn_medio.AutoSize = true;
            btn_medio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_medio.Location = new Point(316, 350);
            btn_medio.Name = "btn_medio";
            btn_medio.Size = new Size(64, 21);
            btn_medio.TabIndex = 42;
            btn_medio.TabStop = true;
            btn_medio.Text = "Médio";
            btn_medio.UseVisualStyleBackColor = true;
            // 
            // btn_pequeno
            // 
            btn_pequeno.AutoSize = true;
            btn_pequeno.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_pequeno.Location = new Point(226, 350);
            btn_pequeno.Name = "btn_pequeno";
            btn_pequeno.Size = new Size(77, 21);
            btn_pequeno.TabIndex = 41;
            btn_pequeno.TabStop = true;
            btn_pequeno.Text = "Pequeno";
            btn_pequeno.UseVisualStyleBackColor = true;
            // 
            // btn_filial
            // 
            btn_filial.AutoSize = true;
            btn_filial.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_filial.Location = new Point(405, 311);
            btn_filial.Name = "btn_filial";
            btn_filial.Size = new Size(51, 21);
            btn_filial.TabIndex = 40;
            btn_filial.TabStop = true;
            btn_filial.Text = "Filial";
            btn_filial.UseVisualStyleBackColor = true;
            // 
            // btn_matriz
            // 
            btn_matriz.AutoSize = true;
            btn_matriz.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_matriz.Location = new Point(226, 311);
            btn_matriz.Name = "btn_matriz";
            btn_matriz.Size = new Size(63, 21);
            btn_matriz.TabIndex = 39;
            btn_matriz.TabStop = true;
            btn_matriz.Text = "Matriz";
            btn_matriz.UseVisualStyleBackColor = true;
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(226, 234);
            txt_telefone.Mask = "(00) 0000-0000";
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(351, 23);
            txt_telefone.TabIndex = 38;
            // 
            // btn_lucroReal
            // 
            btn_lucroReal.AutoSize = true;
            btn_lucroReal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lucroReal.Location = new Point(407, 157);
            btn_lucroReal.Name = "btn_lucroReal";
            btn_lucroReal.Size = new Size(172, 21);
            btn_lucroReal.TabIndex = 37;
            btn_lucroReal.TabStop = true;
            btn_lucroReal.Text = "Lucro Presumido ou Real";
            btn_lucroReal.UseVisualStyleBackColor = true;
            // 
            // btn_simplesNacional
            // 
            btn_simplesNacional.AutoSize = true;
            btn_simplesNacional.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_simplesNacional.Location = new Point(226, 160);
            btn_simplesNacional.Name = "btn_simplesNacional";
            btn_simplesNacional.Size = new Size(126, 21);
            btn_simplesNacional.TabIndex = 36;
            btn_simplesNacional.TabStop = true;
            btn_simplesNacional.Text = "Simples Nacional";
            btn_simplesNacional.UseVisualStyleBackColor = true;
            // 
            // combo_situacaoCadastral
            // 
            combo_situacaoCadastral.FormattingEnabled = true;
            combo_situacaoCadastral.Items.AddRange(new object[] { "Ativa", "Nula", "Suspensa", "Inapta", "Baixada" });
            combo_situacaoCadastral.Location = new Point(226, 121);
            combo_situacaoCadastral.Name = "combo_situacaoCadastral";
            combo_situacaoCadastral.Size = new Size(351, 23);
            combo_situacaoCadastral.TabIndex = 35;
            // 
            // combo_endereco
            // 
            combo_endereco.FormattingEnabled = true;
            combo_endereco.Items.AddRange(new object[] { "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)" });
            combo_endereco.Location = new Point(468, 275);
            combo_endereco.Name = "combo_endereco";
            combo_endereco.Size = new Size(120, 23);
            combo_endereco.TabIndex = 34;
            // 
            // combo_naturezaJuridica
            // 
            combo_naturezaJuridica.FormattingEnabled = true;
            combo_naturezaJuridica.Items.AddRange(new object[] { "EI - (Empresario Individual)", "MEI - (Microempreendedor Individual)", "Sociedade Anonima", "Sociedade Simples Limitada", "Sociedade Limitada Unipessoal" });
            combo_naturezaJuridica.Location = new Point(226, 389);
            combo_naturezaJuridica.Name = "combo_naturezaJuridica";
            combo_naturezaJuridica.Size = new Size(362, 23);
            combo_naturezaJuridica.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(371, 420);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(56, 30);
            label15.TabIndex = 30;
            label15.Text = "CPF:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(67, 420);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(137, 30);
            label14.TabIndex = 29;
            label14.Text = "Proprietario:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(14, 380);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(190, 30);
            label13.TabIndex = 28;
            label13.Text = "Natureza Juridica:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(44, 341);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(160, 30);
            label12.TabIndex = 27;
            label12.Text = "Porte Empresa:";
            // 
            // btnVendas
            // 
            btnVendas.BackColor = SystemColors.AppWorkspace;
            btnVendas.FlatAppearance.BorderSize = 0;
            btnVendas.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVendas.ForeColor = Color.Black;
            btnVendas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVendas.Location = new Point(228, 492);
            btnVendas.Margin = new Padding(4, 3, 4, 3);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(152, 45);
            btnVendas.TabIndex = 24;
            btnVendas.Text = "Cadastrar";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // txt_capital
            // 
            txt_capital.Location = new Point(226, 273);
            txt_capital.Name = "txt_capital";
            txt_capital.Size = new Size(126, 23);
            txt_capital.TabIndex = 21;
            // 
            // txt_dataInicio
            // 
            txt_dataInicio.Location = new Point(226, 195);
            txt_dataInicio.Name = "txt_dataInicio";
            txt_dataInicio.Size = new Size(351, 23);
            txt_dataInicio.TabIndex = 19;
            // 
            // txt_nomeFantasia
            // 
            txt_nomeFantasia.Location = new Point(226, 87);
            txt_nomeFantasia.Name = "txt_nomeFantasia";
            txt_nomeFantasia.Size = new Size(351, 23);
            txt_nomeFantasia.TabIndex = 16;
            // 
            // txt_razaoSocial
            // 
            txt_razaoSocial.Location = new Point(226, 48);
            txt_razaoSocial.Name = "txt_razaoSocial";
            txt_razaoSocial.Size = new Size(351, 23);
            txt_razaoSocial.TabIndex = 15;
            // 
            // txt_cnpj
            // 
            txt_cnpj.Location = new Point(226, 10);
            txt_cnpj.Name = "txt_cnpj";
            txt_cnpj.Size = new Size(351, 23);
            txt_cnpj.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(134, 303);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(63, 30);
            label10.TabIndex = 13;
            label10.Text = "Tipo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(359, 268);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(109, 30);
            label9.TabIndex = 12;
            label9.Text = "Endereço:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(53, 264);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(151, 30);
            label8.TabIndex = 11;
            label8.Text = "Capital Social:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(102, 225);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(102, 30);
            label7.TabIndex = 10;
            label7.Text = "Telefone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(79, 188);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(125, 30);
            label6.TabIndex = 9;
            label6.Text = "Data Inicio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(10, 149);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 30);
            label5.TabIndex = 8;
            label5.Text = "Regime Tributario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(5, 112);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(199, 30);
            label4.TabIndex = 7;
            label4.Text = "Situação Cadastral:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(40, 78);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 30);
            label3.TabIndex = 6;
            label3.Text = "Nome Fantasia:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(62, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 30);
            label1.TabIndex = 5;
            label1.Text = "Razão Social:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(134, 3);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 4;
            label2.Text = "CNPJ:";
            label2.Click += label2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(128, 64, 0);
            label11.Location = new Point(13, 9);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(187, 30);
            label11.TabIndex = 3;
            label11.Text = "Cadastro Empresa";
            // 
            // FormEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 613);
            Controls.Add(panelConteudo);
            Controls.Add(panelMenu);
            Controls.Add(panelCabecalho);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelCabecalho.ResumeLayout(false);
            panelCabecalho.PerformLayout();
            panelConteudo.ResumeLayout(false);
            panelConteudo.PerformLayout();
            ResumeLayout(false);
        }


        #region Windows Form Designer generated code
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelConteudo;

        #endregion

        private Label label2;
        private Label label3;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnVendas;
        private TextBox txt_capital;
        private TextBox txt_dataInicio;
        private TextBox txt_nomeFantasia;
        private TextBox txt_razaoSocial;
        private TextBox txt_cnpj;
        private RadioButton btn_lucroReal;
        private RadioButton btn_simplesNacional;
        private ComboBox combo_situacaoCadastral;
        private ComboBox combo_endereco;
        private ComboBox combo_naturezaJuridica;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox txt_cpf;
        private TextBox txt_proprietario;
        private RadioButton btn_grande;
        private RadioButton btn_medio;
        private RadioButton btn_pequeno;
        private RadioButton btn_filial;
        private RadioButton btn_matriz;
        private MaskedTextBox txt_telefone;
        private Label label11;
    }
}