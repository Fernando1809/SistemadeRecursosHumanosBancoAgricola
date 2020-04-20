using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//conectarse al SQL Server
using System.Windows.Forms; //Messagebox

namespace SistemadeRecursosHumanosBancoAgricola
{
    class ConexionDB
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand comandoSQL = new SqlCommand(); 
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();
        BAgriDataSet ds = new BAgriDataSet();

        public ConexionDB()
        {
            /*Para cambiar la direccion, andate a Proyecto > Agregar nuevo origen de datos>Base de datos>Conjunto de datos>le das al "+" y copiás esa direccion, y luego la ponés acá*/
            string cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BAgri.mdf;Integrated Security=True"; /*La pones en las comillas, desde Data hasta True, luego borrás estos comentarios xd*/
            
            miConexion.ConnectionString = cadena;
            miConexion.Open();
        }
        //

            public BAgriDataSet obtener_datosEmpleados()
        {
            ds.Clear();
            comandoSQL.Connection = miConexion;

           
            comandoSQL.CommandText = "select * from Empleados"; //Empleados
            miAdaptadorDatos.SelectCommand = comandoSQL;
            miAdaptadorDatos.Fill(ds, "Empleados");

            return ds;


        }

        public BAgriDataSet obtener_datosDepTrabajo()
        {
            ds.Clear();
            comandoSQL.Connection = miConexion;

            
            comandoSQL.CommandText = "select * from DepTrabajo"; //DepTrabajo
            miAdaptadorDatos.SelectCommand = comandoSQL;
            miAdaptadorDatos.Fill(ds, "DepTrabajo");

            return ds;


        }
        public BAgriDataSet obtener_datosRendimientoEmpleados()
        {
            ds.Clear();
            comandoSQL.Connection = miConexion;

            
            comandoSQL.CommandText = "select * from RendimientoEmpleados"; //RendimientoEmpleados
            miAdaptadorDatos.SelectCommand = comandoSQL;
            miAdaptadorDatos.Fill(ds, "RendimientoEmpleados");

            return ds;


        }

       public BAgriDataSet obtener_datosDirecciones()
        {
            ds.Clear();
            comandoSQL.Connection = miConexion;

            
            comandoSQL.CommandText = "select * from Direcciones"; //Direcciones
            miAdaptadorDatos.SelectCommand = comandoSQL;
            miAdaptadorDatos.Fill(ds, "Direcciones");

            return ds;


        }
            public BAgriDataSet obtener_datosCorreos()
        {
            ds.Clear();
            comandoSQL.Connection = miConexion;

            
            comandoSQL.CommandText = "select * from Direcciones"; //Correos
            miAdaptadorDatos.SelectCommand = comandoSQL;
            miAdaptadorDatos.Fill(ds, "Correos");

            return ds;


        }

        public BAgriDataSet obtener_datosMes()
        {
            ds.Clear();
            comandoSQL.Connection = miConexion;


            comandoSQL.CommandText = "select * from Mes"; //Mes
            miAdaptadorDatos.SelectCommand = comandoSQL;
            miAdaptadorDatos.Fill(ds, "Mes");

            return ds; }


        //Empleado
        public void mantenimiento_datosEmpleados(String[] datos, String accion)
        {
            try
            {
                String sql = "";
                if (accion == "nuevo")
                {
                    sql = "INSERT INTO Empleados (Nombre,Apellido,Edad,Correo,Contacto,Direccion,Salario,Departamento) VALUE (" +
                        "'" + datos[1] + "'," +
                        "'" + datos[2] + "'," +
                        "'" + datos[3] + "'," +
                        "'" + datos[4] + "'," +
                        "'" + datos[5] + "'," +
                        "'" + datos[6] + "'," +
                        "'" + datos[7] + "'," +
                        "'" + datos[8] + "'," +

                        "'" + ")";


                }
                else if (accion == "modificar")
                {
                    sql = "UPDATE Estudiante SET " +
                        "Nombre        = '" + datos[1] + "'," +
                        "Apellido         = '" + datos[2] + "'," +
                        "Edad        = '" + datos[3] + "'," +
                        "Correo        = '" + datos[4] + "'," +
                        "Contacto       = '" + datos[5] + "'," +
                        "Direccion      = '" + datos[6] + "'," +
                        "Salario     = '" + datos[7] + "'," +
                        "Departamento     = '" + datos[8] + "'," +
                        "WHERE IdEmpleado = '" + datos[0] + "'"
                        + "'";
                }
                else if (accion == "eliminar")
                {
                    sql = "DELETE Empleado FROM Empleado WHERE IdEmpleado='" + datos[0] + "'";
                }
                procesarSQL(sql);
            }
            catch (IndexOutOfRangeException ior) { MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

             //Deptrabajo

        public void mantenimiento_Deptrabajo(String[] datos, String accion)
        {
            try {
                String sql = "";
                if (accion == "nuevo")
                {
                    sql = "INSERT INTO DepTrabajo (Cod_departamento,Departamento,Encargado) VALUE (" +
                        "'" + datos[1] + "'," +
                        "'" + datos[2] + "'," +
                        "'" + datos[3] + "'," +


                        "'" + ")";


                }
                else if (accion == "modificar")
                {
                    sql = "UPDATE Deptrabajo SET " +
                        "Cod_departamento        = '" + datos[1] + "'," +
                        "Departamento        = '" + datos[2] + "'," +
                        "Encargado        = '" + datos[3] + "'," +

                        "WHERE IdDepTrabajo = '" + datos[0] + "'"
                        + "'";
                }
                else if (accion == "eliminar")
                {
                    sql = "DELETE Deptrabajo FROM Deptrabajo WHERE IdDepTrabajo='" + datos[0] + "'";
                }
                procesarSQL(sql);
            } catch (IndexOutOfRangeException ior) { MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
             //RendimientoEmpleados

        public void mantenimiento_RendimientoEmpleados(String[] datos, String accion)
        {
            try {
                String sql = "";
                if (accion == "nuevo")
                {
                    sql = "INSERT INTO RendimientoEmpleados (Cod_Empleado,Mes,Nombre,Evaluacion) VALUE (" +
                        "'" + datos[1] + "'," +
                        "'" + datos[2] + "'," +
                        "'" + datos[3] + "'," +
                        "'" + datos[4] + "'," +


                        "'" + ")";


                }
                else if (accion == "modificar")
                {
                    sql = "UPDATE RendimientoEmpleados SET " +
                        "Cod_Empleado       = '" + datos[1] + "'," +
                        "Mes       = '" + datos[2] + "'," +
                        "Nombre        = '" + datos[3] + "'," +
                        "Evaluacion        = '" + datos[4] + "'," +


                        "WHERE IdRendimiento = '" + datos[0] + "'"
                        + "'";
                }
                else if (accion == "eliminar")
                {
                    sql = "DELETE RendimientoEmpleados FROM RendimientoEmpleados WHERE IdRendimiento='" + datos[0] + "'";
                }
                procesarSQL(sql);
            } catch (IndexOutOfRangeException ior) { MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }


             //Direcciones


        public void mantenimiento_Direcciones(String[] datos, String accion)
        {
            try {
                String sql = "";
                if (accion == "nuevo")
                {
                    sql = "INSERT INTO Direcciones (Direccion1,Direccion2) VALUE (" +
                        "'" + datos[1] + "'," +
                        "'" + datos[2] + "'," +


                        "'" + ")";


                }
                else if (accion == "modificar")
                {
                    sql = "UPDATE Deptrabajo SET " +
                        "Direccion1       = '" + datos[1] + "'," +
                        "Direccion2       = '" + datos[2] + "'," +


                        "WHERE IdDirecciones = '" + datos[0] + "'"
                        + "'";
                }
                else if (accion == "eliminar")
                {
                    sql = "DELETE Direcciones FROM Direcciones WHERE IdDirecciones='" + datos[0] + "'";
                }
                procesarSQL(sql);
            } catch (IndexOutOfRangeException ior) { MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }




        //Correos


        public void mantenimiento_Correo(String[] datos, String accion)
        {
            try {
                String sql = "";
                if (accion == "nuevo")
                {
                    sql = "INSERT INTO Correo (Correo1,Correo2) VALUE (" +
                        "'" + datos[1] + "'," +
                        "'" + datos[2] + "'," +


                        "'" + ")";


                }
                else if (accion == "modificar")
                {
                    sql = "UPDATE Correo SET " +
                        "Correo1       = '" + datos[1] + "'," +
                        "Correo2       = '" + datos[2] + "'," +


                        "WHERE IdCorreo = '" + datos[0] + "'"
                        + "'";
                }
                else if (accion == "eliminar")
                {
                    sql = "DELETE Correo FROM Correo WHERE IdCorreo='" + datos[0] + "'";
                }
                procesarSQL(sql);
            } catch (IndexOutOfRangeException ior) { MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

             //Mes

            public void mantenimiento_Mes(String[] datos, String accion)
        {
            try {
                String sql = "";
                if (accion == "nuevo")
                {
                    sql = "INSERT INTO Correo (Mes) VALUE (" +
                        "'" + datos[1] + "'," +
                        

                        "'" + ")";


                }
                else if (accion == "modificar")
                {
                    sql = "UPDATE Correo SET " +
                        "Mes     = '" + datos[1] + "'," +
                       
                        
                        
                        "WHERE IdMes = '" + datos[0] + "'"
                        + "'";
                }
                else if (accion == "eliminar")
                {
                    sql = "DELETE Mes FROM Mes WHERE IdMes='" + datos[0] + "'";
                }
                procesarSQL(sql);
            } catch (IndexOutOfRangeException ior) { MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        //


           
        }

        void procesarSQL(String sql)
        {
            try {
                comandoSQL.Connection = miConexion;
                comandoSQL.CommandText = sql;
                comandoSQL.ExecuteNonQuery();
            }
            catch (IndexOutOfRangeException ior)
            {
                MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            }
        }


        }

    





