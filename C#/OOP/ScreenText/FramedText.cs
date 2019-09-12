using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenText
{
    class FramedText 
    {
        private static int y;
        private string text;
        private static int x = 0;
        public FramedText( int y, string text)
        {
         
            Y = y;
            Text = text;
        }

        public static int Y {  set => y = value; }
        public string Text {  set => text = value; }

        public  void Display()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }
    }
}
