using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LaPoderosaWebMVC.Models;
using System.Web.Services;

namespace LaPoderosaWebMVC
{
    /// <summary>
    /// Descripción breve de LaPoderosaWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class LaPoderosaWS : System.Web.Services.WebService
    {
        //instanciamos el modelo de los datos
        LaPoderosaModelContainer bd = new LaPoderosaModelContainer();

        [WebMethod]
        public List<SWProducto> ListaProductos()
        {
            return bd.Productos.Select(x=>new SWProducto() {
                                        Id=x.Id,
                                        NombreProducto=x.NombreProducto,
                                        PrecioUnidad=x.PrecioUnidad,
                                        UnidadEnExistencia=x.UnidadEnExistencia
            }).ToList();
        }

        [WebMethod]
        public List<ProveedorCount> ListaProveedores()
        {
            return bd.Proveedores.Select(x => new ProveedorCount()
            {
                NombreProveedor = x.Nombre,
                cantidad = x.Productos.Count
            }).ToList();
        }
        //Definir la clas eproducto para que se pueda seriabilizar;
        public partial class SWProducto
        {
            public int Id { get; set; }
            public string NombreProducto { get; set; }
            public decimal PrecioUnidad { get; set; }
            public short UnidadEnExistencia { get; set; }

        }

        public class ProveedorCount
        {
            public string NombreProveedor { get; set; }
            public int cantidad { get; set; }
        }

    }
}
