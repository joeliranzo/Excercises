// Ejercicio 10: Cálculo de promedio

namespace Excercises.Debugging
{
    class Exercise10
    {
        public static void Excercise()
        {
            int[] calificaciones = [85, 92, 78, -10, 105];
            int suma = 0;
            foreach (int calificacion in calificaciones)
            {
                suma += calificacion;
            }
            double promedio = suma / calificaciones.Length;
        }
    }
}


