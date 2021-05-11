using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Configuration;
using static Conexion.Conexionbd;
using static Conexion.Excel;



namespace Conexion
{
    public partial class Exportar : Form
    {
        

        public Exportar()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb.Items.Add("Seleccione opcion");
            cmb.Items.Add("Pedidos de clientes");

            cmb.SelectedItem = cmb.Items[0];
        }
       


        private void Btnexportar_Click(object sender, EventArgs e)
        {
            Excel ex = new Excel();

            ex.ExportarDataGridViewExcel(grilla);
            
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            Funciones F = new Funciones();

            if(cmb.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione una opcion");
            }
            else if (cmb.SelectedIndex == 1)
            {
                F.Pedidosdeclientes(mtxtdesde, mtxthasta, grilla);
            }
            
        }

        private void grilla_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(grilla.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void txtdesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {

                e.Handled = true;

                return;
            }
        }

        private void txthasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {

                e.Handled = true;

                return;
            }
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb.SelectedIndex == 1)
            {
                mtxtdesde.Visible = true;
                lbldesde.Visible = true;
                mtxthasta.Visible = true;
                lblhasta.Visible = true;
                mtxtdesde.Focus();
            }
            else
            {
                mtxtdesde.Visible = false;
                mtxtdesde.Text = "";
                lbldesde.Visible = false;
                mtxthasta.Visible = false;
                mtxthasta.Text = "";
                lblhasta.Visible = false;
            }
        }
    }
}
