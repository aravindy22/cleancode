using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Scanner : IInput
    {
        public bool IsEndOfFile()
        {
            throw new NotImplementedException();
        }

        public int NextPage()
        {
            throw new NotImplementedException();
        }
    }
}
