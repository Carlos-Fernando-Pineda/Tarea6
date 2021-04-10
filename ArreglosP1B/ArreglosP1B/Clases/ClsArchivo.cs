using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ArreglosP1B.Clases
{
    class ClsArchivo
    {
        public string[] LeerArchivo(String archivo)
        {
            String[] lineas = File.ReadAllLines(archivo, Encoding.Default);
            return lineas;
        }

        public string LeerTodoArchivo(string archivo)
        {
            string contenidoArchivo;
            using(StreamReader reader = new StreamReader(archivo, Encoding.UTF7))
            {
                contenidoArchivo = reader.ReadToEnd();
            }
            return contenidoArchivo;
        }
    }
}
