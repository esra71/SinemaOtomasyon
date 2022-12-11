using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SinemaOtomasyon
{
    class SqlBaglantisi
    {
        public string Adres = System.IO.File.ReadAllText(@"C:\SinemaOtomasyon.txt");
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection(Adres);
            baglan.Open();
            return baglan;
        }
    }
}
