using PruebaAlgoritmoSimulacion.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAlgoritmoSimulacion.Algoritmos
{
    public class GeneradorNumerosAleatoriosJM
    {
        public List<Asignacion> CrearListaOrigen(int puntosTotales, int limiteInferior, 
            int limiteSuperior)
        {
            // Crear lista de asignaciones
            List<Asignacion> listaAsignacion = new List<Asignacion>();
            for (int i = 0; i < puntosTotales; i++)
            {
                Random aleatorio = new Random();
                Asignacion generador = new Asignacion();
                generador.IdPunto = i;
                generador.Latitud = aleatorio.Next(limiteSuperior);
                generador.Longitud = aleatorio.Next(limiteSuperior);
                generador.Activo = false;
                generador.Especie = i.ToString();

                // Agregar a la lista
                listaAsignacion.Add(generador);
            }

            return listaAsignacion;
        }
    }
}
