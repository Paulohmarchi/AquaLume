using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project_AquaLumia
{
    public partial class frmEletricidade : Form
    {
        Construtor c = new Construtor();

        public frmEletricidade()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtVLC.Text.Length == 0 | txtNKW.Text.Length == 0 | cbMes.Text.Length == 0 | cbNP.Text.Length == 0)
            {


                MessageBox.Show("Há compos em branco, Por favor preencha todos os Campos!");
            }

            else
            {
                c.valor_Ele = Convert.ToDouble(txtVLC.Text);
                c.watts_Ele = Convert.ToDouble(txtNKW.Text);
                c.mes_Ele = cbMes.Text;
                c.npes_Ele = Convert.ToInt16(cbNP.Text);
                if (rdbVerde.Checked)
                {
                    c.mensagem = "Muito bem!!! \n A região na qual você está inserido utilizou fontes energeticas favoraveis a economia neste mes! ";

                }
                else
                {
                    if (rdbAmarela.Checked)
                    {
                        c.mensagem = "Ops!!! \n A região na qual você está inserido não utilizou fontes energeticas tão favoraveis a economia neste mes! ";

                    }

                    else
                    {
                        if (rdbVermelha.Checked)
                        {
                            c.mensagem = "OuOu!!! \n A região na qual você está inserido não utilizou nenhuma fonte energetica favoravel a economia neste mes!";
                        }
                    }
                }

            }


        }
    }
}
