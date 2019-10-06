/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingExampleProject {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Overloading Example Project");
            Backpacking backpacking = new Backpacking("Mt. Kathadin");  // Everything happens in the constructor
            Console.ReadLine();
        }
    }
}
