using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GaleriOtomasyonu
{
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DboTicari; Integrated Security = True");
                baglan.Open();
            return baglan;

        }
    }
}
