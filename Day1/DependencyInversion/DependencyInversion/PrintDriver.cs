using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class PrintDriver
    {
        private IInput input;
        private IPrinter printer;
        public PrintDriver(IInput input,IPrinter printer)
        {
            this.input = input;
            this.printer = printer;
        }
        public void print()
        {
            //some logic
            
            var page = input.NextPage();
            while (!input.IsEndOfFile())
            {
                printer.print();
                page = input.NextPage();
            }
            
            
        }
    }

   
}
