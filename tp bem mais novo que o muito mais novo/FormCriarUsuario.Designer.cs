namespace tp_muito_mais_novo_do_q_o_mais_novo
{
    partial class FormCriarUsuario
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
            lbNome = new Label();
            lbSenha = new Label();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            btnSalvarUsuario = new Button();
            SuspendLayout();
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNome.Location = new Point(71, 36);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(56, 21);
            lbNome.TabIndex = 0;
            lbNome.Text = "Nome:";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSenha.Location = new Point(71, 73);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(56, 21);
            lbSenha.TabIndex = 1;
            lbSenha.Text = "Senha:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(133, 36);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(230, 23);
            txtNome.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(133, 75);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(230, 23);
            txtSenha.TabIndex = 3;
            // 
            // btnSalvarUsuario
            // 
            btnSalvarUsuario.Location = new Point(71, 121);
            btnSalvarUsuario.Name = "btnSalvarUsuario";
            btnSalvarUsuario.Size = new Size(292, 23);
            btnSalvarUsuario.TabIndex = 4;
            btnSalvarUsuario.Text = "Criar Usuário";
            btnSalvarUsuario.UseVisualStyleBackColor = true;
            btnSalvarUsuario.Click += button1_Click;
            // 
            // FormCriarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 189);
            Controls.Add(btnSalvarUsuario);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(lbSenha);
            Controls.Add(lbNome);
            Name = "FormCriarUsuario";
            Text = "FormCriarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNome;
        private Label lbSenha;
        private TextBox txtNome;
        private TextBox txtSenha;
        private Button btnSalvarUsuario;
    }
}