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
    public partial class Empleados : Form
    {

        ConexionDB objConexion = new ConexionDB();
        int posicion = 0;
        string accion = "";
        DataSet ds = new DataSet();
        DataTable tbl = new DataTable();
        public Empleados()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

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
                    txtName.Text,
                    txtapellido.Text,
                    txtAddress.Text,
                    txtAge.Text,
                    txtEmail.Text,
                    txtPhone.Text,
                    txtSalary.Text,
                    cmboxDeptt.Text

                };
                objConexion.mantenimiento_datosEmpleados(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrar_datos();
                btnAgregar.Tag = "Agregar";
                btnEditar.Tag = "Editar";
            }
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bAgriDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.bAgriDataSet.Empleados);
            actualizarDs();
            mostrar_datos();
        }

        void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtener_datosEmpleados();
            tbl = ds.Tables["Empleados"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdEmpleado"] };
        }

        void mostrar_datos()
        {
            try {
                txtName.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                c.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtapellido.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtAge.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtEmail.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtPhone.Text = tbl.Rows[posicion].ItemArray[5].ToString();
                txtAddress.Text = tbl.Rows[posicion].ItemArray[6].ToString();
                txtSalary.Text = tbl.Rows[posicion].ItemArray[7].ToString();
                cmboxDeptt.Text = tbl.Rows[posicion].ItemArray[8].ToString();
            } catch (IndexOutOfRangeException ior) {
                MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }


    

        void limpiar_cajas()
        {
            txtName.Text = "";
            txtapellido.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtSalary.Text = "";
            cmboxDeptt.Text = "";

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
            if (MessageBox.Show("Esta seguro de eliminar a " + txtName.Text, "Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = {c.Text };
                objConexion.mantenimiento_datosEmpleados(valores, "eliminar");
                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrar_datos();

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            filtrar_datos(cmboxNames.Text);
        }

        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvEmployee.DataSource;
            bs.Filter = "Nombre like '%" + valor + "%'";
            dgvEmployee.DataSource = bs;
        }
    }
}
    

