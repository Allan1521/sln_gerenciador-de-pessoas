using Allan1521.PrjHelloWord.Models;
using Allan1521.PrjHelloWord.Models;

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
            lstPessoas.DisplayMember = "Nome";
        }


        private void btnVerPessoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Nome: {pessoa.Nome}\n Idade: {pessoa.getIdadeFormatada()}", "Dados Pessoais", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //lblMensagem.Text = $"{pessoa.Nome} - {pessoa.getIdadeFormatada()}";
            //for (int contador = 0; contador < this.pessoa.Count; contador++)
            //{
            //  lblmensagem.Text = $*{lblMensagem.Text}\n{this.pessoa[contador].Nome}";
            //}


            //foreach (var item in pessoas)
            //{
            //    lblMensagem.Text = $"{lblMensagem.Text}\n {pessoa.Nome}";
            //}
        }
                    //BOTÃO LIMPAR CAIXAS DADOS DA PESSOAS
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ResetForm();
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
                MessageBox.Show("Apenas números podem ser utilizados no campo idade!", "Campo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;

            }
            txtNome.Clear();
            txtIdade.Clear();
            txtIdade.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            //if (lstPessoas.SelectedItems == null)
            //{

            //    MessageBox.Show("Não há itens selecionar na lista",
            //        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    lblMensagem.Text = "Não há itens selecionados na lista";

            //}
            //else
            //{
            //    lstPessoas.Item.Remove(lslPessoas.Selected);
            //}

            DialogResult apagarDaLista = MessageBox.Show($"Tem certeza que deseja excluir {lstPessoas.SelectedItem.ToString()} da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (apagarDaLista == DialogResult.Yes)
            {
                lstPessoas.Items.Remove(lstPessoas.SelectedItem); //Remover pessoa da lisBox
                lstPessoas.SelectedItem = null; //remover da lista de pessoas 
                ResetForm();
            }
        }
                    //BOTÃO DE ATUALIZAR E SALVAR PESSOA
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lstPessoas.SelectedItem != null) //verificar se há um item na lista 
            {
                this.pessoa = (Pessoa)lstPessoas.SelectedItem; //casting
                this.pessoa.Nome = txtNome.Text;
                this.pessoa.Idade = Convert.ToInt32(txtIdade.Text);
                lstPessoas.Items[lstPessoas.SelectedIndex] = this.pessoa;
                MessageBox.Show(" Dados atualizados com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
        }

        private void lstPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;

            if (lstPessoas.SelectedItem != null)
            {
                this.pessoa = (Pessoa)lstPessoas.SelectedItem; //Casting
                txtNome.Text = this.pessoa.Nome;
                txtIdade.Text = this.pessoa.Idade.ToString();
            }
        }

        private void btnExcluirLista_Click(object sender, EventArgs e)
        {
            DialogResult ApagarLista = MessageBox.Show("Tem certeza que deseja limpar a lista de pessoas?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (ApagarLista == DialogResult.Yes)
            {
                lstPessoas.Items.Clear();

                ResetForm();
            }
        }
        private void ResetForm()
        {
            txtIdade.Clear();
            txtNome.Clear();
            txtNome.Focus();

            lstPessoas.SelectedItem = null; //desmarcando a seleção 
            btnSalvar.Enabled = false;      //deixar inativo o botão
            btnVerPessoa.Enabled = false;   //deixar inativo o botão
            btnExcluir.Enabled = false;     //deixar inativo o botão
        }

        private void btnGerarDoc_Click(object sender, EventArgs e)
        {
        //    string conteudoArquivo = $"Nome: {this.pessoa.Nome} - Idade: {this.pessoa.getIdadeFormatada()}";

            try //É onde você coloca o código que pode gerar uma exceção.
                //Se tudo correr bem, o código dentro do bloco try
                //será executado normalmente e o bloco catch será ignorado.
            {
                gerarRelatorioLista();
                //File.WriteAllText("relatorio/relatorio.txt", conteudoArquivo);


                MessageBox.Show("Relatório gerado com sucesso", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
            }
            catch (DirectoryNotFoundException ex) // É onde você coloca o código
                                                  // que será executado caso ocorra uma exceção no
                                                  // bloco try. O tipo de exceção que cada bloco catch captura é
                                                  // especificado entre parênteses.
            {

                MessageBox.Show("Houve um erro na criação do relatório. Pasta não encontrada!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void gerarRelatorio(string conteudo)
        {
            File.WriteAllText("relatorio/relatorio.txt", conteudo);


            MessageBox.Show("Relatório gerado com sucesso!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetForm();
        }
        private void gerarRelatorioLista()
        {
            //lstPessoas.Items //total de pessoas
            //lacço de repetição

            Pessoa p;
            string linha = "";

            for (int i = 0; i < lstPessoas.Items.Count - 1; i++)
            {
                p = (Pessoa) lstPessoas.Items[i];
                linha = $"{linha}" + $"{p.Nome} - {p.getIdadeFormatada()}\n";
            }
            File.WriteAllText("relatorio/relatorio.txt", linha);


            MessageBox.Show("Relatório gerado com sucesso!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetForm();
        }
    }
   
}

