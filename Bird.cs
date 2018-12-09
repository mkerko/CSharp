using System;
using System.Linq;
using System.Threading;

namespace Lab_4
{
    public class Bird
    {
        private string _name;
        private Wing _leftWing;
        private Wing _rightWing;
        private Beak _beak;

        public Bird(string name)
        {
            _name = name;
            _leftWing = new Wing();
            _rightWing = new Wing();
            _beak = new Beak();
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Wing LeftWing
        {
            get { return _leftWing; }
            set { _leftWing = value; }
        }

        public Wing RightWing
        {
            get { return _rightWing; }
            set { _rightWing = value; }
        }

        public Beak Beak
        {
            get { return _beak; }
            set { _beak = value; }
        }

        public void fly()
        {
            if (_beak.BeakStatus == BeakStatus.CLOSED &&_leftWing.WingStatus == WingStatus.OPENED && 
            _rightWing.WingStatus == WingStatus.OPENED)
            {
                _leftWing.WingStatus = WingStatus.WAVING;
                _rightWing.WingStatus = WingStatus.WAVING;
                foreach (var unused in Enumerable.Range(1, 5))
                {
                    Console.WriteLine("Bird " + _name + " is flying");
                    Thread.Sleep(1000);
                }
                land();
                _leftWing.WingStatus = WingStatus.CLOSED;
                _rightWing.WingStatus = WingStatus.CLOSED;
            }
            else
            {
                Console.WriteLine("Beak is not closed. Could not perform flying.");
            }
            
        }
        
        public void eat()
        {
            if (_leftWing.WingStatus == WingStatus.CLOSED &&
            _rightWing.WingStatus == WingStatus.CLOSED)

            {
                _beak.BeakStatus = BeakStatus.EATING;
                foreach (var unused in Enumerable.Range(1, 5))
                {
                    Console.WriteLine("Bird " + _name + " is eating");
                    Thread.Sleep(1000);
                }
                _beak.BeakStatus = BeakStatus.CLOSED;
            }
            else
            {
                Console.WriteLine("Wings are not closed. Could not perform eating.");
            }
        }
        
        public void attac()
        {
            if (_leftWing.WingStatus == WingStatus.OPENED &&
                _rightWing.WingStatus == WingStatus.OPENED)

            {
                _beak.BeakStatus = BeakStatus.ATTACKING;
                foreach (var unused in Enumerable.Range(1, 5))
                {
                    Console.WriteLine("Bird " + _name + " attacks");
                    Thread.Sleep(1000);
                }
                _beak.BeakStatus = BeakStatus.CLOSED;
            }
            else
            {
                Console.WriteLine("Wings are not opened. Could not perform attacking.");
            }
        }
        
        public void land()
        {
            if (_leftWing.WingStatus == WingStatus.WAVING &&
                _rightWing.WingStatus == WingStatus.WAVING &&
                _beak.BeakStatus == BeakStatus.CLOSED)

            {
                foreach (var unused in Enumerable.Range(1, 5))
                {
                    Console.WriteLine("Bird " + _name + " lands");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Bird " + _name + " successfully landed.");
            }
            else
            {
                Console.WriteLine("Wings are not opened or beak is not closed. Could not perform landing.");
            }
        }
    }
}