using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project_AquaLumia
{
    public partial class FrmIni : Form
    {
        Metodos_AL m_al = new Metodos_AL();
        public FrmIni()
        {
         
                InitializeComponent();
              
        

            
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
           
            if (pbCarrega.Value < 92)
            {
                if (m_al.i == true)
                {

                    pbCarrega.Value = pbCarrega.Value + 2;
                }
                else
                {
                    pbCarrega.Value = 93;

                }

            }
            else
            {
                m_al.conectar();
                if (m_al.i == true)
                {

                    timer1.Enabled = false;

                    frmLogin vemLogin = new frmLogin();
                    this.Hide();
                    vemLogin.ShowDialog();
                    this.Close();
                }

                else
                {
                    timer1.Enabled = false;
                    this.Hide();
                    MessageBox.Show("Não Foi Possivel Estabelecer Conexão");
                    this.Close();



                }

            }

        }

      }
}
