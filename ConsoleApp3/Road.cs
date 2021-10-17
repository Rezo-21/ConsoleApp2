using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp3
{
    public sealed class Road
    {
        public string Number { get; set; }
        public int Length { get; set; }
        public override string ToString()
        {
            return $"gza {Number} sigrze {Length}";
        }

    }
}
