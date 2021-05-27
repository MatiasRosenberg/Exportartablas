using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Configuration;
using static Conexion.Conexionbd;
using System.Data;

namespace Conexion
{
    class Funciones
    {
        public void Pedidosdeclientes(MaskedTextBox desde, MaskedTextBox Hasta, DataGridView datagrid)
        {
            //llamo al store
            string store;
            store = "sp_pedidos_de_clientes";
            SqlConnection cnn = DbConnection.getDBConnection();
            SqlDataAdapter da = new SqlDataAdapter(store, cnn);
            DataSet ds = new DataSet();

            //parametros
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Desde", desde.Text.ToString());
            da.SelectCommand.Parameters.AddWithValue("@Hasta", Hasta.Text.ToString());
            da.Fill(ds, "store");
            cnn.Close();

            //mostrar en tabla
            datagrid.DataSource = ds;
            datagrid.DataMember = "store";

        }

        public void Listaarticulos(TextBox Lista, DataGridView datagrid)
        {
            //llamo al store
            string store;
            store = "sp_Lista_articulos";
            SqlConnection cnn = DbConnection.getDBConnection();
            SqlDataAdapter da = new SqlDataAdapter(store, cnn);
            DataSet ds = new DataSet();

            //parametros
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@lista", Lista.Text.ToString());
            da.Fill(ds, "store");
            cnn.Close();

            //mostrar en tabla
            datagrid.DataSource = ds;
            datagrid.DataMember = "store";

        }

        public void Listaproveedores(DataGridView datagrid)
        {
            string store;
            store = "SP_LISTA_PROVEEDORES";
            SqlConnection cnn = DbConnection.getDBConnection();
            SqlDataAdapter da = new SqlDataAdapter(store, cnn);
            DataSet ds = new DataSet();

            da.Fill(ds, "store");
            cnn.Close();

            //mostrar en tabla
            datagrid.DataSource = ds;
            datagrid.DataMember = "store";

        }

        public void Listaclientes(DataGridView datagrid)
        {
            string store;
            store = "SP_LISTA_CLIENTES";
            SqlConnection cnn = DbConnection.getDBConnection();
            SqlDataAdapter da = new SqlDataAdapter(store, cnn);
            DataSet ds = new DataSet();

            da.Fill(ds, "store");
            cnn.Close();

            //mostrar en tabla
            datagrid.DataSource = ds;
            datagrid.DataMember = "store";

        }
    }
}
