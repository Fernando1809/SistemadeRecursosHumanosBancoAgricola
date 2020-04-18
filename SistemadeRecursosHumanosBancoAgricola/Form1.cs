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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            Departamento frm = new Departamento();
            frm.ShowDialog();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleados frm = new Empleados();
            frm.ShowDialog();
        }

        private void btnRendimiento_Click(object sender, EventArgs e)
        {
            Work frm = new Work();
            frm.ShowDialog();
        }
    }
}
