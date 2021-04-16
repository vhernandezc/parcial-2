using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnos.clases
{
    
    class clsArreglos
    {
        private string[] ArregloTemporal;
        private string[] datosN;
        private int i, j;
        private string datoTemporal;

        public clsArreglos(string[] arreglo)
        {
            datosN = arreglo;

        }

        public string[] ordenNombres()
        {
            ArregloTemporal = datosN;

            for (i = 0; i < datosN.Length - 1; i++)
            {
                for (j = i + 1; j < datosN.Length; j++)
                {
                    if (ArregloTemporal[i].CompareTo(ArregloTemporal[j]) > 0)
                    {
                        datoTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datoTemporal;
                    }
                }
            }
            return ArregloTemporal;
        }


        private int[] datosParcial;

        public clsArreglos(int[] arreglo)
        {
            datosParcial = arreglo;

        }

        private int[] ArregloTemporalNB;
        private int x, y;
        private int datoTemporalNB;

        //METODO BURBUJA PARA ORDENAR DE MAYOR A MENOR LOS PARCIALES
        public int[] NotamayorParcial()
        {
            ArregloTemporalNB = datosParcial;

            for (x = 0; x < datosParcial.Length - 1; x++)
            {
                for (y = x + 1; y < datosParcial.Length; y++)
                {
                    if (ArregloTemporalNB[x] < ArregloTemporalNB[y])
                    {
                        datoTemporalNB = ArregloTemporalNB[x];
                        ArregloTemporalNB[x] = ArregloTemporalNB[y];
                        ArregloTemporalNB[y] = datoTemporalNB;
                    }
                }
            }

            return ArregloTemporalNB;
        }


       
        private int[] ArregloTemporalNS;
        private int b, c, datoMin;
        private int datoTemporalNS;

        // METODO BURBUJA PARA ORDENAR DE MENOR A MAYOR LOS PARCIALES
        public int[] notaminParcial()
        {
            ArregloTemporalNS = datosParcial;
            for (b = 0; b < datosParcial.Length; b++)
            {
                datoMin = b;
                for (c = b + 1; c < datosParcial.Length; c++)
                {
                    if (ArregloTemporalNS[datoMin] > ArregloTemporalNS[c])
                    {
                        datoMin = c;
                    }
                }
                datoTemporalNS = ArregloTemporalNS[b];
                ArregloTemporalNS[b] = ArregloTemporalNS[datoMin];
                ArregloTemporalNS[datoMin] = datoTemporalNS;
            }
            return ArregloTemporalNS;
        }
      
    }
}
