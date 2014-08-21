using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; // SQLite ADO.NET Provider
using System.IO; 


namespace DAGrabSkypeMessages
{
    public partial class Form1 : Form
    {
        // Cria conexão SQLite
        static SQLiteConnection conn;

        // Cria Adaptadores SQL
        private SQLiteDataAdapter da1;
        private SQLiteDataAdapter da2;

        // Comandos
        private SQLiteCommand contatos;
        private SQLiteDataReader rcontatos;
        private SQLiteCommand menssagem;
        private SQLiteDataReader rmenssagem;

        // Cria SQL para Buscas
        const string sql1 = "select " +
                            "convo_id NConversa, " +
                            "from_dispname De, " +
                            "dialog_partner as Para, " +
                            "body_xml as Menssagem, " +
                            "strftime('%d/%m/%Y %H:%M:%S', datetime(timestamp, 'unixepoch')) as Data " +
                            "from Messages " +
                            "where body_xml is not null " +
                            "Order by convo_id";

        const string sql2 = "Select " +
                            "id AS ID, " +
                            "fullname as Nome, " +
                            "skypename as Skype " +
                            "from Contacts " +
                            "order by id ";

        // Define local do Skype
        static string local =
                      Convert.ToString(Environment.ExpandEnvironmentVariables("%AppData%\\Skype"));
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            // Cria conexão com o SQLLIte
            string conexao = local + "\\" + cContas.Text + "\\main.db";                   


            // Cria String de conexão
            conn = new SQLiteConnection("Data Source=" + conexao);

            try
            {
                // Conecta ao banco de dados;

                conn.Open();

                // Cria Set de dados;
                DataSet ds1 = new DataSet();
                da1 = new SQLiteDataAdapter(sql1, conn);
                da1.Fill(ds1);
                Grid2.DataSource = ds1.Tables[0].DefaultView;

                // Define tamanho de colunas
                DataGridViewColumn Coluna1 = Grid2.Columns[0];
                Coluna1.Width = 70;

                DataGridViewColumn Coluna2 = Grid2.Columns[1];
                Coluna2.Width = 120;

                DataGridViewColumn Coluna3 = Grid2.Columns[2];
                Coluna3.Width = 120;

                DataGridViewColumn Coluna4 = Grid2.Columns[3];
                Coluna4.Width = 150;

                DataGridViewColumn Coluna5 = Grid2.Columns[4];
                Coluna5.Width = 130;

                // Cria Set de dados
                DataSet ds2 = new DataSet();
                da2 = new SQLiteDataAdapter(sql2, conn);
                da2.Fill(ds2);
                Grid1.DataSource = ds2.Tables[0].DefaultView;

                // Define tamanho dasw counas
                DataGridViewColumn column0 = Grid1.Columns[0];
                column0.Width = 60;

                DataGridViewColumn column1 = Grid1.Columns[1];
                column1.Width = 140;

                DataGridViewColumn column2 = Grid1.Columns[2];
                column2.Width = 180;


            }
            catch (Exception)
            {
                // Exibe menssagem de erro
                string erro = "Erro! Não foi possivel ler o banco de dados.\n" +
                              "Verifique se o Skype está aberto e Feche.\n\n";
                              
                MessageBox.Show(erro, "Erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // Define local das contas
            string path = local;

            foreach (string s in Directory.GetDirectories(path))
            {
                // Recupera diretorio de contas do Skype
                string login = s.Remove(0, path.Length);
                if ((login != "\\Content") & (login != "\\DataRv") &
                    (login != "\\Pictures") & (login != "\\shared_dynco") &
                    (login != "\\shared_httpfe") & (login != "\\My Skype Received Files"))
                {
                    cContas.Items.Add(login.Replace("\\", ""));
                }
            }

            // Cria tabulação
            var tabs = new String(' ', 15);

            // Define informações na barra de tarefas;
            toolLabel1.Text = "DA - Skype Grab Message/Contact List - V1.0 - Betha " + tabs;
            toolLabel2.Text = Convert.ToString(Environment.MachineName) + tabs;
            toolLabel3.Text = Environment.UserName + tabs;
            toolLabel4.Text = Convert.ToString(Environment.OSVersion) + tabs;
            toolLabel5.Text = Convert.ToString(Environment.Version);

        }   

        private void desenvolvimentoAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria Menssagem sobre
             string  msg = "Powered by Desenvolvimento Aberto\n\n" + 
                        "Autor: Ricardo Mantovani\n" + 
                        "E-mail: desenvolvimento.aberto@live.com\n" + 
                        "Versão: 1.0 - Betha\n\n";

            MessageBox.Show(msg, "Sobre",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void sairExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Fecha  aplicação
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: Exporta txt
            dlgExportar.Filter = "Textos (*.txt)|*.txt";

            // Cria conteudo do texto
            string texto = "DA - Skype Grab Message/Contact List - V1.0 - Betha - Desenvolvimento Aberto\r\n\r\n" +
                           "Computador: " + Convert.ToString(Environment.MachineName) + "\r\n" +
                           "Usuário: " + Environment.UserName + "\r\n" +
                           "Sistema: " + Convert.ToString(Environment.OSVersion) + "\r\n" +
                           "Versão: " + Convert.ToString(Environment.Version) + "\r\n\r\n";

            // Lista de contatos
            texto += "****************************\r\n";
            texto += "**   Lista de Contatos:   **\r\n";
            texto += "****************************\r\n\r\n";

            // Retorna contatos
            
            try
            {
                contatos = new SQLiteCommand(sql2, conn);
                rcontatos = contatos.ExecuteReader();
           
               // Exibe retorno
               if (rcontatos.HasRows)
               {
                   while (rcontatos.Read())
                   {                    
                       string nskype = String.Empty;
                       string cnome =  String.Empty;

                       if (!rcontatos.IsDBNull(rcontatos.GetOrdinal("Skype"))) nskype = rcontatos.GetString(rcontatos.GetOrdinal("Skype"));
                       if (!rcontatos.IsDBNull(rcontatos.GetOrdinal("Nome"))) cnome = rcontatos.GetString(rcontatos.GetOrdinal("Nome"));
                    
                       texto += Convert.ToString(rcontatos.GetInt32(0)) + "\r\n";
                       texto += "Nome Skype: " +  nskype  + "\r\n";
                       texto += "Nome Completo: " + cnome + "\r\n\r\n";
                   }
               }

               // Lista de menssagens
               texto += "********************\r\n";
               texto += "**   Menssagens:  **\r\n";
               texto += "********************\r\n\r\n";
            }
            catch
            {
                MessageBox.Show("Primeiro você precisa verificar os dados da conta.", "Atenção!!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Retorna Menssagens
            try
            {
                menssagem = new SQLiteCommand(sql1, conn);
                rmenssagem = menssagem.ExecuteReader();

                // Exibe retorno
                if (rmenssagem.HasRows)
                {
                    while (rmenssagem.Read())
                    {
                        string mde = String.Empty;
                        string mpara = String.Empty;
                        string mmsg = String.Empty;

                        if (!rmenssagem.IsDBNull(rmenssagem.GetOrdinal("De"))) mde = rmenssagem.GetString(rmenssagem.GetOrdinal("De"));
                        if (!rmenssagem.IsDBNull(rmenssagem.GetOrdinal("Para"))) mpara = rmenssagem.GetString(rmenssagem.GetOrdinal("Para"));
                        if (!rmenssagem.IsDBNull(rmenssagem.GetOrdinal("Menssagem"))) mmsg = rmenssagem.GetString(rmenssagem.GetOrdinal("Menssagem"));

                        texto += Convert.ToString(rmenssagem.GetInt32(0)) + " \r\n";
                        texto += mde + " : " + mpara + " \r\n\r\n";
                        texto += Convert.ToString(rmenssagem.GetString(4)) + "  >>>>> " + mmsg + " \r\n";
                        texto += "----------------------------------------------------------------------------\r\n\r\n";
                    }
                }
                // Exibe dialogo para salvar arquivo
                if (dlgExportar.ShowDialog() == DialogResult.OK)
                {
                    // Grava um arquivo baseado na area de texto
                    using (StreamWriter gravar = new StreamWriter(dlgExportar.OpenFile()))
                    {
                        gravar.Write(texto);
                    }
                }
            }
            catch
            {
                // 
            }
        }       
    }
}
