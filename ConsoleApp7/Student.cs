using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    [DataContract]
    public class Student
    { 
        [DataMember]
        public string Name { get; }
      
        [DataMember] 
        public int Age { get; }
      
        [DataMember]
        public Group Group { get; set; }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
