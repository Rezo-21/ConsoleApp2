using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = new List<Group>();
            var students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new Group(i, "group " + i));
            }

            for (int i = 0; i < 300; i++)
            {
                var student = new Student(Guid.NewGuid().ToString().Substring(0, 5), i % 100)
                {
                    Group = groups[i % 9]
                };

                students.Add(student);
            }

            var binFormatter = new BinaryFormatter();

            using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, groups);
            }

            using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
                var newGroups = binFormatter.Deserialize(file) as List<Group>;
                if (newGroups != null)
                {
                    foreach (var group in newGroups)
                    {
                        Console.WriteLine(group);
                    }
                }
            }
            Console.ReadLine();

            var soap = new SoapFormatter();
           
            using (var file = new FileStream("groups.soap", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, groups.ToArray());
            }

            using (var file = new FileStream("groups.soap", FileMode.OpenOrCreate))
            {
                var newGroups = binFormatter.Deserialize(file) as List<Group>;
               
                if (newGroups != null)
                {
                    foreach (var group in newGroups)
                    {
                        Console.WriteLine(group);
                    }
                }
            }
            Console.ReadLine();

            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Student>));

            using (var file = new FileStream("groups.json", FileMode.Create))
            {
                jsonFormatter.WriteObject(file, groups.ToArray());
            }

            using (var file = new FileStream("groups.json", FileMode.OpenOrCreate))
            {
                var newStudents = jsonFormatter.ReadObject(file) as List<Group>;

                if (newStudents!= null)
                {
                    foreach (var Student in newStudents)
                    {
                        Console.WriteLine(Student);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
