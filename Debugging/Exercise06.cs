namespace Excercises.Debugging
{
    class Exercise06
    {
        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n);
        }
    }
}
