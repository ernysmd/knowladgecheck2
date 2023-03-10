using knowledgecheck2;
using System.Collections.Immutable;
using System;

namespace knowledgecheck2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<MyChildClass>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var myClass = new MyChildClass();

            Console.WriteLine($"Enter the value for Property1 for record {i + 1}: ");
            myClass.Property1 = Console.ReadLine();

            Console.WriteLine($"Enter the value for Property2 for record {i + 1}: ");
            myClass.Property2 = Console.ReadLine();

            recordList.Add(myClass);
        }

        // Print out the list of records using Console.WriteLine()
        foreach (var record in recordList)
        {
            Console.WriteLine($"Record Property1: {record.Property1}");
            Console.WriteLine($"Record Property2: {record.Property2}");
        }
    }
}



