using Allan1521.PrjHelloWord.Models;
using System.Text.Json;

namespace PrjGerenciadorPessoas
{
    public partial class Form1 : Form
    {
        //declaramos class
        private Pessoa pessoa;
        private List<Pessoa> pessoas = new List<Pessoa>();  //Criando o objeto lista de pessoas 
        //list<Pessoa> � uma vari�vel que consegue salvar v�rias informac�es relacionada a pessoa. 
        public Form1()
        {
            InitializeComponent();
            lstPessoas.DisplayMember = "Nome";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_FormRelatorio.Text = "TXT";
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
        //BOT�O LIMPAR CAIXAS DADOS DA PESSOAS
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
                int idade = Convert.ToInt32(txtIdade.Text);//pode lan�ar exception

                pessoa = new Pessoa(nome, idade);//atribuir
                this.pessoas.Add(pessoa);//Adicionar  pessoa
                lstPessoas.Items.Add(pessoa);//adicionar a pessoa criada na listBox

            }
            catch (FormatException)
            {
                MessageBox.Show("Apenas n�meros podem ser utilizados no campo idade!", "Campo Inv�lido", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            //    MessageBox.Show("N�o h� itens selecionar na lista",
            //        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    lblMensagem.Text = "N�o h� itens selecionados na lista";

            //}
            //else
            //{
            //    lstPessoas.Item.Remove(lslPessoas.Selected);
            //}

            DialogResult apagarDaLista = MessageBox.Show($"Tem certeza que deseja excluir {lstPessoas.SelectedItem.ToString()} da lista?", "Aten��o", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (apagarDaLista == DialogResult.Yes)
            {
                lstPessoas.Items.Remove(lstPessoas.SelectedItem); //Remover pessoa da lisBox
                lstPessoas.SelectedItem = null; //remover da lista de pessoas 
                ResetForm();
            }
        }
        //BOT�O DE ATUALIZAR E SALVAR PESSOA
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lstPessoas.SelectedItem != null) //verificar se h� um item na lista 
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
            DialogResult ApagarLista = MessageBox.Show("Tem certeza que deseja limpar a lista de pessoas?", "Aten��o", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

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

            lstPessoas.SelectedItem = null; //desmarcando a sele��o 
            btnSalvar.Enabled = false;      //deixar inativo o bot�o
            btnVerPessoa.Enabled = false;   //deixar inativo o bot�o
            btnExcluir.Enabled = false;     //deixar inativo o bot�o
        }

        private void btnGerarTxt_Click(object sender, EventArgs e)
        {
            //    string conteudoArquivo = $"Nome: {this.pessoa.Nome} - Idade: {this.pessoa.getIdadeFormatada()}";

            try //� onde voc� coloca o c�digo que pode gerar uma exce��o.
                //Se tudo correr bem, o c�digo dentro do bloco try
                //ser� executado normalmente e o bloco catch ser� ignorado.
            {
                if (cmb_FormRelatorio.Text == "TXT")
                {
                    gerarRelatorio(SerializarParaTxt());
                }
                else
                {
                    gerarRelatorio(SerializarParaJson());
                }
                
                    
              
            }
            catch (DirectoryNotFoundException ex) // � onde voc� coloca o c�digo
                                                  // que ser� executado caso ocorra uma exce��o no
                                                  // bloco try. O tipo de exce��o que cada bloco catch captura �
                                                  // especificado entre par�nteses.
            {

                MessageBox.Show("Houve um erro na cria��o do relat�rio. Pasta n�o encontrada!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void gerarRelatorio(string conteudo)
        {
            try
            {
                File.WriteAllText("relatorio/relatorio.txt", conteudo);


                MessageBox.Show($"Relat�tio gerado com sucesso no formato {cmb_FormRelatorio.Text}", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();

            }
            catch  (DirectoryNotFoundException ex) 
            {
                MessageBox.Show($"Houve um erro na cria��o do relat�rio. Pasta n�o encontrada!");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            
            }
                    
        }
        private string SerializarParaTxt()
        {
            //lstPessoas.Items //total de pessoas
            //lac�o de repeti��o

            Pessoa pessoa;
            string linha = "";

            for (int i = 0; i < lstPessoas.Items.Count; i++)
            {
                pessoa = (Pessoa)lstPessoas.Items[i]; //casting � pra confirma que o objeto pessoa,
                                                      //jogando tudo relacionado a pessoas dentro da
                                                      //vari�vel pessoa 
                linha = $"{linha}" + $"{pessoa.Nome} - {pessoa.getIdadeFormatada()}\n";
            }
            return linha;
            //File.WriteAllText("relatorio/relatorio.txt", linha);
            //MessageBox.Show("Relat�rio gerado com sucesso!", "Info",
            //MessageBoxButtons.OK, MessageBoxIcon.Information);
            //ResetForm();

        }
        private string SerializarParaJson()
        {
            //lstPessoas.Items //total de pessoas
            //lac�o de repeti��o


            string json = "";
            Pessoa pessoa;
            
            List<Pessoa> listaPessoas;  //declarando uma vari�vel do tipo de pessoas

            listaPessoas = new List<Pessoa>();  //instanciando uma lista de pessoas e atribuindo � vari�vel

            for (int i = 0; i < lstPessoas.Items.Count; i++)
            {
                pessoa = (Pessoa)lstPessoas.Items[i]; //casting
                listaPessoas.Add(pessoa);
            }
            json = JsonSerializer.Serialize(listaPessoas,
                new JsonSerializerOptions { WriteIndented = true }); // � pra fazer a indeta��o do texto
                                                                     // deixando organizado linha a limha
            return json;
        }
                
    }

}

