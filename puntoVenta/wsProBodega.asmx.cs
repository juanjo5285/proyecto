using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
namespace puntoVenta
{
    /// <summary>
    /// Descripción breve de wsProBodega
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsProBodega : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet lista_bodega()
        {
            return new clases.csProBodega().lista_bodega();
        }
        [WebMethod]
        public Int32 insertar_bodega(Int32 id_bodega,string nombre,string descripcion)
        {
            return new clases.csProBodega().insertar_bodega(id_bodega,nombre,descripcion);
        }

        [WebMethod]
        public Int32 actualizar_bodega(string nombre, string descripcion)
        {
            return new clases.csProBodega().actualizar_bodega(nombre, descripcion);
        }
        [WebMethod]
        public Int32 eliminar_bodega(string nombre)
        {
            return new clases.csProBodega().eliminar_bodga(nombre);
        }
    }
}
