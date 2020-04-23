using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        enum  Operation { Add, Mul, Div=100, Sub = 50};


        static void Main(string[] args)
        {

            Operation op;
            op = Operation.Add;

            switch (op)
            {
                case Operation.Add: break;
                case Operation.Div: break;
                case Operation.Mul: break;
                case Operation.Sub: break;

            }
            op = Operation.Add + 2;
            Console.WriteLine(op);

        }
    }
}
