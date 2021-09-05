using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ClassLibrary1.Access
{
    public class Conexion
    {
        protected OleDbConnection connection;

        protected OleDbConnection ConexionBD
        {
            get
            {
                connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb");
                connection.Open();
                return connection;
            }

            
        
        }
    }
}
