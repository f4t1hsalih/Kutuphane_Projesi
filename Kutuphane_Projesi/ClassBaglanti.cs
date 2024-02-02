using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kutuphane_Projesi
{
    internal class ClassBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
