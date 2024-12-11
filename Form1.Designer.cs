namespace Projecto_03__Duas_comboboxes_
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
            lblCategorias = new Label();
            cbxCategorias = new ComboBox();
            lblFornecedores = new Label();
            cbxFornecedores = new ComboBox();
            btnMostraProdutosCategoriaSelecionada = new Button();
            btnMostrarProdutosFornecedorSelecionado = new Button();
            btnMostrarTodosProdutos = new Button();
            btnSair = new Button();
            dgvProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategorias.Location = new Point(26, 33);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(72, 17);
            lblCategorias.TabIndex = 0;
            lblCategorias.Text = "Categorias";
            // 
            // cbxCategorias
            // 
            cbxCategorias.FormattingEnabled = true;
            cbxCategorias.Location = new Point(26, 62);
            cbxCategorias.Name = "cbxCategorias";
            cbxCategorias.Size = new Size(259, 23);
            cbxCategorias.TabIndex = 1;
            // 
            // lblFornecedores
            // 
            lblFornecedores.AutoSize = true;
            lblFornecedores.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFornecedores.Location = new Point(291, 35);
            lblFornecedores.Name = "lblFornecedores";
            lblFornecedores.Size = new Size(90, 17);
            lblFornecedores.TabIndex = 2;
            lblFornecedores.Text = "Fornecedores";
            // 
            // cbxFornecedores
            // 
            cbxFornecedores.FormattingEnabled = true;
            cbxFornecedores.Location = new Point(291, 62);
            cbxFornecedores.Name = "cbxFornecedores";
            cbxFornecedores.Size = new Size(259, 23);
            cbxFornecedores.TabIndex = 3;
            // 
            // btnMostraProdutosCategoriaSelecionada
            // 
            btnMostraProdutosCategoriaSelecionada.Location = new Point(26, 100);
            btnMostraProdutosCategoriaSelecionada.Name = "btnMostraProdutosCategoriaSelecionada";
            btnMostraProdutosCategoriaSelecionada.Size = new Size(259, 33);
            btnMostraProdutosCategoriaSelecionada.TabIndex = 4;
            btnMostraProdutosCategoriaSelecionada.Text = "Mostrar Produtos da Categoria Selec.";
            btnMostraProdutosCategoriaSelecionada.UseVisualStyleBackColor = true;
            // 
            // btnMostrarProdutosFornecedorSelecionado
            // 
            btnMostrarProdutosFornecedorSelecionado.Location = new Point(291, 100);
            btnMostrarProdutosFornecedorSelecionado.Name = "btnMostrarProdutosFornecedorSelecionado";
            btnMostrarProdutosFornecedorSelecionado.Size = new Size(259, 33);
            btnMostrarProdutosFornecedorSelecionado.TabIndex = 5;
            btnMostrarProdutosFornecedorSelecionado.Text = "Mostrar Produtos do Fornecedor Selecionado";
            btnMostrarProdutosFornecedorSelecionado.UseVisualStyleBackColor = true;
            // 
            // btnMostrarTodosProdutos
            // 
            btnMostrarTodosProdutos.Location = new Point(556, 100);
            btnMostrarTodosProdutos.Name = "btnMostrarTodosProdutos";
            btnMostrarTodosProdutos.Size = new Size(259, 33);
            btnMostrarTodosProdutos.TabIndex = 6;
            btnMostrarTodosProdutos.Text = "Mostrar todos os produtos";
            btnMostrarTodosProdutos.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(699, 396);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(116, 33);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(26, 159);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(789, 150);
            dgvProdutos.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 450);
            Controls.Add(dgvProdutos);
            Controls.Add(btnSair);
            Controls.Add(btnMostrarTodosProdutos);
            Controls.Add(btnMostrarProdutosFornecedorSelecionado);
            Controls.Add(btnMostraProdutosCategoriaSelecionada);
            Controls.Add(cbxFornecedores);
            Controls.Add(lblFornecedores);
            Controls.Add(cbxCategorias);
            Controls.Add(lblCategorias);
            Name = "Form1";
            Text = "Form1";
            //Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategorias;
        private ComboBox cbxCategorias;
        private Label lblFornecedores;
        private ComboBox cbxFornecedores;
        private Button btnMostraProdutosCategoriaSelecionada;
        private Button btnMostrarProdutosFornecedorSelecionado;
        private Button btnMostrarTodosProdutos;
        private Button btnSair;
        private DataGridView dgvProdutos;
    }
}
