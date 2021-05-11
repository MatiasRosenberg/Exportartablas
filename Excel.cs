using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion
{
    class Excel
    {
        /// <summary>
        /// Método que exporta a un fichero Excel el contenido de un DataGridView
        /// </summary>
        /// <param name="grd">DataGridView que contiene los datos a exportar</param>
        public void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                //For para el titulo
                for (int i = 1; i < grd.Columns.Count + 1; i++)
                {
                    hoja_trabajo.Cells[1, i] = grd.Columns[i - 1].HeaderText;
                }
                //For para tabla
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        if (grd.Rows[i].Cells[j].Value != null)
                        {
                            hoja_trabajo.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            hoja_trabajo.Cells[i + 2, j + 1] = "";
                        }
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
                MessageBox.Show("La exportacion fue exitosa");
            }
        }

    }
}
