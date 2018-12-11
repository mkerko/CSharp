using System;
using System.Collections;

namespace ConsoleApplication1
{
    public class Account
    {
        public int Total { get; set; }

        private readonly ArrayList _listOfOperations = new ArrayList();

        public ArrayList ListOfOperations
        {
            get { return _listOfOperations; }
        }

        public abstract class Operation
        {
            public int Amount { get; set; }

            protected Operation()
            {
            }

            protected Operation(int amount)
            {
                Amount = amount;
            }

            public abstract void ViewOperation();

        }

        public class Withdraw : Operation
        {
            public Withdraw(int amount) : base(amount)
            {
            }

            public override void ViewOperation()
            {
                Console.WriteLine("Withdraw operation with " + Amount + " dollars");
            }
        }
        
        public class TransferTo : Operation
        {
            public TransferTo(int amount) : base(amount)
            {
            }

            public override void ViewOperation()
            {
                Console.WriteLine("TransferTo operation with " + Amount + " dollars");
            }
        }
        
        public class TransferFrom : Operation
        {
            public TransferFrom(int amount) : base(amount)
            {
            }

            public override void ViewOperation()
            {
                Console.WriteLine("TransferFrom operation with " + Amount + " dollars");
            }
        }
        
        public class Add : Operation
        {
            public Add(int amount) : base(amount)
            {
            }

            public override void ViewOperation()
            {
                Console.WriteLine("Add operation with " + Amount + " dollars");
            }
        }

        private void AddOperationToAccount(Operation operation)
        {
            _listOfOperations.Add(operation);
        }
        
        public static void TransferMoney(Account from, Account to, int amount)
        {
            if (from != null && to != null)
            {
                Operation operationFrom = new TransferFrom(amount);
                Operation operationTo = new TransferTo(amount);
                from.AddOperationToAccount(operationFrom);
                to.AddOperationToAccount(operationTo);
                from.Total -= amount;
                to.Total += amount;
                
            } else if (from != null)
            {
                from.Total -= amount;
                Operation withdraw = new Withdraw(amount);
                from.AddOperationToAccount(withdraw);
            }else if (to != null)
            {
                to.Total += amount;
                Operation add = new Add(amount);
                to.AddOperationToAccount(add);
            } 
            else
            {
                Console.WriteLine("No operation found ==== ");
            }
        }
    }
}