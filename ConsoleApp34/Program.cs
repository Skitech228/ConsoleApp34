using System;
using System.Text;
using System.Reflection;
namespace ConsoleApp34

{
    class Program
    {
        static void Main(string[] args)
        {
            //var obj = new DelegatesContext();
            //Console.ReadLine();
            Class1 attribute = new Class1();
            Console.WriteLine("Свойство с атрибутом");
            Type type = Type.GetType("ConsoleApp34.Class1", false, true);
            Type type2 = Type.GetType("ConsoleApp34.Class2", false, true);
            foreach (MemberInfo mi in type.GetMembers())
            {
                Console.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            }
            Console.WriteLine("-------");
            foreach (MemberInfo mi in type.GetMembers())
            {
                Console.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            }
            Console.WriteLine("Вызов функции:");
            Console.WriteLine(type.GetMethod("b").Invoke(null, null));
            Console.ReadLine();
        }
    }
}