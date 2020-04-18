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
    public partial class Departamento : Form
    {
        ConexionDB objConexion = new ConexionDB();
        int posicion = 0;
        string accion = "";
        DataSet ds = new DataSet();
        DataTable tbl = new DataTable();
       
        public Departamento()
        {
            InitializeComponent();
        }

        void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtener_datosEmpleados();
            tbl = ds.Tables["DepTrabajo"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdDepTrabajo"] };

         
        }

        void mostrar_datos()
        {
            try {
                id.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtID.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtDep.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtEncar.Text = tbl.Rows[posicion].ItemArray[3].ToString();
            }
            catch (IndexOutOfRangeException ior)
            {
                MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           




        }
        void limpiar_cajas()
        {
            txtID.Text = "";
            txtDep.Text = "";
            txtEncar.Text = "";
            
           

        }
       
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvDeptt.DataSource;
            bs.Filter = "Nombre like '%" + valor + "%'";
            dgvDeptt.DataSource = bs;
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
                    txtDep.Text,
                    txtEncar.Text
                    
                };
                objConexion.mantenimiento_Deptrabajo(valores, accion);
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
            if (MessageBox.Show("Esta seguro de eliminar a " + txtEncar.Text, "Departamento de trabajo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { id.Text };
                objConexion.mantenimiento_Deptrabajo(valores, "eliminar");
                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrar_datos();

            }
        }

        private void Departamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bAgriDataSet.DepTrabajo' Puede moverla o quitarla según sea necesario.
            this.depTrabajoTableAdapter.Fill(this.bAgriDataSet.DepTrabajo);
            actualizarDs();
            mostrar_datos();
            buscar.Visible = false;

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar.Visible = true;
            filtrar_datos(buscar.Text);

        }
    }
}
