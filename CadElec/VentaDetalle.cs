//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadElec
{
    using System;
    using System.Collections.Generic;
    
    public partial class VentaDetalle
    {
        public int id { get; set; }
        public int idVenta { get; set; }
        public int idProducto { get; set; }
        public decimal cantidad { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal total { get; set; }
        public Nullable<bool> registroActivo { get; set; }
        public string usuarioRegistro { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Venta Venta { get; set; }
    }
}
