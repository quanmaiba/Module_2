using System;
using System.Collections.Generic;
using System.Text;

namespace TestHouse
{
    class Door
    {
        private string color;

        public string Color { get => color; set => color = value; }

        public Door()
        {
            Color = "brown";
        }
        public Door(string _color)
        {
            Color = _color;
        }
        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {Color}");
        }
        public void ShowData1()
        {
            Console.WriteLine($"I am a house big, my color is {Color}");
        }
    }

}
