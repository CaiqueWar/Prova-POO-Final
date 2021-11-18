using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAIQUEGOMES_3A1_08.Code.BLL;
using CAIQUEGOMES_3A1_08.Code.DTO;


namespace CAIQUEGOMES_3A1_08
{
    public partial class Form1 : Form
    {

        ProdutosDTO prodDTO = new ProdutosDTO();
        ProdutosBLL prodBLL = new ProdutosBLL();

        public Form1()
        {
            InitializeComponent();
        }

       
        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            prodDTO.Produto = txt_produto.Text;
            prodDTO.Preco = double.Parse(txt_preco.Text);

            prodBLL.Inserir(prodDTO);

            MessageBox.Show("Cadastro concluido!", "EPA", MessageBoxButtons.OK);

            prodBLL.Listar();

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            prodDTO.Id = int.Parse(txt_id.Text);
            prodDTO.Produto = txt_produto.Text;
            prodDTO.Preco = double.Parse(txt_preco.Text);

            prodBLL.Editar(prodDTO);

            MessageBox.Show("Alteração concluida!", "EPA", MessageBoxButtons.OK);

            prodBLL.Listar();



        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            prodDTO.Id = int.Parse(txt_id.Text);

            prodBLL.Exclui(prodDTO);

            MessageBox.Show("Registro Excluido!", "EPA", MessageBoxButtons.OK);

            prodBLL.Listar();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtg_produtos.DataSource = prodBLL.Listar();
        }

        private void dtg_produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dtg_produtos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_preco.Text = dtg_produtos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_produto.Text = dtg_produtos.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
    }
}
