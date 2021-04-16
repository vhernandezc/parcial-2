using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnos.clases
{
    interface InterfacePromedios
    {
        /// <summary>
        /// retorna el promedio en base a una columna especifica
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_Parcial"></param>
        /// <returns></returns>
        int promedios_por_parcial(string[,] matriz, int columna_Parcial);

        /// <summary>
        /// retorna el promedio de un parcial en especial y una sección especial
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="sección"></param>
        /// <returns></returns>

        int promedios_por_seccion(string[] matriz, int columna_parcial, string sección);


        /// <summary>
        /// saca el promedio general de todos los alumnos por sección
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_oarcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>



        int promedios_general_seccion(string[] matriz, int columna_oarcial, string seccion);

        /// <summary>
        /// retorna una matriz de dos columnas con el nombre y la otra columna es la sumatoria del parcial del uno al tres
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>

        string[,] clasificar_alumnos(string[,] matriz, string seccion);


        /// <summary>
        /// busca el mejor promedio general por seccion
        /// </summary>
        /// <param name="matriz"></param>
        /// <returns></returns>

        string nombre_nota_mayor(string[,] matriz);


        string nombre_nota_mayor(string[,] matriz, string seccion);
    }

}
    

