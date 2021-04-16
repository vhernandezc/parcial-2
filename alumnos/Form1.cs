using alumnos.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alumnos
{
    public partial class Form1 : Form
    {


        int[] NmayorParcial1, NmayorParcial2, NmayorParcial3, NmenorParcial1,NmenorParcial2,NmenorParcial3;

        private string[] ArregloNotas;
        public Form1()
        {

            InitializeComponent();
        }



        private void btncargarArchivo_Click(object sender, EventArgs e)
        {
            clsArchivo ar = new clsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "porfa selecciona el archivo";
            ofd.InitialDirectory = @"C:\Users\USER\Desktop\alumnos";
            ofd.Filter = "archivo plano (*.csv)|*.csv";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.leerTodoArchivo(archivo);
                ArregloNotas = ar.leerArchivo(archivo);
                txtresultado.Text = resultado;

            }

        }
        private int Promedios(string[,] matriz, int columna)
        {
            int acumulador = 0;
            int promedio;
            int totalFilas = matriz.GetLength(0);
            int totalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < totalFilas; fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna]);
            }
            promedio = acumulador / (totalFilas - 1);
            return promedio;
        }
       

        // boton para ordenar los nombres alfabeticamente
        private void btnNombres_Click(object sender, EventArgs e)
        {
            ltbresultado.ClearSelected();
            int contador = 0;
            string[] Orden = new string[ArregloNotas.Length - 1];

            foreach (string linea in ArregloNotas)
            {
                if (contador != 0)
                {

                    string[] datos = linea.Split(';');
                    Orden[contador - 1] =$"{ datos[enumColumnas.nombre]}    {datos[enumColumnas.seccion]}";
                }
                contador++;
            }

            clsArreglos ObjArreglo = new clsArreglos(Orden);
            string[] resultado = ObjArreglo.ordenNombres();

            for (int i = 0; i < resultado.Length; i++)
            {
                ltbresultado.Items.Add(resultado[i]);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void PromedioAlumno_Click(object sender, EventArgs e)
        {
            ltbresultado.Items.Clear();
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                ltbresultado.Items.Add($"{datosUnitarios[enumColumnas.nombre]}  {datosUnitarios[enumColumnas.promedio]}");



         }   }   

    //boton para generar el promedio general del parcial 1
    private void btngneralP1_Click(object sender, EventArgs e)
        {
          
                string[,] arregloDosDimensiones = new string[ArregloNotas.Length, 5];
                int numeroLinea = 0;
                foreach (string linea in ArregloNotas)
                {
                    string[] datosUnitarios = linea.Split(';');

                    arregloDosDimensiones[numeroLinea, enumColumnas.parcial1] = datosUnitarios[enumColumnas.parcial1];

                    numeroLinea++;
                }
            int promedio = Promedios(arregloDosDimensiones, enumColumnas.parcial1);
            MessageBox.Show($"el promedio del parcial 1 es: {promedio}");

        }





        //boton para generar el promedio general del parcial 2
        private void btngeneralP2_Click(object sender, EventArgs e)
        {
            string[,] arregloDosDimensiones = new string[ArregloNotas.Length, 5];
            int numeroLinea = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');

                arregloDosDimensiones[numeroLinea, enumColumnas.parcial2] = datosUnitarios[enumColumnas.parcial2];

                numeroLinea++;
            }
            int promedio = Promedios(arregloDosDimensiones, enumColumnas.parcial2);
            MessageBox.Show($"el promedio del parcial 1 es: {promedio}");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //boton para generar el promedio general del parcial 3
        private void btngeneralP3_Click(object sender, EventArgs e)
        {
            string[,] arregloDosDimensiones = new string[ArregloNotas.Length, 5];
            int numeroLinea = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');

                arregloDosDimensiones[numeroLinea, enumColumnas.parcial3] = datosUnitarios[enumColumnas.parcial3];

                numeroLinea++;
            }
            int promedio = Promedios(arregloDosDimensiones, enumColumnas.parcial3);
            MessageBox.Show($"el promedio del parcial 1 es: {promedio}");
        }

        //boton para imprimir la nota mayor y menar de los 3 parciales
        private void btNotamayor_Click(object sender, EventArgs e)
        {

            int contador = 0;
            int[] NotasOrdenParcial1 = new int[ArregloNotas.Length - 1];
            int[] NotasOrdenParcial2 = new int[ArregloNotas.Length - 1];
            int[] NotasOrdenParcial3 = new int[ArregloNotas.Length - 1];
            int[] NotasOrdenParcial4 = new int[ArregloNotas.Length - 1];
            int[] NotasOrdenParcial5 = new int[ArregloNotas.Length - 1];
            int[] NotasOrdenParcial6 = new int[ArregloNotas.Length - 1];
            string[] Orden = new string[ArregloNotas.Length - 1];


            foreach (string linea in ArregloNotas)
            {
                if (contador != 0)
                {

                    string[] datos = linea.Split(';');
                    NotasOrdenParcial1[contador - 1] = int.Parse(datos[enumColumnas.parcial1]);
                    NotasOrdenParcial2[contador -1 ] = int.Parse(datos[enumColumnas.parcial2]);
                    NotasOrdenParcial3[contador -1] = int.Parse(datos[enumColumnas.parcial3]);
                    NotasOrdenParcial4[contador - 1] = int.Parse(datos[enumColumnas.parcial1]);
                    NotasOrdenParcial5[contador - 1] = int.Parse(datos[enumColumnas.parcial2]);
                    NotasOrdenParcial6[contador - 1] = int.Parse(datos[enumColumnas.parcial3]);
                    
                }
                contador++;
            }
                               //le indicamos que arreglo ordene
                   clsArreglos ObjNotas1 = new clsArreglos(NotasOrdenParcial1);
                   clsArreglos ObjNotas2 = new clsArreglos(NotasOrdenParcial2);
                   clsArreglos ObjNotas3 = new clsArreglos(NotasOrdenParcial3);
                   clsArreglos ObjNotas4 = new clsArreglos(NotasOrdenParcial4);
                   clsArreglos ObjNotas5 = new clsArreglos(NotasOrdenParcial5);
                   clsArreglos ObjNotas6 = new clsArreglos(NotasOrdenParcial6);



            NmayorParcial1 = ObjNotas1.NotamayorParcial();
            NmayorParcial2 = ObjNotas2.NotamayorParcial();
            NmayorParcial3 = ObjNotas3.NotamayorParcial();
            NmenorParcial1 = ObjNotas4.notaminParcial();
            NmenorParcial2 = ObjNotas5.notaminParcial();
            NmenorParcial3 = ObjNotas6.notaminParcial();

          
                int notamin1, notamin2, notamin3;
                int notamax1, notamax2, notamax3;

            //imprime el primer resultado del arreglo
                notamax1 = NmayorParcial1[0];
                notamax2 = NmayorParcial2[0];
                notamax3 = NmayorParcial3[0];
                notamin1 = NmenorParcial1[0];
                notamin2 = NmenorParcial2[0];
                notamin3 = NmenorParcial3[0];

            
                label1.Text = $"N. mayor Parcial1 {notamax1}   N. Minima Parcial1 {notamin1}\n N. mayor Parcial2 {notamax2}   N. Minima Parcial2 {notamin2}\n N. mayor Parcial3 {notamax3}   N. Minima Parcial3 {notamin3}";
            }
        }

       
}
        
   

    
        
            
    




