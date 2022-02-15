using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
namespace GiaoDien
{
    class KetNoi
    {
        public static string AdminConnect = "USER ID = ADMINBV;Password=123;DATA SOURCE = localhost:1521/qlbv;";
        public static OracleConnection GetConnection(string host, int port, String sid, String user, String password)
        {
            Console.WriteLine("Getting Connection ...");

            // 'Connection String' kết nối trực tiếp tới Oracle.
            string connString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                     + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                     + sid + ")));Password=" + password + ";User ID=" + user;

            OracleConnection conn = new OracleConnection();

            conn.ConnectionString = connString;

            return conn;
        }
    }
    class DBConnection
    {
        public static OracleConnection GetConnection(string username, string password)
        {
            string host = "localhost";
            int port = 1521;
            string sid = "qlbv";
            string user = username;
            string pass = password;

            return KetNoi.GetConnection(host, port, sid, user, password);
        }

        internal static OracleConnection GetConnection(string username, object password)
        {
            throw new NotImplementedException();
        }

        internal static OracleConnection GetConnection(object username, string v)
        {
            throw new NotImplementedException();
        }
    }

}
