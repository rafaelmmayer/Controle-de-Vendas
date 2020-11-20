namespace FaturamentoWF
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.buttonAddProduto = new System.Windows.Forms.Button();
            this.dataProdutos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVendas = new System.Windows.Forms.DataGridView();
            this.ProdutoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalVenda = new System.Windows.Forms.Label();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.btnFinalizarDia = new System.Windows.Forms.Button();
            this.cBoxFiltro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(486, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 29);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(486, 115);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 29);
            this.txtQuantidade.TabIndex = 3;
            // 
            // buttonAddProduto
            // 
            this.buttonAddProduto.Location = new System.Drawing.Point(490, 164);
            this.buttonAddProduto.Name = "buttonAddProduto";
            this.buttonAddProduto.Size = new System.Drawing.Size(93, 29);
            this.buttonAddProduto.TabIndex = 5;
            this.buttonAddProduto.Text = "Adicionar";
            this.buttonAddProduto.UseVisualStyleBackColor = true;
            this.buttonAddProduto.Click += new System.EventHandler(this.buttonAddProduto_Click);
            // 
            // dataProdutos
            // 
            this.dataProdutos.AllowUserToDeleteRows = false;
            this.dataProdutos.AllowUserToOrderColumns = true;
            this.dataProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Produto,
            this.Preço});
            this.dataProdutos.Location = new System.Drawing.Point(12, 12);
            this.dataProdutos.Name = "dataProdutos";
            this.dataProdutos.Size = new System.Drawing.Size(463, 420);
            this.dataProdutos.TabIndex = 6;
            // 
            // ID
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle7;
            this.ID.HeaderText = "Código";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Produto
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produto.DefaultCellStyle = dataGridViewCellStyle8;
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 200;
            // 
            // Preço
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.Preço.DefaultCellStyle = dataGridViewCellStyle9;
            this.Preço.HeaderText = "Preço R$";
            this.Preço.Name = "Preço";
            this.Preço.ReadOnly = true;
            this.Preço.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataVendas
            // 
            this.dataVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdutoVenda,
            this.Quantidade,
            this.Total});
            this.dataVendas.Location = new System.Drawing.Point(602, 12);
            this.dataVendas.Name = "dataVendas";
            this.dataVendas.Size = new System.Drawing.Size(452, 420);
            this.dataVendas.TabIndex = 7;
            this.dataVendas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataVendas_RowsAdded);
            this.dataVendas.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataVendas_RowsRemoved);
            // 
            // ProdutoVenda
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdutoVenda.DefaultCellStyle = dataGridViewCellStyle10;
            this.ProdutoVenda.HeaderText = "Produto";
            this.ProdutoVenda.Name = "ProdutoVenda";
            this.ProdutoVenda.ReadOnly = true;
            this.ProdutoVenda.Width = 200;
            // 
            // Quantidade
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle11;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Total
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle12;
            this.Total.HeaderText = "Total R$";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(597, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Venda : R$";
            // 
            // labelTotalVenda
            // 
            this.labelTotalVenda.AutoSize = true;
            this.labelTotalVenda.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalVenda.Location = new System.Drawing.Point(765, 456);
            this.labelTotalVenda.Name = "labelTotalVenda";
            this.labelTotalVenda.Size = new System.Drawing.Size(25, 30);
            this.labelTotalVenda.TabIndex = 9;
            this.labelTotalVenda.Text = "0";
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Location = new System.Drawing.Point(939, 459);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(115, 33);
            this.btnFinalizarCompra.TabIndex = 10;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // btnFinalizarDia
            // 
            this.btnFinalizarDia.Location = new System.Drawing.Point(939, 548);
            this.btnFinalizarDia.Name = "btnFinalizarDia";
            this.btnFinalizarDia.Size = new System.Drawing.Size(115, 33);
            this.btnFinalizarDia.TabIndex = 11;
            this.btnFinalizarDia.Text = "Finalizar dia";
            this.btnFinalizarDia.UseVisualStyleBackColor = true;
            this.btnFinalizarDia.Click += new System.EventHandler(this.btnFinalizarDia_Click);
            // 
            // cBoxFiltro
            // 
            this.cBoxFiltro.FormattingEnabled = true;
            this.cBoxFiltro.Location = new System.Drawing.Point(12, 468);
            this.cBoxFiltro.Name = "cBoxFiltro";
            this.cBoxFiltro.Size = new System.Drawing.Size(178, 21);
            this.cBoxFiltro.TabIndex = 12;
            this.cBoxFiltro.Text = "Selecione o tipo do Produto";
            this.cBoxFiltro.SelectedValueChanged += new System.EventHandler(this.cBoxFiltro_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Filtrar";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 593);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 593);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxFiltro);
            this.Controls.Add(this.btnFinalizarDia);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.labelTotalVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataVendas);
            this.Controls.Add(this.dataProdutos);
            this.Controls.Add(this.buttonAddProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button buttonAddProduto;
        private System.Windows.Forms.DataGridView dataProdutos;
        private System.Windows.Forms.DataGridView dataVendas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalVenda;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Button btnFinalizarDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox cBoxFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}

