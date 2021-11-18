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
    class LoginBLL
    {
        ConexaoBD conexao = new ConexaoBD();
        string tabela = "login";

        public bool RealizarLogin(LoginDTO loginDTO)
        {
            string sql = $"select * from {tabela} where email = '{loginDTO.Usuario}' and senha = '{loginDTO.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }



    }
}
