// Ejercicio 11: Búsqueda en una lista desordenada

namespace Excercises.Debugging
{
    class Exercise12
    {
        public static void Excercise()
        {
            string rutaArchivo = "datos.txt";
            string[] lineas = File.ReadAllLines(rutaArchivo);
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');
            }
        }
    }
}


