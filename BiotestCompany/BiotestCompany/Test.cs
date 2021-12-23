using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiotestCompany
{
    class Test
    {
        public int keyy;
        public Test(int keyy)
        {
            this.keyy = keyy;
            createTest();
        }
        public void createTest()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddTests @keyy";
            c.Parameters.AddWithValue("@keyy", this.keyy);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public static void read()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllTests";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

        }

    }

}
