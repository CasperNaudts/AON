using System;
using System.Security.Cryptography;

namespace MigrationStartup
{
    class Program
    {
        static void Main(string[] args)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            Console.WriteLine(RSA.ToString());
            Console.Read();
        }
    }
}
