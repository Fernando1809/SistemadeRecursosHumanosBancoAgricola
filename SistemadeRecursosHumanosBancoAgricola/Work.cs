using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeRecursosHumanosBancoAgricola
{
    public partial class Work : Form
    {
        ConexionDB objConexion = new ConexionDB();
        int posicion = 0;
        string accion = "";
        DataSet ds = new DataSet();
        DataTable tbl = new DataTable();

        public Work()
        {
            InitializeComponent();
        }

        void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtener_datosEmpleados();
            tbl = ds.Tables["RendimientoEmpleados"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdRendimiento"] };


        }

        void mostrar_datos()
        {
            try
            {
                id.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtID.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtmes.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtName.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtEv.Text = tbl.Rows[posicion].ItemArray[4].ToString();
            }
            catch (IndexOutOfRangeException ior)
            {
                MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               





        }
        void limpiar_cajas()
        {
            txtID.Text = "";
            txtmes.Text = "";
            txtName.Text = "";
            txtEv.Text = "";




        }

        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvEmployee.DataSource;
            bs.Filter = "Nombre like '%" + valor + "%'";
            dgvEmployee.DataSource = bs;
        }


        private void Work_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrar_datos();
            // TODO: esta línea de código carga datos en la tabla 'bAgriDataSet.RendimientoEmpleados' Puede moverla o quitarla según sea necesario.
            this.rendimientoEmpleadosTableAdapter.Fill(this.bAgriDataSet.RendimientoEmpleados);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Text == "nuevo")
            {//boton de nuevo
                btnAgregar.Tag = "guardar";
                btnEditar.Tag = "cancelar";
                accion = "nuevo";
                limpiar_cajas();
            }
            else
            { //boton de guardar

                String[] valores = {
                    txtID.Text,
                    txtmes.Text,
                    txtName.Text,
                    txtEv.Text

                };
                objConexion.mantenimiento_RendimientoEmpleados(valores, accion);
                posicion = tbl.Rows.Count - 1;
                mostrar_datos();
                btnAgregar.Tag = "Agregar";
                btnEditar.Tag = "Editar";

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEditar.Text == "modificar")
                {//boton de modificar
                    btnAgregar.Tag = "guardar";
                    btnEditar.Tag = "cancelar";
                    accion = "modificar";
                }
                else
                { //boton de cancelar

                    mostrar_datos();

                    btnAgregar.Tag = "Agregar";
                    btnEditar.Tag = "Editar";

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtName.Text, "Departamento de trabajo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { id.Text };
                objConexion.mantenimiento_RendimientoEmpleados(valores, "eliminar");
                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrar_datos();

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }
    }
}
