using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySqlConnector;

namespace ProjetoFinalTeste
{
    public partial class Form2 : Form
    {
      
        private string connectionString = "server=localhost;user=root;database=erp_db;password=";
        
        private int ?idSelecionado = null;
        public Form2()
        {
            InitializeComponent();

            lstFuncionario.View = View.Details;
            lstFuncionario.LabelEdit = true;
            lstFuncionario.AllowColumnReorder = true;
            lstFuncionario.FullRowSelect = true;
            lstFuncionario.GridLines = true;


            lstFuncionario.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("NOME", 200 ,HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("EMAIL",150 ,HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("TELEFONE", 100, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("CARGO", 100, HorizontalAlignment.Left);


            atualizaListagem();
        }

        private void lblFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txbNome.Text;
                string email = txbEmail.Text;
                string tel = mkTel.Text;
                string cargo = txbCargo.Text;

                //prepara conexao
                MySqlConnection conexao = new MySqlConnection();
                MySqlCommand cmd = new MySqlCommand();
                conexao.ConnectionString = connectionString;

                if(idSelecionado == null)
                {
                    try
                    {
                        conexao.Open();
                        cmd.Connection = conexao;

                        cmd.CommandText = "INSERT INTO funcionario (NOME,EMAIL,TELEFONE,CARGO) " +
                            "VALUES (@NOME,@EMAIL,@TELEFONE,@CARGO)";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@NOME", nome);
                        cmd.Parameters.AddWithValue("@EMAIL", email);
                        cmd.Parameters.AddWithValue("@TELEFONE", tel);
                        cmd.Parameters.AddWithValue("@CARGO", cargo);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cadastro Realizado com Sucesso!!!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("ERROR: \n" + ex, "ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                        
                } else
                {
                    try
                    {
                        //UPDATE
                        conexao.Open();
                        cmd.Connection = conexao;

                        cmd.CommandText = "UPDATE funcionario SET NOME=@NOME,EMAIL=@EMAIL,TELEFONE=@TELEFONE,CARGO=@CARGO " +
                                "WHERE idFunc=@ID";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@NOME", nome);
                        cmd.Parameters.AddWithValue("@EMAIL", email);
                        cmd.Parameters.AddWithValue("@TELEFONE", tel);
                        cmd.Parameters.AddWithValue("@CARGO", cargo);
                        cmd.Parameters.AddWithValue("@ID", idSelecionado);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("O Registro foi alterado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("ERROR: \n" + ex, "ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
               
                atualizaListagem();
                idSelecionado = null;
                txbNome.Text = String.Empty;
                txbEmail.Text = String.Empty;
                txbCargo.Text = String.Empty;
                mkTel.Text = String.Empty;
            }
               
            catch
            {
                MessageBox.Show("Por favor, verifique os dados inseridos!");
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //prepara conexao
            MySqlConnection conexao = new MySqlConnection(connectionString);

            try
            {

                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM funcionario WHERE nome LIKE @nome ORDER BY idFunc DESC";
                cmd.Connection = conexao;
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@NOME", "%" + txbBusca.Text + "%");
                MySqlDataReader respostaQuery = cmd.ExecuteReader();

                lstFuncionario.Items.Clear();

                while (respostaQuery.Read())
                {
                    string[] linhaLista =
                    {
                            respostaQuery.GetInt32(0).ToString(),
                            respostaQuery.GetString(1),
                            respostaQuery.GetString(2),
                            respostaQuery.GetString(3),
                            respostaQuery.GetString(4),
                        };

                    var linhaDoListView = new ListViewItem(linhaLista);
                    lstFuncionario.Items.Add(linhaDoListView);

                };
            }
            
            catch (Exception ex)
             {
                MessageBox.Show("Algo deu errado nessa operação! \n " + ex);
             }
             finally
                {
                    conexao.Close();
                }
           
        }

        private void atualizaListagem()
        {
            MySqlConnection conexao = new MySqlConnection(connectionString);
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM funcionario ORDER BY idFunc DESC";
                cmd.Connection = conexao;
                cmd.Prepare();

                MySqlDataReader resposta = cmd.ExecuteReader();

                lstFuncionario.Items.Clear();

                while (resposta.Read())
                {
                    string[] linhaLista =
                    {
                            resposta.GetInt32(0).ToString(),
                            resposta.GetString(1),
                            resposta.GetString(2),
                            resposta.GetString(3),
                            resposta.GetString(4),
                        };

                    var linhaDoListView = new ListViewItem(linhaLista);
                    lstFuncionario.Items.Add(linhaDoListView);

                };
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR: " + ex, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado nessa operação! \n " + ex);
            }
            finally
            {
                conexao.Close();
            }

        }

        private void lstFuncionario_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lstFuncionario.SelectedItems;

            foreach(ListViewItem item in itens_selecionados)
            {
                idSelecionado = Convert.ToInt32(item.SubItems[0].Text);
                txbNome.Text = item.SubItems[1].Text;
                txbEmail.Text = item.SubItems[2].Text;
                txbCargo.Text = item.SubItems[4].Text;
                mkTel.Text = item.SubItems[3].Text;

            }
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            idSelecionado = null;
            txbNome.Text = String.Empty;
            txbEmail.Text = String.Empty;
            txbCargo.Text = String.Empty;
            mkTel.Text = String.Empty;
        }
    }
}
