using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnos.clases
{
    class Promedios : InterfacePromedios
    {

       
        public string[,] clasificar_alumnos(string[,] matriz, string seccion)
        {
            throw new NotImplementedException();
        }

        public string nombre_nota_mayor(string[,] matriz)
        {
            throw new NotImplementedException();
        }

        public string nombre_nota_mayor(string[,] matriz, string seccion)
        {
            throw new NotImplementedException();
        }

        public int promedios_general_seccion(string[] matriz, int columna_oarcial, string seccion)
        {
            throw new NotImplementedException();
        }

        public int promedios_por_parcial(string[,] matriz, int columna_Parcial)
        {
            int acumulador = 0;
            int promedio;
            int totalFilas = matriz.GetLength(0);
            int totalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < totalFilas; fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna_Parcial]);
            }
            promedio = acumulador / (totalFilas - 1);
            return promedio;
        }
       
        public int promedios_por_seccion(string[] matriz, int columna_parcial, string sección)
        {
            throw new NotImplementedException();
        }
    }
}
