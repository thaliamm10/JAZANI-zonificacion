using System;
using System.Collections.Generic;
using Jazani.ICL.Datos.CompendioNormas.Entidades;

namespace Jazani.ICL.Datos.General.Entidades
{
    public class Area
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Estado { get; set; }
        //
        public virtual ICollection<Persona> Persona { get; set; }
        public virtual ICollection<NormaInteres> NormaInteres { get; set; }
        public Area()
        {
            FechaRegistro = DateTime.UtcNow;
            Estado = 1;
        }
    }
}