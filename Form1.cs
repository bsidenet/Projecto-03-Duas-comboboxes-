using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projecto_03__Duas_comboboxes_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreencherComboBoxCategorias();
            PreencherComboBoxFornecedores();
        }

        private void PreencherComboBoxCategorias()
        {
            try
            {
                Conexao bd = new Conexao();
                string query = "SELECT DISTINCT NomeDaCategoria FROM Categorias";
                DataTable categorias = bd.BuscarDados(query);

                cbxCategorias.Items.Clear();
                foreach (DataRow row in categorias.Rows)
                {
                    cbxCategorias.Items.Add(row["NomeDaCategoria"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar categorias: " + ex.Message);
            }
        }

        private void PreencherComboBoxFornecedores()
        {
            try
            {
                Conexao bd = new Conexao();
                string query = "SELECT DISTINCT NomeDaEmpresa FROM Fornecedores";
                DataTable fornecedores = bd.BuscarDados(query);

                cbxFornecedores.Items.Clear();
                foreach (DataRow row in fornecedores.Rows)
                {
                    cbxFornecedores.Items.Add(row["NomeDaEmpresa"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message);
            }
        }

        private void btnMostraProdutosCategoriaSelecionada_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxCategorias.SelectedItem == null)
                {
                    MessageBox.Show("Selecione uma categoria.");
                    return;
                }

                string categoria = cbxCategorias.SelectedItem.ToString();
                Conexao bd = new Conexao();
                string query = $"SELECT * FROM Produtos WHERE NomeDaCategoria = '{categoria}'";
                DataTable produtos = bd.BuscarDados(query);

                dgvProdutos.DataSource = produtos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao filtrar por categoria: " + ex.Message);
            }
        }

        private void btnMostrarProdutosFornecedorSelecionado_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxFornecedores.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um fornecedor.");
                    return;
                }

                string fornecedor = cbxFornecedores.SelectedItem.ToString();
                Conexao bd = new Conexao();
                string query = $"SELECT * FROM Produtos WHERE NomeDaEmpresa = '{fornecedor}'";
                DataTable produtos = bd.BuscarDados(query);

                dgvProdutos.DataSource = produtos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao filtrar por fornecedor: " + ex.Message);
            }
        }
    }
}



    //        private void Form1_Load(object sender, EventArgs e)
    //        {
    //            CarregarCategorias();
    //            CarregarFornecedores();
    //            PreencherComboBoxCategorias();
    //            PreencherComboBoxFornecedores();
    //        }

    //        // Carregar lista de Categorias na combobox
    //        private void CarregarCategorias()
    //        {
    //            LigacaoBD ligacao = new LigacaoBD();
    //            DataTable dtCategoria = ligacao.BuscarDados("SELECT CódigoDaCategoria, NomeDaCategoria FROM Categorias");
    //            cbxCategorias.DataSource = dtCategoria;
    //            cbxCategorias.DisplayMember = "NomeDaCategoria";
    //            cbxCategorias.ValueMember = "CódigoDaCategoria";
    //        }
    //        // Carregar lista de Fornecedores na combobox
    //        private void CarregarFornecedores()
    //        {
    //            LigacaoBD ligacao = new LigacaoBD();
    //            DataTable dtCategoria = ligacao.BuscarDados("SELECT CódigoDoFornecedor, NomeDaEmpresa FROM Fornecedores");
    //            cbxCategorias.DataSource = dtCategoria;
    //            cbxCategorias.DisplayMember = "NomeDaEmpresa";
    //            cbxCategorias.ValueMember = "CódigoDoFornecedor";
    //        }

    //        // <teste>
    //        private void PreencherComboBoxCategorias()
    //        {
    //            try
    //            {
    //                LigacaoBD bd = new LigacaoBD();
    //                string query = "SELECT DISTINCT NomeDaCategoria FROM Categorias";
    //                DataTable categorias = bd.BuscarDados(query);

    //                cbxCategorias.Items.Clear();
    //                foreach (DataRow row in categorias.Rows)
    //                {
    //                    cbxCategorias.Items.Add(row["NomeDaCategoria"].ToString());
    //                }
    //            }
    //            catch (Exception ex)
    //            {
    //                MessageBox.Show("Erro ao carregar Categorias:\n" + ex.Message);
    //            }
    //        }

    //        private void PreencherComboBoxFornecedores()
    //        {
    //            try
    //            {
    //                LigacaoBD bd = new LigacaoBD();
    //                string query = "SELECT DISTINCT NomeDaEmpresa FROM Fornecedores";
    //                DataTable fornecedores = bd.BuscarDados(query);

    //                cbxFornecedores.Items.Clear();
    //                foreach (DataRow row in fornecedores.Rows)
    //                {
    //                    cbxFornecedores.Items.Add(row["NomeDaEmpresa"].ToString());
    //                }
    //            }
    //            catch (Exception ex)
    //            {
    //                MessageBox.Show("Erro ao carregar Fornecedores:\n" + ex.Message);
    //            }
    //        }

    //        ///////////////////////////////////////////////////////
    //        private void btnMostrarTodosProdutos_Click(object sender, EventArgs e)
    //        {
    //            try
    //            {
    //                // Instância da classe LigacaoBD
    //                LigacaoBD bd = new LigacaoBD();

    //                // Consulta para buscar todos os registos da tabela
    //                string query = "SELECT * FROM Produtos";

    //                // Obter os dados
    //                DataTable registos = bd.BuscarDados(query);

    //                // Mostrar os dados na DataGridView
    //                dgvProdutos.DataSource = registos;

    //                MessageBox.Show("Produtos carregados com sucesso.");
    //            }
    //            catch (Exception ex)
    //            {
    //                MessageBox.Show("Erro ao carregar os produtos:\n" + ex.Message);
    //            }
    //        }

    //        private void btnSair_Click(object sender, EventArgs e)
    //        {
    //            this.Close();
    //        }

    //        private void cbxCategorias_SelectedIndexChanged(object sender, EventArgs e)
    //        {
    //            CarregarCategorias();
    //            CarregarFornecedores();
    //            PreencherComboBoxCategorias();
    //            PreencherComboBoxFornecedores();
    //        }

    //        private void cbxFornecedores_SelectedIndexChanged(object sender, EventArgs e)
    //        {
    //            CarregarCategorias();
    //            CarregarFornecedores();
    //            PreencherComboBoxCategorias();
    //            PreencherComboBoxFornecedores();

    //        }
    //    }

    //    internal class LigacaoBD
    //    {
    //        public LigacaoBD()
    //        {
    //        }

    //        internal DataTable BuscarDados(string query)
    //        {
    //            throw new NotImplementedException();
    //        }





///////////////////////////////////////
///
