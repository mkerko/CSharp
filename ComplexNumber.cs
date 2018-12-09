using System;
using System.Collections.Generic;

namespace Lab_3
{
    public class ComplexNumber
    {
        private int _real;
        private int _imaginary;
        
        
        private static readonly Random Random = new Random();
        public ComplexNumber(int real, int imaginary)
        {
            _real = real;
            _imaginary = imaginary;
        }

        public int Real
        {
            get { return _real; }
            set { _real = value; }
        }

        public int Imaginary
        {
            get { return _imaginary; }
            set { _imaginary = value; }
        }

        public  static ComplexNumber Multiplicate(ComplexNumber c1, ComplexNumber c2)
        {
            var r = c1._real * c2._real - c1._imaginary * c2._imaginary;
            var i = c1._real * c2._imaginary + c1._imaginary * c2._real;
            return new ComplexNumber(r, i);
        }
        
        public  static ComplexNumber Sum(ComplexNumber c1, ComplexNumber c2)
        {
            var r = c1._real + c2._real;
            var i = c2._imaginary + c1._imaginary;
            return new ComplexNumber(r, i);
        }
        
        public static ComplexNumber GenerateComplexNumber()
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

        public static void PrintList(IEnumerable<ComplexNumber> numbers)
        {
            foreach (var complexNumber in numbers)
            {
                Console.WriteLine(complexNumber.ToString());
            }
        }
        
        public override string ToString()
        {
            return string.Format("{0} + {1}i", _real, _imaginary);
        }
    }
}