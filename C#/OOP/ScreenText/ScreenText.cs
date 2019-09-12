using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenText
{
    class ScreenText
    {
        private static int y =0;
        private string text;
        private static int x = 0 ;

        public ScreenText()
        {

        }

        public ScreenText(int x ,int y ,string text)
        {
            X = x;
            Y = y;

            Text = text;
        }

        public ScreenText(int x, string text)
        {
            X = x;

            Text = text;
        }
      

        protected int X {  set => x = value; }
        protected int Y { set => y = value; }
        protected string Text {  set => text = value; }

        public virtual void Display()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }
    }
}
