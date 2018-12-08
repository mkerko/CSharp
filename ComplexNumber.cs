using System;
using System.Collections.Generic;

namespace Lab_2
{
    public class ComplexNumber
    {
        private int real;
        private int imaginary;
        
        
        private static readonly Random Random = new Random();
        public ComplexNumber(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public int Real
        {
            get { return real; }
            set { real = value; }
        }

        public int Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }

        public  static ComplexNumber Multiplicate(ComplexNumber c1, ComplexNumber c2)
        {
            var r = c1.real * c2.real - c1.Imaginary * c2.Imaginary;
            var i = c1.real * c2.Imaginary + c1.Imaginary * c2.real;
            return new ComplexNumber(r, i);
        }

        private static ComplexNumber GenerateComplexNumber()
        {
            var r = Random.Next(-10, 10);
            var i = Random.Next(-10, 10);
            return new ComplexNumber(r, i);
        }
        
        public static IEnumerable<ComplexNumber> RandomList(int amount){
            var complexNumbers = new List<ComplexNumber>();
            for (var i = 0; i < amount; i++){
                complexNumbers.Add(GenerateComplexNumber());
            }
            return complexNumbers;
        }

        public static void printList(IEnumerable<ComplexNumber> numbers)
        {
            foreach (var complexNumber in numbers)
            {
                Console.WriteLine(complexNumber.ToString());
            }
        }
        public override string ToString()
        {
            return string.Format("{0} + {1}i", real, imaginary);
        }
    }
}