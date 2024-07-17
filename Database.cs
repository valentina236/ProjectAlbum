using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAlbum
{
    public class Database
    {
        private readonly string connectionString = @"Data Source=DESKTOP-OBSFQ72;Initial Catalog=Album;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
