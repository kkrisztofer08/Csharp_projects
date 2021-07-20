using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Színház_jegyfoglaló_app
{
    class DB
    {
        private SQLiteConnection con = new SQLiteConnection("data source=adatbazis.db");

        public SQLiteConnection getConnection()
        {
            return con;
        }

        public void openConnection()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
