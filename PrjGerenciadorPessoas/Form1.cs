using SamAlvarenga.PrjHelloWorld.Models;

namespace PrjGerenciadorPessoas

{
    public partial class Form1 : Form
    {
        //declaramos class
        private Pessoa pessoa;
        private List<Pessoa> pessoas = new List<Pessoa>();  //Criando o objeto lista de pessoas 
        //list<Pessoa> é uma variável que consegue salvar várias informacões relacionada a pessoa. 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pessoa pessoinha = new Pessoa();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }

        private void btnVerPessoa_Click(object sender, EventArgs e)
        {
            //lblMensagem.Text = $"{pessoa.Nome} - {pessoa.getIdadeFormatada()}";
            //for (int contador = 0; contador < this.pessoa.Count; contador++)
            //{
            //  lblmensagem.Text = $*{lblMensagem.Text}\n{this.pessoa[contador].Nome}";
            //}


            foreach (var item in pessoas)
            {
                lblMensagem.Text = $"{lblMensagem.Text}\n {pessoa.Nome}";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DialogResult apagarLista = MessageBox.Show("Tem certeza que deseja limpar a lista de pessoas?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (apagarLista == DialogResult.Yes)
            {
                pessoas.Clear();
                lstPessoas.Items.Clear();

                txtIdade.Clear();
                txtNome.Clear();
                txtNome.Focus();

            }
        }

        private void btnCriarPessoa_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = String.Empty;
            try
            {
                string nome = txtNome.Text;
                int idade = Convert.ToInt32(txtIdade.Text);//pode lançar exception

                pessoa = new Pessoa(nome, idade);//atribuir
                this.pessoas.Add(pessoa);//Adicionar  pessoa
                lstPessoas.Items.Add(pessoa);//adicionar a pessoa criada na listBox

            }
            catch (FormatException)
            {
                lblMensagem.Text = "Apenas números podem ser utilizados no campo idade!";
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;

            }

            txtNome.Clear();
            txtIdade.Clear();
            txtIdade.Focus();

            MessageBox.Show("Pessoa adicionada com sucesso!", "info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblMensagem.Text = "Pessoa adicionada com sucesso!";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (lstPessoas.SelectedItems == null)
            {

                MessageBox.Show("Não há itens selecionar na lista",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblMensagem.Text = "Não há itens selecionados na lista";

            }
            else
            {
                lstPessoas.Item.Remove(lslPessoas.Selected)
            }


            private void txtNome_TextChanged(object sender, EventArgs e)
            {

            }

            private void txtIdade_TextChanged(object sender, EventArgs e)
            {

            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }