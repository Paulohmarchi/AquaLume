using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;// classe para reconhecer o msql

namespace project_AquaLumia
{

   public class Metodos_AL
    {

       public Boolean i;
        public MySqlConnection Conn;
         
       public void conectar()
        {
           
            //criando a string de conexao com o bd (local do bd, usuario, senha, o banco de dados, e a porta
            Conn = new MySqlConnection("Server=localhost; User id=root; Database=linkwatts;Password=''");

            try // tentar abrir a conexao
            {
                Conn.Open();
                
                i = true;
            }
            catch //Se não conseguir abrir a conexao executar
            {

                
                i = false;
                
                
                
            }
        }

       public void Eletricidade()
       {
           Construtor c = new Construtor();

           string mes, situPes, aviso;
            double valorConta, numWatts, wPes, valorPes, wattsDia, valorK; ;
            int nPessoas;

           c.valor_Ele
       
       
       }



    }
}
