using System;

namespace TextToHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TextToHTML textToHTML = new TextToHTML();
            textToHTML.Add("Hello");
            textToHTML.Add("How are you?");

            textToHTML.Display();
        }
    }
}
