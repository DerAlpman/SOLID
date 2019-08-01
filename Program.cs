using System;
using Components.SOLID.Interfaces.SingleResponsibility;
using SOLID.LiskovSubstitution;
using SOLID.SingleResponsibility;
using SOLID.SingleResponsibility.ContactParsers;
using SOLID.SingleResponsibility.ContactWriters;
using SOLID.SingleResponsibility.DataProviders;

namespace SOLID
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            SingleResponsibility();
            LiskovSubstitution();
        }

        private static void SingleResponsibility()
        {
            IContactDataProvider contactDataProvider = new CSVContactDataProvider(@"c:\temp\test.csv");
            IContactParser contactParser = new CSVContactParser();
            IContactWriter contactWriter = new ADOContactWriter();

            IContactProcessor processor = new ContactProcessor();
            //processor.Process(contactDataProvider, contactParser, contactWriter);
        }

        private static void LiskovSubstitution()
        {
            Animal animal = new Dog();
            Console.WriteLine(animal.Walk());
            Console.WriteLine(animal.Run());
            Console.WriteLine(animal.Fly());
            Console.WriteLine(animal.MakeNoise());

            Console.WriteLine();

            animal = new Bird();
            Console.WriteLine(animal.Walk());
            Console.WriteLine(animal.Run());
            Console.WriteLine(animal.Fly());
            Console.WriteLine(animal.MakeNoise());

            Console.WriteLine();

            animal = new Animal();
            Console.WriteLine(animal.Walk());
            Console.WriteLine(animal.Run());
            Console.WriteLine(animal.Fly());
            Console.WriteLine(animal.MakeNoise());
            Console.ReadLine();
        }
    }
}
