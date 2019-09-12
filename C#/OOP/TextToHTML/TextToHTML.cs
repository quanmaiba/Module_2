using System;
using System.Collections.Generic;
using System.Text;

namespace TextToHTML
{
    class TextToHTML
    {
        private string[] html;
        private int lines;
        private int count;


        public TextToHTML()
        {
            count = 0;
            lines = 1000;

            html = new string[lines];
        }

       

        public void Add(string line)
        {
            if (count < lines)
            {
                html[count] = line;
                count++;
            }   
        }
        public string ToString()
        {
            string textHtml;
            textHtml = "\n";
            textHtml += "\n";

            for(int i = 0; i < count; i++)
            {
                textHtml += "";
                textHtml += html[i];
                textHtml += "\n";
            }
            textHtml += "\n";
            textHtml += "\n";

            return textHtml;
        }
        public void Display()
        {
            Console.WriteLine(ToString());
        }
    }
}
