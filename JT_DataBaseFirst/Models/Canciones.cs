//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JT_DataBaseFirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Canciones
    {
        public int CancionID { get; set; }
        public int AlbumID { get; set; }
        public string NombreCancion { get; set; }
        public double Duracion { get; set; }
        public int AnioLanzamiento { get; set; }
        public string Compositor { get; set; }
    
        public virtual Albums Albums { get; set; }
    }
}
