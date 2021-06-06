using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itpm101
{ 

   public class ConnectionManager
{
    public static SqlConnection newCon;
    public static String Constr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

    public static SqlConnection GetConnection()
    {
        newCon = new SqlConnection(Constr);
        return newCon;
    }
}
}

