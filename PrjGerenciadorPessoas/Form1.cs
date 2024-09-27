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
            for(int contador = 0; contador < this.pessoas.Count; contador++)
            {
                lblMensagem.Text = $"{lblMensagem.Text}\n {this.pessoas[contador].Nome}";
            }
            foreach (var item in pessoas)
            {
                lblMensagem.Text = $"{lblMensagem.Text}\n {pessoa.Nome}";
            }
        }

        private void btnCriarPessoa_Click(object sender, EventArgs e)
        {   
            lblMensagem.Text = String.Empty;
            //try
            //{
                 string nome = txtNome.Text;
                 int idade = Convert.ToInt32(txtIdade.Text);//pode lançar exception

                pessoa = new Pessoa(nome, idade);//atribuir
                
                this.pessoas.Add(pessoa);//Adicionar  pessoa
                                    
                           }
            //catch (Exception ex)
            //{
            //    lblMensagem.Text = ex.Message;
                
            //}

            txtNome.Clear(); 
            txtIdade.Clear();
            txtIdade.Focus();
        }
      
        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

    }
}