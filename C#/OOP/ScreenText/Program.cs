using System;

namespace ScreenText
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            ScreenText screenText = new ScreenText(2, 1, "quan");
            screenText.Display();

            ScreenText screenText1 = new CenteredText(4,"anhquan");
            screenText1.Display();

            FramedText screenText2 = new FramedText(5, "anhquan123");
            screenText2.Display();
        }
    }
}
