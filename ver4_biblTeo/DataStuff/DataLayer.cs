using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ver4_biblTeo
{
    public class DataLayer
    {
        // aicia se lucreaza cu baza de date si outputu in fisiere
        // e suficient sa fie singleton

        private static DataLayer instance = null;
        private SqlConnection sqlConnection;
        private DataLayer()
        {
            this.sqlConnection = new SqlConnection();
        }

        public static DataLayer GetInstance()
        {
            if (instance is null)
                instance = new DataLayer();
            return instance;
        }

        public static SqlConnection ConnectToDB()
        {
            return null;
        }

    }
}
