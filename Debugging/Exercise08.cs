namespace Excercises.Debugging
{
    class Exercise08
    {
        public static void Excercise()
        {
            object lock1 = new();
            object lock2 = new();

            Task.Run(() =>
            {
                lock (lock1)
                {
                    Thread.Sleep(1000);
                    lock (lock2) { }
                }
            });

            Task.Run(() =>
            {
                lock (lock2)
                {
                    lock (lock1) { }
                }
            });
        }
    }
}
