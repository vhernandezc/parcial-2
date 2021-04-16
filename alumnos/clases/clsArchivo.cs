using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnos.clases
{
    class clsArchivo
    {
        public string[] leerArchivo(string archivo)
        {
            string[] lineas = File.ReadAllLines(archivo);
            return lineas;
        }
        public string leerTodoArchivo(string archivo)
        {
            string contenidoArchivo;
            using (StreamReader reader = new StreamReader(archivo))
            {
                contenidoArchivo = reader.ReadToEnd();
            }
            return contenidoArchivo;
        }
    }
}
