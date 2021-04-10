using System;
using System.Collections.Generic;
using System.Text;

namespace ArreglosP1B.Clases
{
    class ClsArreglos
    {
        private int[] ArregloTemporal;
        private int[] datos;
        private int i, j, datoTemporal, min;
        private int tamanoArreglo = 0;
        private string[] TemporalNombre;
        private string[] nombre;
        private string extra;
        public int GetTamañoArreglo()
        {
            return datos.Length;
        }

        public ClsArreglos(int[] arreglo)
        {
            datos = arreglo;
            tamanoArreglo = datos.Length; // numero de datos
        }

        public ClsArreglos(string[] arreglo)
        {
            nombre = arreglo;
            tamanoArreglo = nombre.Length;
        }

        /// <summary>
        /// Burbuja
        /// intercambiar cada pareja consecutiva no ordenada
        /// </summary>
        /// <returns></returns>

        public int[] MetodoBurbuja()
        {
            ArregloTemporal = datos;

            for (i = 0; i < tamanoArreglo - 1; i++)
            {
                for (j = i + 1; j < tamanoArreglo; j++)
                {
                    if (ArregloTemporal[i] > ArregloTemporal[j])
                    {
                        datoTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datoTemporal;
                    }
                }
            }
            return ArregloTemporal;
        }
        public string[] MetodoBurbujaNombres()
        {
            TemporalNombre = nombre;
            for (i=0; i < tamanoArreglo - 1; j++)
            {
               for(j=i+1; j< tamanoArreglo; j++)
                {
                    if (TemporalNombre[i].CompareTo(TemporalNombre[j]) > 0)
                    {
                        extra = TemporalNombre[i];
                        TemporalNombre[i] = TemporalNombre[j];
                        TemporalNombre[j] = extra;
                    }
                }
            }
            return TemporalNombre;
        }
        public int[] MetodoInsercion()
        {
            ArregloTemporal = datos;
            for(i = 0; i < tamanoArreglo; i++)
            {
                datoTemporal = ArregloTemporal[i];
                j = i - 1;
                while(j >= 0 && ArregloTemporal[j] > datoTemporal)
                {
                    ArregloTemporal[j + 1] = ArregloTemporal[j];
                    j--;
                }
                ArregloTemporal[j + 1] = datoTemporal;
            }
            return ArregloTemporal;
        }
        public int [] MetodoSeleccion()
        {
            ArregloTemporal = datos;
            for (i = 0; i < tamanoArreglo; i++)
            {
                min = i;
                for (j = i + 1; j < tamanoArreglo; j++)
                {
                    if (ArregloTemporal[j] < ArregloTemporal[min])
                    {
                        min = j;
                    }
                }
                datoTemporal = ArregloTemporal[i];
                ArregloTemporal[i] = ArregloTemporal[min];
                ArregloTemporal[min] = datoTemporal;
            }
            return ArregloTemporal;
        }
    }   
}
