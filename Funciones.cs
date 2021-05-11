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
        public void Listadostockprecios(DataGridView dataGrid)
        {
            SqlConnection cnn = DbConnection.getDBConnection();
            DataSet ds = new DataSet();
            string consulta = "sp_Listado_stock_precios";
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnn);

            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.Fill(ds, "consulta");
            cnn.Close();

            dataGrid.DataSource = ds;
            dataGrid.DataMember = "consulta";

        }

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
    }
}
