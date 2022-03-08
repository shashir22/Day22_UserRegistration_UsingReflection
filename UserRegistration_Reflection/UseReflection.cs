using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace UserRegistration_Reflection
{
    public class UseReflection
    {
        public static void ReflectionTest()
        {
            Type type = typeof(Validation);

            Console.WriteLine("Full Name : {0}", type.FullName);
            Console.WriteLine("Class Name : {0}", type.Name);

            MethodInfo[] methods = type.GetMethods();

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }

            Console.WriteLine("Properties in Validation Class");
            PropertyInfo[] propertyInfo = type.GetProperties();

            foreach (PropertyInfo property in propertyInfo)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.WriteLine("Constructors in Validation Class :: ");
            ConstructorInfo[] constructors = type.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
