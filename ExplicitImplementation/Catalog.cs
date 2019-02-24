using System;

namespace ExplicitImplementation
{
    public class Catalog : ISaveable, IVoidSaveable
    {
        public string Save()
        {
            return "Concrete save";
        }

        string ISaveable.Save()
        {
            return "ISaveable save";
        }

        void IVoidSaveable.Save()
        {
            Console.WriteLine("IVoidSaveable save");
        }
    }
}
