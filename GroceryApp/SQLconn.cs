using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GroceryApp
{
    class SQLconn
    {
        public SqlConnection con;

        public void getConn()
        {
            con = new SqlConnection("Data Source = DESKTOP-3M4G2T5; Initial Catalog = db_project_grocery; Integrated Security = True; ");
        }
    }
}
