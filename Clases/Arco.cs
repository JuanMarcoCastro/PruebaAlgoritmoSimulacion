using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAlgoritmoSimulacion.Clases
{
    public class Arco
    {
        // Nace Id Punto
        public int IdPuntoOrigen { get; set; }
        public int IdPuntoDestino { get; set; }
        public double Distancia { get; set; }
        
        public double Competitividad { get; set; }

        // Constructor
        // otro comentario
        public Arco()
        { 
        }
        public Arco(Arco arco)
        {
            this.IdPuntoOrigen = arco.IdPuntoOrigen;
            this.IdPuntoDestino = arco.IdPuntoDestino;
            this.Distancia = arco.Distancia;
            this.Competitividad = arco.Competitividad;
        }
    }
}
