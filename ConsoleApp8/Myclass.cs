using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Myclass : IDisposable
    {
        public Myclass() { }

        ~Myclass() { }

        public void Dispose()
        {
            GC.Collect();
        }
    }
}
