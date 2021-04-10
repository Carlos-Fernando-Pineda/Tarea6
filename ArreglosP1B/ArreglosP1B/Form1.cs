using ArreglosP1B.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArreglosP1B
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        private int[] R1, R2, R3;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonArreglo_Click(object sender, EventArgs e)
        {
            int[] arreglo = new int[5];
            arreglo[0] = 10;
            arreglo[1] = 8;
            arreglo[2] = 16;
            arreglo[3] = 36;
            arreglo[4] = 1;

            ClsArreglos ObjArreglo = new ClsArreglos(arreglo);
            int[] resultado = ObjArreglo.MetodoBurbuja();


             for (int indice=0; indice < resultado.Length; indice++)
            {
                //listBoxResultado.Items.Add(arreglo[indice]);
                listBoxResultado.Items.Add($"valor = {resultado[indice]} Pos = {indice}");
            }

            //foreach(int r in arreglo)
            //{
            //   listBoxResultado.Items.Add($"valor = {r) Pos={"];
            //}
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Title = "Selecciona tu arhivo plano";
            //ofd.InitialDirectory = @"C:\Users\carlo\OneDrive\Documentos\Universidad\Tercer Semestre\Programación I";
            //ofd.Filter = "Archivo plano (*.csv)|*.csv";

            //if (ofd.ShowDialog() = DialogResult.OK)
            {
                var archivo = @"C:\Users\carlo\OneDrive\Documentos\Universidad\Tercer Semestre\Programación I\archivoPlano.csv";
                String resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo); // retorna arreglo
                textBoxContenido.Text = resultado;
            }
        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            int contador = 0;
            foreach(string linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');
                    listBoxResultado.Items.Add(datos[1]);
                }
                contador++;
            }
        }

        private void buttonProm_Click(object sender, EventArgs e)
        {
            int ArraySize = R1.Length;
            double Prom1 = 0, Prom2 = 0, Prom3 = 0;

            for (int i = 0; i< ArraySize; i++)
            {
                Prom1 += R1[i];
                Prom2 += R2[i];
                Prom3 += R3[i];
            }
            Prom1 /= ArraySize;
            Prom2 /= ArraySize;
            Prom3 /= ArraySize;

            textBoxP1.Text = Convert.ToString(Math.Round(Prom1, 2));
            textBoxP2.Text = Convert.ToString(Math.Round(Prom2, 2));
            textBoxP3.Text = Convert.ToString(Math.Round(Prom3, 2));
        }

        private void buttonMayor_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            int[] nota = new int[3];
            string[] nombre = new string[3];
            int contador = 0;

            foreach(string linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');
                    if (Convert.ToInt32(datos[2])> nota[0])
                    {
                        nota[0] = Convert.ToInt32(datos[2]);
                        nombre[0] = datos[1];
                    }
                    if (Convert.ToInt32(datos[3]) > nota[1])
                    {
                        nota[1] = Convert.ToInt32(datos[3]);
                        nombre[1] = datos[1];
                    }
                    if (Convert.ToInt32(datos[4]) > nota[2])
                    {
                        nota[2] = Convert.ToInt32(datos[4]);
                        nombre[2] = datos[1];
                    }
                }
                contador++;
            }
            listBoxResultado.Items.Add($"Primer Parcial: {nombre[0]}{nota[0]}");
            listBoxResultado.Items.Add($"Primer Parcia2: {nombre[1]}{nota[1]}");
            listBoxResultado.Items.Add($"Primer Parcia3: {nombre[2]}{nota[2]}");
        }

        private void buttonMenor_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            int[] nota = new int[3];
            string[] nombre = new string[3];
            int contador = 0;
            nota[0] = 2;
            nota[1] = 2;
            nota[2] = 2;

            foreach(string linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');
                    if (Convert.ToInt32(datos[2]) < nota[0]) ;
                    {
                        nota[0] = Convert.ToInt32(datos[2]);
                        nombre[0] = datos[1];
                    }
                    if (Convert.ToInt32(datos[3]) < nota[1]) ;
                    {
                        nota[1] = Convert.ToInt32(datos[3]);
                        nombre[1] = datos[1];
                    }
                    if (Convert.ToInt32(datos[4]) < nota[2]) ;
                    {
                        nota[2] = Convert.ToInt32(datos[4]);
                        nombre[2] = datos[1];
                    }
                }
                contador++;
            }
            listBoxResultado.Items.Add($"Primer Parcial: {nombre[0]}{nota[0]}");
            listBoxResultado.Items.Add($"Primer Parcia2: {nombre[1]}{nota[1]}");
            listBoxResultado.Items.Add($"Primer Parcia3: {nombre[2]}{nota[2]}");
        }

        private void buttonOrdNombres_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            int contador = 0;
            string[] nombre = new string[ArregloNotas.Length - 1];

            foreach (string linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');
                    nombre[contador - 1] = datos[1];
                }
                contador++;
            }
            ClsArreglos ObjNombre = new ClsArreglos(nombre);
            string[] resultado = ObjNombre.MetodoBurbujaNombres();

            for (int indice = 0; indice < resultado.Length; indice++)
            {
                listBoxResultado.Items.Add(resultado[indice]);
            }
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            listBoxResultado.Items.Clear();
            int[] Parcial1 = new int[ArregloNotas.Length - 1];
            int[] Parcial2 = new int[ArregloNotas.Length - 1];
            int[] Parcial3 = new int[ArregloNotas.Length - 1];

            foreach (string linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');
                    Parcial1[contador - 1] = Convert.ToInt32(datos[2]);
                    Parcial2[contador - 1] = Convert.ToInt32(datos[3]);
                    Parcial3[contador - 1] = Convert.ToInt32(datos[4]);
                }
                contador++;
            }
            ClsArreglos ObjParcial1 = new ClsArreglos(Parcial1);
            ClsArreglos ObjParcial2 = new ClsArreglos(Parcial2);
            ClsArreglos ObjParcial3 = new ClsArreglos(Parcial3);

            R1 = ObjParcial1.MetodoBurbuja();
            R2 = ObjParcial2.MetodoSeleccion();
            R3 = ObjParcial3.MetodoInsercion();

            listBoxResultado.Items.Add("1.ro\t 2.do\t 3.ro");

            for (int indice = 0; indice < R1.Length; indice++)
            {
                listBoxResultado.Items.Add($"{R1[indice]}\t{R2[indice]}\t{R3[indice]}");
            }
            buttonProm.Enabled = true;
        }
    }
}
