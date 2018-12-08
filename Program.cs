using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<ComplexNumber> numbers = (List<ComplexNumber>) ComplexNumber.RandomList(2);
            ComplexNumber.printList(numbers);
            var nn = numbers.First();
            numbers.RemoveAt(0);
            ComplexNumber prod = numbers.Aggregate(nn, (a, b) => ComplexNumber.Multiplicate(a, b));
            Console.WriteLine(prod);
        }
    }
}