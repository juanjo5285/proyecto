using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
namespace puntoVenta.clases
{
    public class csProBodega
    {
        public DataSet lista_bodega()
        {
            DataSet dsi = new DataSet();
            try
            {
                OracleConnection cn = new OracleConnection();// conexion a la base datos
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                cn.Open();
                OracleDataAdapter da;
                da = new OracleDataAdapter("select * from PRO_BODEGA", cn);
               
                da.Fill(dsi);
                cn.Close();
                
            }
            catch (Exception ex){ 
            
            }
            return dsi;
        }

        public DataSet buscar_bodega(string nombre)
        {
            DataSet dsi = new DataSet();
            try
            {
                OracleConnection cn = new OracleConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                cn.Open();
                OracleDataAdapter da;
                da = new OracleDataAdapter("select * from PRO_BODEGA WHERE BOD_NOMBRE='"+nombre+"'  ", cn);

                da.Fill(dsi);
                cn.Close();

            }
            catch (Exception ex)
            {

            }
            return dsi;
        }
        public Int32 insertar_bodega(Int32 id_bodega,string nombre,string descripcion)
        {
            Int32 respuesta = 0;
            try
            {
                OracleConnection cn = new OracleConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            cn.Open();
            OracleCommand cmd = new OracleCommand("insert into pro_bodega (BOD_ID_BODEGA,BOD_NOMBRE,BOD_UBICACION) VALUES("+id_bodega+",'"+nombre+"','"+descripcion+"')",cn);
            respuesta=cmd.ExecuteNonQuery();
            cn.Close();
            }
            catch(Exception ex){
            }
            return respuesta;
        }
        public Int32 actualizar_bodega(string nombre, string descripcion)
        {
            Int32 respuesta = 0;
            try
            {
                OracleConnection cn = new OracleConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            cn.Open();
            OracleCommand cmd = new OracleCommand("update pro_bodega set BOD_NOMBRE='"+nombre+"',BOD_UBICACION='"+descripcion+"' WHERE BOD_NOMBRE='"+nombre+"'", cn);
            respuesta = cmd.ExecuteNonQuery();
            cn.Close();
            }
            catch (Exception ex){ 
            }
            return respuesta;
        }
        public Int32 eliminar_bodga(string nombre)
        {
            Int32 respuesta = 0;
            try
            {
                OracleConnection cn = new OracleConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                cn.Open();
                OracleCommand cmd = new OracleCommand("delete from pro_bodega WHERE BOD_NOMBRE='" + nombre + "'", cn);
                respuesta = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
            }
            return respuesta;
        }
    }
}