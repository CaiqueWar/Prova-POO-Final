using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAIQUEGOMES_3A1_08.Code.DAL;
using CAIQUEGOMES_3A1_08.Code.DTO;

namespace CAIQUEGOMES_3A1_08.Code.BLL
{
    class ProdutosBLL
    {

        ConexaoBD conexao = new ConexaoBD();
        string table = "produtos";


        public void Inserir(ProdutosDTO prodDTO)
        {
            string inserir = $"insert into {table} value (null, '{prodDTO.Produto}', '{prodDTO.Preco}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(ProdutosDTO prodDTO)
        {
            string alterar = $"update {table} set produto = '{prodDTO.Produto}', preco = '{prodDTO.Preco}'," +
                $" where codigo = '{prodDTO.Id}'";
            conexao.ExecutarComando(alterar);
        }

        public void Exclui(ProdutosDTO prodDTO)
        {
            string excluir = $"delete from {table} where codigo = '{prodDTO.Id}'";
            conexao.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {table} order by codigo;";
            return conexao.ExecutarConsulta(sql);
        }


    }
}
