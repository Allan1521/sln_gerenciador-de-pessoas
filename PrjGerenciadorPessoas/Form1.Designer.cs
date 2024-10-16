namespace PrjGerenciadorPessoas
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
            lstPessoas = new ListBox();
            btnGerarDoc = new Button();
            btnExcluirLista = new Button();
            pnlForm = new Panel();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            lblNome = new Label();
            txtIdade = new TextBox();
            txtNome = new TextBox();
            btnCriarPessoa = new Button();
            btnVerPessoa = new Button();
            lblIdade = new Label();
            lblMensagem = new Label();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // lstPessoas
            // 
            lstPessoas.FormattingEnabled = true;
            lstPessoas.ItemHeight = 15;
            lstPessoas.Location = new Point(549, 50);
            lstPessoas.Name = "lstPessoas";
            lstPessoas.Size = new Size(362, 259);
            lstPessoas.TabIndex = 16;
            lstPessoas.SelectedIndexChanged += lstPessoas_SelectedIndexChanged;
            // 
            // btnGerarDoc
            // 
            btnGerarDoc.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnGerarDoc.ForeColor = SystemColors.ActiveCaptionText;
            btnGerarDoc.Location = new Point(549, 315);
            btnGerarDoc.Name = "btnGerarDoc";
            btnGerarDoc.Size = new Size(196, 37);
            btnGerarDoc.TabIndex = 7;
            btnGerarDoc.Text = "&Gerar Documento";
            btnGerarDoc.UseVisualStyleBackColor = true;
            btnGerarDoc.Click += btnGerarDoc_Click;
            // 
            // btnExcluirLista
            // 
            btnExcluirLista.BackColor = Color.Red;
            btnExcluirLista.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluirLista.ForeColor = SystemColors.Window;
            btnExcluirLista.Location = new Point(787, 315);
            btnExcluirLista.Name = "btnExcluirLista";
            btnExcluirLista.Size = new Size(124, 44);
            btnExcluirLista.TabIndex = 8;
            btnExcluirLista.Text = "E&xcluir Lista";
            btnExcluirLista.UseVisualStyleBackColor = false;
            btnExcluirLista.Click += btnExcluirLista_Click;
            // 
            // pnlForm
            // 
            pnlForm.BorderStyle = BorderStyle.FixedSingle;
            pnlForm.Controls.Add(btnLimpar);
            pnlForm.Controls.Add(btnExcluir);
            pnlForm.Controls.Add(btnSalvar);
            pnlForm.Controls.Add(lblNome);
            pnlForm.Controls.Add(txtIdade);
            pnlForm.Controls.Add(txtNome);
            pnlForm.Controls.Add(btnCriarPessoa);
            pnlForm.Controls.Add(btnVerPessoa);
            pnlForm.Controls.Add(lblIdade);
            pnlForm.Location = new Point(23, 50);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(506, 302);
            pnlForm.TabIndex = 22;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.Window;
            btnLimpar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpar.Location = new Point(210, 256);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(285, 44);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "&Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.ForeColor = SystemColors.Window;
            btnExcluir.Location = new Point(51, 256);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(124, 44);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.ForeColor = SystemColors.ActiveCaptionText;
            btnSalvar.Location = new Point(371, 186);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(124, 44);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.HotTrack;
            lblNome.Location = new Point(12, 42);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(74, 28);
            lblNome.TabIndex = 25;
            lblNome.Text = "Nome:";
            // 
            // txtIdade
            // 
            txtIdade.BackColor = SystemColors.Info;
            txtIdade.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdade.Location = new Point(111, 101);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 34);
            txtIdade.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Info;
            txtNome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(111, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(371, 34);
            txtNome.TabIndex = 0;
            // 
            // btnCriarPessoa
            // 
            btnCriarPessoa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCriarPessoa.Location = new Point(51, 186);
            btnCriarPessoa.Name = "btnCriarPessoa";
            btnCriarPessoa.Size = new Size(124, 44);
            btnCriarPessoa.TabIndex = 3;
            btnCriarPessoa.Text = "&Criar Pessoa";
            btnCriarPessoa.UseVisualStyleBackColor = true;
            btnCriarPessoa.Click += btnCriarPessoa_Click;
            // 
            // btnVerPessoa
            // 
            btnVerPessoa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerPessoa.ForeColor = SystemColors.ActiveCaptionText;
            btnVerPessoa.Location = new Point(210, 186);
            btnVerPessoa.Name = "btnVerPessoa";
            btnVerPessoa.Size = new Size(124, 44);
            btnVerPessoa.TabIndex = 3;
            btnVerPessoa.Text = "&Ver Pessoa";
            btnVerPessoa.UseVisualStyleBackColor = true;
            btnVerPessoa.Click += btnVerPessoa_Click;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdade.ForeColor = SystemColors.HotTrack;
            lblIdade.Location = new Point(17, 107);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(69, 28);
            lblIdade.TabIndex = 20;
            lblIdade.Text = "Idade:";
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensagem.ForeColor = SystemColors.HotTrack;
            lblMensagem.Location = new Point(38, 384);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 28);
            lblMensagem.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 487);
            Controls.Add(pnlForm);
            Controls.Add(btnExcluirLista);
            Controls.Add(btnGerarDoc);
            Controls.Add(lstPessoas);
            Controls.Add(lblMensagem);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Gerenciador de Pessoas";
            Load += Form1_Load;
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lstPessoas;
        private Button btnGerarDoc;
        private Button btnExcluirLista;
        private Panel pnlForm;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Label lblNome;
        private TextBox txtIdade;
        private TextBox txtNome;
        private Button btnCriarPessoa;
        private Button btnVerPessoa;
        private Label lblIdade;
        private Label lblMensagem;
    }
}