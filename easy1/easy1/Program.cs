using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me your name");
            String name = Console.ReadLine();
            Console.WriteLine("Please give me your age");
            String age = Console.ReadLine();
            Console.WriteLine("Please give me your username");
            String username = Console.ReadLine();

            Console.WriteLine("Your name is " + name + ", you are " + age + " years old, and your user name is " + username + ".");
            Console.WriteLine("Would you like to write to file? y/n");
            if(Console.ReadLine().Equals("y") || Console.ReadLine().Equals("Y"))
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter("userinfo.txt");
                writer.WriteLine("Your name is " + name + ", you are " + age + " years old, and your user name is " + username + ".");
                writer.Close();
                Console.WriteLine("Text written to file: userinfo.txt");
            }
            Console.WriteLine("Press enter to end program");
            Console.ReadLine();            
        }
    }
}
