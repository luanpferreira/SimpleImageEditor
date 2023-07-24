using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Imagens
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=postgresql;Port=5432;Database=dados;User Id=admin;Password=admin;";
        int id_imagem;
        int isRBG;

        public void limparTextBox()
        {
            tbNome.Clear();
            tbCaminho.Clear();
            cbGrau.SelectedIndex = -1;
            cbLocalizacao.SelectedIndex = -1;
            pbImagem.Image = null;
            pbImagemOriginal = null;
            pbImagemModificada = null;
            lvValores.Items.Clear();
            lbEnd.Text = " ";
            lbNome.Text = " ";
            lbResolucao.Text = " ";
            lbAltura.Text = " ";
            lbLargura.Text = " ";
            lbLocalizacao.Text = " ";
            lbGrau.Text = " ";

        }

        public void imagemCinza()
        {
            btCinza.Enabled = false;
        }

        public void imagemRBG()
        {
      
        }

        public Form1()
        {
            InitializeComponent();
            PreencherListView();

        }

        private void tbGravar_Click(object sender, EventArgs e)
        {

        }

        private void tbGravar_MouseClick(object sender, MouseEventArgs e)
        {
            Imagem objImagem = new Imagem(tbNome.Text, tbCaminho.Text, cbLocalizacao.Text, cbGrau.Text);

            Bitmap imagem = new Bitmap(objImagem.Caminho);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            string commandText = "";

            bool isColorImage = (imagem.PixelFormat == PixelFormat.Format24bppRgb);

            if (isColorImage)
            {
                con.Open(); // Abre a conexao com o banco

                commandText = String.Format("INSERT INTO imagem(nome,caminho, localizacao, grau, rgb) " +
                                                "values('{0}','{1}', '{2}', '{3}' ,'{4}')", objImagem.Nome,
                                                objImagem.Caminho, objImagem.Localizacao, objImagem.Grau, 1);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Cadastro Inserido com Sucesso: " + objImagem.Nome);
                limparTextBox();
            }

            else
            {
                con.Open(); // Abre a conexao com o banco

                commandText = String.Format("INSERT INTO imagem(nome,caminho, localizacao, grau, rgb) " +
                                                "values('{0}','{1}', '{2}', '{3}' ,'{4}')", objImagem.Nome,
                                                objImagem.Caminho, objImagem.Localizacao, objImagem.Grau, 2);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close(); 
                MessageBox.Show("Cadastro Inserido com Sucesso: " + objImagem.Nome);
                limparTextBox();
            }

        }

        private void tbExibir_MouseClick(object sender, MouseEventArgs e)
        {
            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            DataTable dt = new DataTable(); // Objeto que pode conter tabelas

            string commandText = "SELECT * FROM imagem ORDER BY id";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
            {
                Adpt.Fill(dt);
            }

            dGV.DataSource = dt;

            con.Close();  // Fecha a Conexao com o banco  
        }

        private void dGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbNome.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[1].Value);
            tbCaminho.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[2].Value);
            
        }

        private void btAtualizar_MouseClick(object sender, MouseEventArgs e)
        {
            Imagem objImagem = new Imagem(tbNome.Text, tbCaminho.Text, cbLocalizacao.Text, cbGrau.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            string commandText = String.Format("UPDATE imagem SET nome = '" + objImagem.Nome + "', caminho = '" + objImagem.Caminho + "', grau = '" + objImagem.Grau + "', localizacao = '" + objImagem.Localizacao + "' WHERE id = " + id_imagem);
            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {

                pgsqlcommand.ExecuteNonQuery();
            }
            

            MessageBox.Show("Cadastro Atualizado com Sucesso: " + objImagem.Nome);

            limparTextBox();

        }

        private void btExcluir_MouseClick(object sender, MouseEventArgs e)
        {
            string nome = tbNome.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            string commandText = String.Format("DELETE FROM imagem WHERE nome = '{0}'", nome);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Cadastro Excluido com Sucesso!");

            limparTextBox();
        }

        private void btCarregar_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btSelecionar_MouseClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbCaminho.Text = openFileDialog1.FileName;
                Bitmap imagem = new Bitmap(openFileDialog1.FileName);
                pbImagem.Image = imagem;
            }
        }

        private void dGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            id_imagem = Convert.ToInt16(dGV.Rows[e.RowIndex].Cells[0].Value);
            isRBG = Convert.ToInt32(dGV.Rows[e.RowIndex].Cells[5].Value);

            dGV.CurrentRow.Selected = true;
            Imagem objImagem = new Imagem(Convert.ToString(dGV.Rows[e.RowIndex].Cells[1].Value), Convert.ToString(dGV.Rows[e.RowIndex].Cells[2].Value),
               Convert.ToString(dGV.Rows[e.RowIndex].Cells[3].Value), Convert.ToString(dGV.Rows[e.RowIndex].Cells[4].Value));
            Bitmap imagem = new Bitmap(objImagem.Caminho);
            pbImagem.Image = imagem;
            tbNome.Text = objImagem.Nome;
            tbCaminho.Text = objImagem.Caminho;
            cbLocalizacao.Text = objImagem.Localizacao;
            cbGrau.Text = objImagem.Grau;

        }

        private void btCinza_MouseClick(object sender, MouseEventArgs e)
        {
            if (pbImagemOriginal.Image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.");
                return;
            }

            Imagem objImagem = new Imagem(Convert.ToString(lbNome.Text), Convert.ToString(lbEnd.Text));
            Bitmap imagem = new Bitmap(pbImagemOriginal.Image);
            Bitmap imagemCinza = objImagem.transformarCinza(imagem);
            pbImagemModificada.Image = imagemCinza;

        }

        private void btExportar_MouseClick(object sender, MouseEventArgs e)
        {
            if (pbImagemModificada.Image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos de Imagem|*.png;*.jpg;*.bmp";
            saveFileDialog.Title = "Salvar Imagem";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap imagem = new Bitmap(pbImagemModificada.Image);
                imagem.Save(saveFileDialog.FileName);
                MessageBox.Show("Imagem salva com sucesso!");
            }
        }

        private void PreencherListView()
        {
            lvValores.Columns.Add("Métrica", 150).TextAlign = HorizontalAlignment.Center;
            lvValores.Columns.Add("Valor", 100).TextAlign = HorizontalAlignment.Center;
            lvValores.View = View.Details;

        }

        void InserirMedia(Imagem objImagem, Bitmap imagem)
        {
            string[] parametro = new string[2];

            parametro[0] = "Média";
            parametro[1] = objImagem.mean(imagem).ToString();

            lvValores.Items.Add(new ListViewItem(parametro));
        }

        void InserirDesvio(Imagem objImagem, Bitmap imagem)
        {
            string[] parametro = new string[2];

            parametro[0] = "Desvio Padrão";
            parametro[1] = Math.Round(objImagem.std(imagem),2).ToString();

            lvValores.Items.Add(new ListViewItem(parametro));
        }
        void InserirMediana(Imagem objImagem, Bitmap imagem)
        {
            string[] parametro = new string[2];

            parametro[0] = "Mediana";
            parametro[1] = objImagem.median(imagem).ToString();

            lvValores.Items.Add(new ListViewItem(parametro));
        }

        private void btMedia_MouseClick(object sender, MouseEventArgs e)
        {
            if (pbImagemOriginal.Image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.");
                return;
            }

            Imagem objImagem = new Imagem(Convert.ToString(lbNome.Text), Convert.ToString(lbEnd.Text));
            Bitmap imagem = new Bitmap(pbImagemOriginal.Image);
            InserirMedia(objImagem, imagem);

        }

        private void btStd_Click(object sender, EventArgs e)
        {
            if (pbImagemOriginal.Image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.");
                return;
            }

            Imagem objImagem = new Imagem(Convert.ToString(lbNome.Text), Convert.ToString(lbEnd.Text));
            Bitmap imagem = new Bitmap(pbImagemOriginal.Image);
            InserirDesvio(objImagem, imagem);
        }

        private void tbSeparar_MouseClick(object sender, MouseEventArgs e)
        {
            //if (pbImagemOriginal.Image == null)
            //{
            //    MessageBox.Show("Nenhuma imagem carregada.");
            //    return;
            //}


            //Imagem objImagem = new Imagem(Convert.ToString(lbNome.Text), Convert.ToString(lbEnd.Text));
            //Bitmap imagem = new Bitmap(pbImagemOriginal.Image);
            //pbCanalR.Image = objImagem.canalR(imagem);
            //pbCanalG.Image = objImagem.canalG(imagem);
            //pbCanalB.Image = objImagem.canalB(imagem);

        }

        private void btMediana_MouseClick(object sender, MouseEventArgs e)
        {
            if (pbImagemOriginal.Image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.");
                return;
            }

            Imagem objImagem = new Imagem(Convert.ToString(lbNome.Text), Convert.ToString(lbEnd.Text));
            Bitmap imagem = new Bitmap(pbImagemOriginal.Image);
            InserirMediana(objImagem, imagem);
        }

        private void btEditar_MouseClick(object sender, MouseEventArgs e)
        {
            
            dGV.CurrentRow.Selected = true;

            Imagem objImagem = new Imagem(tbNome.Text, tbCaminho.Text, cbLocalizacao.Text, cbGrau.Text);
            Bitmap imagem = new Bitmap(objImagem.Caminho);

            tbcImagem.SelectTab(tbEditar);

            pbImagemOriginal.Image = imagem;
            lbEnd.Text = objImagem.Caminho.ToString();
            lbNome.Text = objImagem.Nome;
            lbResolucao.Text = Convert.ToString(imagem.PixelFormat);
            lbAltura.Text = imagem.Height.ToString();
            lbLargura.Text = imagem.Width.ToString();
            lbLocalizacao.Text = objImagem.Localizacao;
            lbGrau.Text = objImagem.Grau;

            //if (isRBG == 1)  
            //{
            //    imagemRBG();
  

            //}
            //else
            //{
            //    imagemCinza();
            //}
           
        }

        private void tbcImagem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvValores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbRGB_Click(object sender, EventArgs e)
        {

        }

        private void tbcImagem_MouseClick(object sender, MouseEventArgs e)
        {
            limparTextBox();
        }

        private void tbCarregar_MouseClick(object sender, MouseEventArgs e)
        {
            //pbImagemOriginal.Image = null;
            lbEnd.Text = "Null";
            lbNome.Text = "Null";
            lbResolucao.Text = "Null";
            lbAltura.Text = "Null";
            lbLargura.Text = "Null";
            lbLocalizacao.Text = "Null";
            lbGrau.Text = "Null";
        }

        private void tbEditar_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void tbcImagem_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            tbcImagem.SelectTab(tbCarregar);
            lvValores.Items.Clear();
            pbImagemOriginal.Image = null;
            pbImagemModificada.Image = null;
            lbEnd.Text = "Null";
            lbNome.Text = "Null";
            lbResolucao.Text = "Null";
            lbAltura.Text = "Null";
            lbLargura.Text = "Null";
            lbLocalizacao.Text = "Null";
            lbGrau.Text = "Null";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pbImagemOriginal.Image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.");
                return;
            }

            if (pbImagemModificada.Image == null)
            {
                Imagem objImagem = new Imagem(Convert.ToString(lbNome.Text), Convert.ToString(lbEnd.Text));
                Bitmap imagem = new Bitmap(pbImagemOriginal.Image);
                Bitmap imagemMaisBrilho = objImagem.maisBrilho(imagem);
                pbImagemModificada.Image = imagemMaisBrilho;
            }

            if (pbImagemModificada.Image != null)
            {
                Imagem objImagem = new Imagem(Convert.ToString(lbNome.Text), Convert.ToString(lbEnd.Text));
                Bitmap imagem = new Bitmap(pbImagemModificada.Image);
                Bitmap imagemMaisBrilho = objImagem.maisBrilho(imagem);
                pbImagemModificada.Image = imagemMaisBrilho;
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (pbImagemOriginal.Image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.");
                return;
            }

            if (pbImagemModificada.Image == null)
            {
                Imagem objImagem = new Imagem(Convert.ToString(lbNome.Text), Convert.ToString(lbEnd.Text));
                Bitmap imagem = new Bitmap(pbImagemOriginal.Image);
                Bitmap imagemMenosBrilho = objImagem.menosBrilho(imagem);
                pbImagemModificada.Image = imagemMenosBrilho;
            }

            if (pbImagemModificada.Image != null)
            {
                Imagem objImagem = new Imagem(Convert.ToString(lbNome.Text), Convert.ToString(lbEnd.Text));
                Bitmap imagem = new Bitmap(pbImagemModificada.Image);
                Bitmap imagemMenosBrilho = objImagem.menosBrilho(imagem);
                pbImagemModificada.Image = imagemMenosBrilho;
            }
        }
    }
}
