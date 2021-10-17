using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Photo
    {
        [Geo(10, 20)]
        public string Name { get; set; }
        public string Path { get; set; }

        public Photo(string name)
        {
            Name = name;
        }
    }
}
