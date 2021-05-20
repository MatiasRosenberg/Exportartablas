using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion
{
    public class Instalacion
    {
        static RegistryKey rk = Registry.CurrentUser.OpenSubKey("Software\\InTime\\ItPyme");
        public static object valor = rk.GetValue("Instalacion").ToString();

        public static object GetValor()
        {
            return valor;
        }

        public static void SetValor(object value)
        {
            valor = value;
        }
    }
}
