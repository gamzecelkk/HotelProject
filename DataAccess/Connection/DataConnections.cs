using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DataConnections //Static olması durumu sınıfın instanceını oluşturmadan kullanılmasına olanak verir.
    {
        public static string Get_MsSQLConnectionString
        { 
            get { return "Server=DESKTOP-QH5898C;Database=DBHotel1;Trusted_Connection=True;"; }
        }
        //static new kullanmadan çağırmak demek,adıyla çağırabiliriz artık
        public static string Get_OracleConnectionString
        {
            get { return "Data Source=HotelOracle;Integrated Security=yes;"; }
        }
        public static string Get_MySQLConnectionString
        {
            get { return "Server=MySqlServer;Database=DBHotelMySql;Uid=111;Pwd=111;"; }
        }

    }
}
