using System;
using System.Collections.Generic;
using System.Text;

namespace AntonPaarTask
{
    class Test
    {
        /*
             //Read from file write in another file line by line 

            string filePath = @"../../Data/KSample.txt";
            string filePathWrite = @"../../Data/kwrite.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            lines.Add("Kareem will do it ");

            File.WriteAllLines(filePathWrite, lines);
            */
        //***************************************************************************************


        //Another example using classes
        //**************************************************************************************
        /*
        string filePath = @"../../Data/KSample.txt";
        string filePathWrite = @"../../Data/kwrite.txt";

        List<Person> people = new List<Person>();
        List<string> lines = File.ReadAllLines(filePath).ToList();
        foreach (var line in lines) {
            string[] entries = line.Split(" ");
            Person newPerson = new Person();
            newPerson.FirstName = entries[0];
            newPerson.LastName = entries[1];
            newPerson.Email = entries[2];
            people.Add(newPerson);
        }
        StringBuilder sb = new StringBuilder();
        sb.Append("Hello ");
        sb.AppendLine("World!");
        sb.AppendLine("Hello C#");

        List<string> list = new List<string>();
        foreach (var person in people)
        {
            list.Add($"{person.FirstName} {person.LastName} {person.Email}");

            Console.WriteLine($"{person.FirstName} {person.LastName} {person.Email}");

            //File.WriteAllLines(filePathWrite,);
        }
        File.WriteAllLines(filePathWrite, list);

        Console.ReadLine();
        */
        //*******************************************************************************************************************
        //*******************************************************************************************************************
        //*******************************************************************************************************************
        //*******************************************************************************************************************
    }
}
