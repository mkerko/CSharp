using System;
using System.Linq;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Account a1 = new Account();
            a1.Total = 200;
            Account a2 = new Account();
            a2.Total = 100;
            
            Console.WriteLine("a1 total === " + a1.Total);
            Console.WriteLine("a2 total === " + a2.Total);
            Console.WriteLine();
            
            Account.TransferMoney(a1, a2, 50);
            Account.TransferMoney(a1, null, 50);
            Account.TransferMoney(null, a1, 50);
            
            Console.WriteLine("a1 operations");
            foreach (Account.Operation o in a1.ListOfOperations.AsParallel())
            {
                o.ViewOperation();
            }
            
            Console.WriteLine("a2 operations");
            foreach (Account.Operation o in a2.ListOfOperations.AsParallel())
            {
                o.ViewOperation();
            }
            
            
            Console.WriteLine();
            Console.WriteLine("a1 total === " + a1.Total);
            Console.WriteLine("a2 total === " + a2.Total);
        }
    }
}