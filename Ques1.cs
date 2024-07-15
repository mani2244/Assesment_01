namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 1000.0;
            int ans = 0;
            while(x< 100000.0) 
            {
                x += (x) * (0.05);
                Console.WriteLine(x);
                ans++;
            }
            Console.WriteLine(ans);
        }
    }
}
