using System;

namespace Encrypter11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("nhap chuoi: ");
            string text = Console.ReadLine();
            string newtext = Encrypter.Encrypt(text);
            Console.WriteLine($" Text encripted: {newtext}");
            string TextDescripted = Encrypter.Decrypt(newtext);
            Console.WriteLine($"Text Decripted: {TextDescripted}");
        }
    }
}
