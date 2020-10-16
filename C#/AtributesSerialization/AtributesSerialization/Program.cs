using System;
using System.Linq;

namespace AtributesSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo("Hello.png")
            {
                Path = @"C:\Hello.png"
            };

            var type = typeof(Photo);
            var attributes = type.GetCustomAttributes(false);

            foreach(Attribute attribute in attributes)
            {
                Console.WriteLine(attribute);
            }

            var properties = type.GetProperties();

            foreach(var prop in properties)
            {
                var attrs = prop.GetCustomAttributes(false);

                if (attrs.Any(a => a.GetType() == typeof(GeoAttribute)))
                {
                    Console.WriteLine(prop.PropertyType + " " + prop.Name);
                }




                
            }
            Console.ReadLine();
        }
    }
}
