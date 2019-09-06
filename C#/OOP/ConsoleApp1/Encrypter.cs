using System;
using System.Collections.Generic;
using System.Text;

namespace Encrypter11
{
    class Encrypter
    {
        public static string Encrypt(string text)
        {
            int letterInt = 0;
            char letter = ' ';
            string textEncripted = "";
            for(int i = 0;i<text.Length; i++)
            {
                letterInt = (int)text[i] + 2;
                Console.WriteLine(letterInt);
                letter = (char)letterInt;
                Console.WriteLine(letter);
                textEncripted += letter.ToString();
                Console.WriteLine(textEncripted);
            }
          
            return textEncripted;
        }
        public static string Decrypt(string text)
        {
            int letterInt = 0;
            char letter = ' ';
            string textDecripted = "";
            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] + 1;
                letter = (char)letterInt;
                textDecripted += letter.ToString();
            }
            return textDecripted;
        }
    }
}
