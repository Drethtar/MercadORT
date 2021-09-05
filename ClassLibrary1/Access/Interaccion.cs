using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Access
{
    public class Interaccion: Conexion
    {
        public Boolean verificarConexion()
        {
            return ConexionBD.State.ToString().Equals("Open");
        }
    }
}
