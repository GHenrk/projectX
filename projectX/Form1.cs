namespace projectX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
       
        object listaPonto;

        Apontamento nvPonto = new Apontamento();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            string dataFormatada = data.ToString("dddd, dd MMMM yyyy");
            txbDate.Text = dataFormatada.ToUpper();
            criaLista();



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApontar_Click(object sender, EventArgs e)
        {

           
            try
            {
                int codigoOp = int.Parse(txbCodigoOp.Text);
                string codigoPeca = txbCodigoPeca.Text;
                int funcionario = int.Parse(txbFuncionario.Text);
                string maquina = Convert.ToString(cbMaquina.Text);
                int operacao = int.Parse(txbOperacao.Text);
                string observacao = txbObs.Text;

                nvPonto.setNumeroOp(codigoOp);
                nvPonto.setCodigoPeca(codigoPeca);
                nvPonto.setFuncionario(funcionario);
                nvPonto.setMaquina(maquina);
                nvPonto.setOperacao(operacao);
                nvPonto.setObservacao(observacao);

                //tem que criar algo para verificar se o apontamento já existe;
                //se não cria outro;
               

                //se tiver falso ele ativa.
                if (nvPonto.getAtivo() == false)
                {
                    nvPonto.ativaApontamento();
                    nvPonto.verificaStatus();
                    string status = nvPonto.getStatus();
                    DateTime data = nvPonto.getDataInico();

                    txbStatus.Text = nvPonto.getStatus().ToString();
                    txbStatus.ForeColor = Color.Green;
                    MessageBox.Show("Apontamento na OP: " + nvPonto.getNumeroOp() + " Iniciado em: " + data.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (nvPonto.getAtivo() == true && codigoOp != nvPonto.getNumeroOp())
                {
                    MessageBox.Show("Já existe um apontamento ativo!!!");
                }
                else if (nvPonto.getAtivo() == true && codigoOp == nvPonto.getNumeroOp())
                {
                    nvPonto.desativaApontamento();
                    nvPonto.verificaStatus();
                    string status = nvPonto.getStatus();
                    DateTime data = nvPonto.getDataFinalizado();
                    txbStatus.Text = nvPonto.getStatus();
                    txbStatus.ForeColor = Color.Black;
                    MessageBox.Show("Apontamento na OP: " + nvPonto.getNumeroOp() + " Finalizado em: " + data.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Algo deu errado, Insira todos os dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbCodigoOp.Clear();
            txbCodigoPeca.Clear();
            txbFuncionario.Clear();
            txbOperacao.Clear();
            txbObs.Clear();
            txbStatus.Clear();
            cbMaquina.Text = " ";
        }

        public void criaLista()
        {
            listaPonto = new List<object> { };
        }

        
    }
}