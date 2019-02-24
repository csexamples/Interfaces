using System;

namespace ExplicitImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            Console.WriteLine(catalog.Save());

            ISaveable saveable = new Catalog();

            Console.WriteLine(saveable.Save());

            ((IVoidSaveable)catalog).Save();
        }
    }
}
