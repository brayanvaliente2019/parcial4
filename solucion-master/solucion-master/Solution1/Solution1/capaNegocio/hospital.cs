using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;//*****-
namespace capaNegocio
{
    public class hospital
    {
        bdConex test = new bdConex();
        public String b, c, d;
        public int a, e;
        public DataTable dt = new DataTable();//**


        public void insertVendor(int a, string b, string c, string d, int e)
        {
            try
            {
                String insert = "INSERT INTO  [hospital].[Hospital]([Hospital_Cod],[Nombre],[Direccion],[Telefono],[Num_Cama])VALUES('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "')";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {

            }
        }


        public void updateVendor(int a, string b, string c, string d, int e)
        {
            try
            {


                String update = "UPDATE  [hospital].[Hospital] SET [Nombre] = '" + b + "',[Direccion] = '" + c + "',[Telefono] = '" + d + "',[Num_Cama] = '" + e + "' WHERE Hospital_Cod = '" + a + "'";
                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {

            }
        }

        public void deletVendor()
        {
            try
            {
                String delete = "DELETE FROM  [hospital].[Hospital] WHERE Hospital_Cod = '" + a + "'";

                test.Conectar();
                test.consultaSQL(delete);
                test.Desconectar();
            }
            catch
            {

            }
        }


        public String prueba()
        {
            String mensaje;
            if (test.Conectar() == true)
            {
                test.Desconectar();
                mensaje = "Conexion realizada";
            }
            else
            {
                test.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;

        }

      





    }
}
