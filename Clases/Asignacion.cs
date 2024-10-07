using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAlgoritmoSimulacion.Clases
{
    public class Asignacion
    {
        public double Latitud{ get; set;}
        public double Longitud { get; set; }

        public int IdPunto { get; set; }

        public bool Activo { get; set; }

        public string Especie { get; set; }

        public Asignacion()
        {
        }
        public Asignacion(Asignacion asignacion)
        {
            this.Latitud = asignacion.Latitud;
            this.Longitud = asignacion.Longitud;
            this.Activo = asignacion.Activo;
            this.Especie = asignacion.Especie;
            this.IdPunto = asignacion.IdPunto;
        }
    }
}
