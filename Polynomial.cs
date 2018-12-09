using System;
using System.Collections.Generic;

namespace Lab_3
{
    public class Polynomial
    {
        private ComplexNumber _a1;
        private ComplexNumber _a2;

        public Polynomial(ComplexNumber a1, ComplexNumber a2)
        {
            _a1 = a1;
            _a2 = a2;
        }

        public ComplexNumber A1
        {
            get { return _a1; }
            set { _a1 = value; }
        }

        public ComplexNumber A2
        {
            get { return _a2; }
            set { _a2 = value; }
        }
        
        public  static Polynomial Sum(Polynomial p1, Polynomial p2)
        {
            var r = ComplexNumber.Sum(p1._a1, p2._a1);
            var i = ComplexNumber.Sum(p1._a2, p2._a2);
            return new Polynomial(r, i);
        }
        
        public static void PrintList(IEnumerable<Polynomial> polynomials)
        {
            foreach (var polynomial in polynomials)
            {
                Console.WriteLine(polynomial.ToString());
            }
        }
        public override string ToString()
        {
            return string.Format("({0})*x^2 + ({1})*x", _a1, _a2);
        }
        
        private static Polynomial GeneratePolynomial()
        {
            var r = ComplexNumber.GenerateComplexNumber();
            var i = ComplexNumber.GenerateComplexNumber();
            return new Polynomial(r, i);
        }
     
        
        public static IEnumerable<Polynomial> RandomList(int amount){
            var complexNumbers = new List<Polynomial>();
            for (var i = 0; i < amount; i++){
                complexNumbers.Add(GeneratePolynomial());
            }
            return complexNumbers;
        }
    }
}