using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracttionExaple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbsChild obj = new AbsChild();

            obj.Add(10, 2);
            obj.Sub(10, 2);
            obj.Mul(10, 2);
            obj.Div(10, 2);

            Console.ReadKey();

        }
    }

    public abstract class AbsParent
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public void Sub(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }

        public abstract void Mul(int num1, int num2);
        public abstract void Div(int num1, int num2);
    }

    public class AbsChild : AbsParent
    {
        public override void Mul(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }

        public override void Div(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
