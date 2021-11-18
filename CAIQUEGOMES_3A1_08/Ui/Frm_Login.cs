using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAIQUEGOMES_3A1_08.Code.DTO;
using CAIQUEGOMES_3A1_08.Code.BLL;

namespace CAIQUEGOMES_3A1_08.Ui
{
    public partial class Frm_Login : Form
    {

        LoginDTO logDTO = new LoginDTO();
        LoginBLL logBLL = new LoginBLL();

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            logDTO.Usuario = txt_usuario.Text;
            logDTO.Senha = txt_senha.Text;

            if (logBLL.RealizarLogin(logDTO) == true)
            {
                Form1 frmEPA = new Form1();
                frmEPA.ShowDialog();
            }
           


        }
    }
}
