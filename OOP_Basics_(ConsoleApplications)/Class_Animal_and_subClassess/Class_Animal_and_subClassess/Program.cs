using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Animal_and_subClassess
{
    class Animal
    {
        private bool isAlive = default(bool);
        public bool GetIsAlive()
        {
            return isAlive;
        }
        public void SetIsAlive(bool value)
        {
            isAlive = value;
        }
        

    }

    class Chlenistonogie
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal sharick = new Animal();
            sharick.SetIsAlive(false);
            Console.WriteLine(sharick.GetIsAlive());

            // Delay.
            Console.ReadKey();
        }
    }
}
