using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BM.DAL
{
    public class BaseRepository
    {
        protected IDbConnection connect;
        public BaseRepository()
        {
            connect = new SqlConnection(@"Data Source=WIN-CECDPV4A3AJ\SQLEXPRESS;Initial Catalog=BookManager;Integrated Security=True");
        }
    }
}
