namespace tp_muito_mais_novo_do_q_o_mais_novo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbCredor = new Label();
            cbCredor = new ComboBox();
            cbDevedor = new ComboBox();
            lbDevedor = new Label();
            lbValor = new Label();
            txtValor = new TextBox();
            lbData = new Label();
            dateTimePicker1 = new DateTimePicker();
            lbSenha = new Label();
            txtSenha = new TextBox();
            btnCriarEmprestimo = new Button();
            dataGridView1 = new DataGridView();
            btnListarEmprestimos = new Button();
            menuStrip1 = new MenuStrip();
            criarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            quitarEmpréstimoToolStripMenuItem = new ToolStripMenuItem();
            lbTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbCredor
            // 
            lbCredor.AutoSize = true;
            lbCredor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCredor.Location = new Point(33, 76);
            lbCredor.Name = "lbCredor";
            lbCredor.Size = new Size(61, 21);
            lbCredor.TabIndex = 0;
            lbCredor.Text = "Credor:";
            // 
            // cbCredor
            // 
            cbCredor.FormattingEnabled = true;
            cbCredor.Location = new Point(100, 74);
            cbCredor.Name = "cbCredor";
            cbCredor.Size = new Size(121, 23);
            cbCredor.TabIndex = 1;
            // 
            // cbDevedor
            // 
            cbDevedor.FormattingEnabled = true;
            cbDevedor.Location = new Point(337, 74);
            cbDevedor.Name = "cbDevedor";
            cbDevedor.Size = new Size(121, 23);
            cbDevedor.TabIndex = 3;
            // 
            // lbDevedor
            // 
            lbDevedor.AutoSize = true;
            lbDevedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDevedor.Location = new Point(259, 76);
            lbDevedor.Name = "lbDevedor";
            lbDevedor.Size = new Size(72, 21);
            lbDevedor.TabIndex = 2;
            lbDevedor.Text = "Devedor:";
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbValor.Location = new Point(506, 76);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(49, 21);
            lbValor.TabIndex = 4;
            lbValor.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(561, 74);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 5;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbData.Location = new Point(33, 139);
            lbData.Name = "lbData";
            lbData.Size = new Size(45, 21);
            lbData.TabIndex = 6;
            lbData.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(100, 137);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbSenha.Location = new Point(358, 139);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(56, 21);
            lbSenha.TabIndex = 8;
            lbSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(420, 137);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 9;
            // 
            // btnCriarEmprestimo
            // 
            btnCriarEmprestimo.Location = new Point(542, 137);
            btnCriarEmprestimo.Name = "btnCriarEmprestimo";
            btnCriarEmprestimo.Size = new Size(119, 23);
            btnCriarEmprestimo.TabIndex = 10;
            btnCriarEmprestimo.Text = "Criar Empréstimo";
            btnCriarEmprestimo.UseVisualStyleBackColor = true;
            btnCriarEmprestimo.Click += btnCriarEmprestimo_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(628, 213);
            dataGridView1.TabIndex = 11;
            // 
            // btnListarEmprestimos
            // 
            btnListarEmprestimos.Location = new Point(33, 442);
            btnListarEmprestimos.Name = "btnListarEmprestimos";
            btnListarEmprestimos.Size = new Size(628, 23);
            btnListarEmprestimos.TabIndex = 12;
            btnListarEmprestimos.Text = "Listar Empréstimos";
            btnListarEmprestimos.UseVisualStyleBackColor = true;
            btnListarEmprestimos.Click += btnListarEmprestimos_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { criarUsuárioToolStripMenuItem, quitarEmpréstimoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(696, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // criarUsuárioToolStripMenuItem
            // 
            criarUsuárioToolStripMenuItem.Name = "criarUsuárioToolStripMenuItem";
            criarUsuárioToolStripMenuItem.Size = new Size(87, 20);
            criarUsuárioToolStripMenuItem.Text = "Criar Usuário";
            criarUsuárioToolStripMenuItem.Click += criarUsuárioToolStripMenuItem_Click_1;
            // 
            // quitarEmpréstimoToolStripMenuItem
            // 
            quitarEmpréstimoToolStripMenuItem.Name = "quitarEmpréstimoToolStripMenuItem";
            quitarEmpréstimoToolStripMenuItem.Size = new Size(119, 20);
            quitarEmpréstimoToolStripMenuItem.Text = "Quitar empréstimo";
            quitarEmpréstimoToolStripMenuItem.Click += quitarEmpréstimoToolStripMenuItem_Click;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitulo.Location = new Point(259, 21);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(172, 30);
            lbTitulo.TabIndex = 14;
            lbTitulo.Text = "Criar Empréstimo\r\n";
            lbTitulo.Click += lbTitulo_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 494);
            Controls.Add(lbTitulo);
            Controls.Add(btnListarEmprestimos);
            Controls.Add(dataGridView1);
            Controls.Add(btnCriarEmprestimo);
            Controls.Add(txtSenha);
            Controls.Add(lbSenha);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbData);
            Controls.Add(txtValor);
            Controls.Add(lbValor);
            Controls.Add(cbDevedor);
            Controls.Add(lbDevedor);
            Controls.Add(cbCredor);
            Controls.Add(lbCredor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCredor;
        private ComboBox cbCredor;
        private ComboBox cbDevedor;
        private Label lbDevedor;
        private Label lbValor;
        private TextBox txtValor;
        private Label lbData;
        private DateTimePicker dateTimePicker1;
        private Label lbSenha;
        private TextBox txtSenha;
        private Button btnCriarEmprestimo;
        private DataGridView dataGridView1;
        private Button btnListarEmprestimos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem criarUsuárioToolStripMenuItem;
        private Label lbTitulo;
        private ToolStripMenuItem quitarEmpréstimoToolStripMenuItem;
    }
}
