//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VeterinariaV5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mascotas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Color { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Id_duenio { get; set; }
    
        public virtual Duenio Duenio { get; set; }
    }
}