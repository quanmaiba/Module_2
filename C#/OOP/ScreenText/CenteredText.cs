using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenText
{
    class CenteredText : ScreenText 
    {   
       
        public CenteredText( int x ,string text) : base(x,text)
        {
            X = x;
       
            Text = text;
        }

        public override void Display()
        {
            base.Display();
        }
    }
}
