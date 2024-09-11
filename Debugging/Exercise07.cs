namespace Excercises.Debugging
{
    class Exercise07
    {
        public static void Excercise()
        {
            Task.Run(() =>
            {
                throw new Exception("Excepción en hilo secundario");
            });
        }
    }
}
