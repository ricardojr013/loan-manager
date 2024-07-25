namespace tp_bem_mais_novo_que_o_muito_mais_novo
{
    partial class QuitarEmprestimoForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbDevedor = new ComboBox();
            lbDevedor = new Label();
            cbCredor = new ComboBox();
            lbCredor = new Label();
            btnPesquisar = new Button();
            dataGridView1 = new DataGridView();
            lbSenha = new Label();
            txtSenha = new TextBox();
            btnQuitarEmprestimo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbDevedor
            // 
            cbDevedor.FormattingEnabled = true;
            cbDevedor.Location = new Point(343, 32);
            cbDevedor.Name = "cbDevedor";
            cbDevedor.Size = new Size(121, 23);
            cbDevedor.TabIndex = 7;
            cbDevedor.Click += cbDevedor_Click;
            // 
            // lbDevedor
            // 
            lbDevedor.AutoSize = true;
            lbDevedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDevedor.Location = new Point(265, 34);
            lbDevedor.Name = "lbDevedor";
            lbDevedor.Size = new Size(72, 21);
            lbDevedor.TabIndex = 6;
            lbDevedor.Text = "Devedor:";
            // 
            // cbCredor
            // 
            cbCredor.FormattingEnabled = true;
            cbCredor.Location = new Point(102, 34);
            cbCredor.Name = "cbCredor";
            cbCredor.Size = new Size(121, 23);
            cbCredor.TabIndex = 5;
            cbCredor.Click += cbCredor_Click;
            // 
            // lbCredor
            // 
            lbCredor.AutoSize = true;
            lbCredor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCredor.Location = new Point(24, 34);
            lbCredor.Name = "lbCredor";
            lbCredor.Size = new Size(61, 21);
            lbCredor.TabIndex = 4;
            lbCredor.Text = "Credor:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(24, 72);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(440, 23);
            btnPesquisar.TabIndex = 8;
            btnPesquisar.Text = "Pesquisar empréstimos";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(440, 193);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbSenha.Location = new Point(24, 335);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(56, 21);
            lbSenha.TabIndex = 10;
            lbSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(86, 333);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 11;
            // 
            // btnQuitarEmprestimo
            // 
            btnQuitarEmprestimo.Location = new Point(214, 333);
            btnQuitarEmprestimo.Name = "btnQuitarEmprestimo";
            btnQuitarEmprestimo.Size = new Size(129, 23);
            btnQuitarEmprestimo.TabIndex = 12;
            btnQuitarEmprestimo.Text = "Quitar Empréstimo";
            btnQuitarEmprestimo.UseVisualStyleBackColor = true;
            btnQuitarEmprestimo.Click += btnQuitarEmprestimo_Click_1;
            // 
            // QuitarEmprestimoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 385);
            Controls.Add(btnQuitarEmprestimo);
            Controls.Add(txtSenha);
            Controls.Add(lbSenha);
            Controls.Add(dataGridView1);
            Controls.Add(btnPesquisar);
            Controls.Add(cbDevedor);
            Controls.Add(lbDevedor);
            Controls.Add(cbCredor);
            Controls.Add(lbCredor);
            Name = "QuitarEmprestimoForm";
            Text = "QuitarEmprestimoForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDevedor;
        private Label lbDevedor;
        private ComboBox cbCredor;
        private Label lbCredor;
        private Button btnPesquisar;
        private DataGridView dataGridView1;
        private Label lbSenha;
        private TextBox txtSenha;
        private Button btnQuitarEmprestimo;
    }
}