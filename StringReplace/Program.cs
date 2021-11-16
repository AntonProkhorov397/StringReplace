using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello";

            hello = hello.Replace("h", "H");

            Console.WriteLine(hello);
            string panic = "D0n'7 p4n1c!";//Don't panic!

            panic = panic.Replace("0", "o").Replace("7", "t").Replace("4", "a").Replace("1", "i")
                
            Console.WriteLine(panic);




        }


    }
}
