using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _Excel = Microsoft.Office.Interop.Excel;

namespace FaturamentoWF
{
    public partial class Form1 : Form
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                GerarProdutos();
                cBoxFiltro.Items.Add("Tudo");
                foreach (var produto in Produtos)
                {
                    dataProdutos.Rows.Add(produto.ID.ToString(), produto.Nome, produto.Preco);
                }
                var filtros = Produtos.Select(x => x.Tipo).Distinct().ToList();
                foreach (var filtro in filtros)
                {
                    cBoxFiltro.Items.Add(filtro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddProduto_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarProdutoNoCarrinho();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinalizarDia_Click(object sender, EventArgs e)
        {
            try
            {
                FinalizarDia();
                MessageBox.Show("Finalizado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataVendas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                AtualizarCompra();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataVendas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                AtualizarCompra();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarProdutos();
                dataVendas.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cBoxFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            dataProdutos.Rows.Clear();
            var itemSelecionadoFiltro = cBoxFiltro.SelectedItem.ToString();
            if (itemSelecionadoFiltro == "Tudo")
            {
                foreach (var produto in Produtos)
                {
                    dataProdutos.Rows.Add(produto.ID.ToString(), produto.Nome, produto.Preco);
                }
            }
            else
            {
                foreach (var produto in Produtos.Where(x => x.Tipo == itemSelecionadoFiltro))
                {
                    dataProdutos.Rows.Add(produto.ID.ToString(), produto.Nome, produto.Preco);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                buttonAddProduto.PerformClick();
            }
        }

        void GerarProdutos()
        {
            _Excel.Application excel = new _Excel.Application();
            _Excel.Workbook workbook = excel.Workbooks.Open($@"{Directory.GetCurrentDirectory()}\Data\FATURAMENTO_vs2.xlsx");
            _Excel.Worksheet planilhaProdutos = workbook.Sheets["Produtos"];

            int qtdLinhas = planilhaProdutos.UsedRange.Rows.Count;

            for (int i = 2; i < qtdLinhas + 1; i++)
            {
                string nome = planilhaProdutos.Range[$"A{i}"].Value;
                double preco = planilhaProdutos.Range[$"B{i}"].Value;
                string tipo = planilhaProdutos.Range[$"C{i}"].Value;

                Produtos.Add(new Produto(nome, preco, tipo, i - 1));
            }
            workbook.Save();
            workbook.Close();
            excel.Quit();
            Marshal.ReleaseComObject(excel);
        }
     void AdicionarProdutoNoCarrinho()
        { 
            if(txtQuantidade.Text == "")
            {
                throw new Exception("Campo de Quantidade vazio!");
            }
            var quantidade = int.Parse(txtQuantidade.Text);
            if (txtCodigo.Text == "")
            {
                var selecionado = dataProdutos.SelectedCells[1].Value.ToString();
                var produtoSelecionado = Produtos.Where(x => x.Nome == selecionado).First();
                dataVendas.Rows.Add(produtoSelecionado.Nome, quantidade, produtoSelecionado.Preco * quantidade);                  
            }
            else         
            {
                int id = int.Parse(txtCodigo.Text);
                if (Produtos.Select(x => x.ID).Contains(id))
                {
                    var produtoSelecionado = Produtos.Where(x => x.ID == id).First();
                    dataVendas.Rows.Add(produtoSelecionado.Nome, quantidade, produtoSelecionado.Preco * quantidade);
                }
                else
                {
                    throw new Exception("Código Inválido");
                }
            }
            txtQuantidade.Text = "";
            txtCodigo.Text = "";
            txtCodigo.Focus();
        }
        void AtualizarCompra()
        {
            double total = 0;
            for (int i = 0; i < dataVendas.Rows.Count - 1; i++)
            {
                total += double.Parse(dataVendas.Rows[i].Cells[2].Value.ToString());
            }
            labelTotalVenda.Text = total.ToString("0.00");
        }
        void AtualizarProdutos()
        {
            for (int i = 0; i < dataVendas.Rows.Count - 1; i++)
            {
                string produto = dataVendas.Rows[i].Cells[0].Value.ToString();
                int quantidade = int.Parse(dataVendas.Rows[i].Cells[1].Value.ToString());
                var produtoLista = Produtos.Where(x => x.Nome == produto).First();
                produtoLista.Quantidade += quantidade;
            }
        }
        void FinalizarDia()
        {
            string dataDeHoje = DateTime.Now.ToString("dd-MM-yyyy");
            string pathModelo = $@"{Directory.GetCurrentDirectory()}\Data\Modelo Vendas do dia.xlsx";
            string pathFinal = $@"{Directory.GetCurrentDirectory()}\Resumo dos dias\Faturamento do dia {dataDeHoje}.xlsx";
            File.Copy(pathModelo, pathFinal, true);

            _Excel.Application excel = new _Excel.Application();
            _Excel.Workbook workbook = excel.Workbooks.Open(pathFinal);
            _Excel.Worksheet planilhaProdutos = workbook.Sheets["Vendas"];

            int row = 2;
            foreach (var produto in Produtos.Where(x => x.Quantidade != 0))
            {
                Object[] a = new Object[] { produto.Nome, produto.Preco, produto.Tipo, produto.Quantidade, produto.Preco * produto.Quantidade };
                planilhaProdutos.Range[$"A{row}", $"E{row}"].Value = a;
                row++;
            }
            workbook.Save();
            workbook.Close();
            excel.Quit();
        }
    }
}
