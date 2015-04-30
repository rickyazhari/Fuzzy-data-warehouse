using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using FirstFloor.ModernUI.Windows.Controls;
namespace Spaceman_warehouse
{
    class kon
    {
        private SqlCommand com = null;
        private string konf = "server=CORET/SPACEMAN;UID=Coret/kari;PWD=;Database=dw_spaceman";
        private SqlConnection koneksi = null;
        
        private void open_kon()
        {
            koneksi = new SqlConnection(konf);
            koneksi.Open();
        }

        private void close_kon(){
           koneksi.Close();
           koneksi=null;
        }

       public DataTable  tampil_data(string x)
        {
            DataTable dt = new DataTable();
            try
            {
                
                open_kon();
                com = new SqlCommand();
                com.Connection = koneksi;
                com.CommandType = CommandType.Text;
                com.CommandText = x;
                SqlDataReader mdr = com.ExecuteReader();
                dt.Load(mdr);
                close_kon();
               
            }
            catch (SqlException)
            {
            
            }
            com = null;
            return dt;
        }
    }
}
