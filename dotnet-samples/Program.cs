using System;

namespace dotnet_samples
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GetAndPrintWorkItems();
            Console.WriteLine("after calling GetAndPrintWorkItems()");
            Console.ReadLine();
        }

        static async void GetAndPrintWorkItems(){
            QueryExecutor qe = new QueryExecutor("vsnrchg","jnq3olrltj5ktkjvltm6pv4rkjrjegom2kz2u7r6334qchs3vr3q");
            await qe.PrintOpenBugsAsync("toggler"); 
        }
    }
}
