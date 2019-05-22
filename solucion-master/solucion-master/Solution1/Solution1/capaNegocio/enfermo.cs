using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;//*****-
namespace capaNegocio
{
    public class enfermo
    {
        bdConex test= new bdConex();
        public String b,c,d,e;
        public int a, f;
        public DataTable dt = new DataTable();//**
      

        public void insertVendor(int a,string b,string c,string d, string e,int f)
        {
            try {
                String insert = "INSERT INTO [dbo].[Enfermo]([Inscripcion],[Apellido],[Direccion],[Fecha_Nac],[S],[NSS])VALUES('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "','" + f+ "')";
                    test.Conectar();
                    test.consultaSQL(insert);
                    test.Desconectar();         
            }
            catch {
            
            }
        }


        public void updateVendor(int a,string b,string c,string d, string e,int f)
        {
            try
            {


                String update = "UPDATE [dbo].[Enfermo] SET [Apellido] = '" + b + "',[Direccion] = '" + c + "',[Fecha_Nac] = '" + d + "',[S] = '" + e + "',[NSS]='"+f+"' WHERE Inscripcion = '" + a + "'";
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
                String delete = "DELETE FROM [dbo].[Enfermo] WHERE Inscripcion = '" + f + "'";
               
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
            else {
                test.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;

        }

      



    }
}
