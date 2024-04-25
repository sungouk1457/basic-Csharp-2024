using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace toyproject.Helper
{
    internal class Common
    {
        public static readonly string ConnString = "Data Source=localhost;" +
                                          "Initial Catalog=Student;" +
                                          "Persist Security Info=True;" +
                                          "User ID=sa;Encrypt=False;Password=mssql_p@ss;";

        public static string LoginId { get; set; }
    }
}
