using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog
{
    class Item
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public string Size { get; set; }

        public Item()
        {

        }
        public Item(string name , string code , string category ,string size)
        {
            Name = name;
            Code = code;
            Category = category;
            Size = size;
        }
        public virtual void Play()
        {
            Console.WriteLine($"Ten: {Name} , Ma: {Code} , Danh Muc:{Category}, Kich Thuoc: {Size}");
        }
        public virtual void RetrieveInformation()
        {

        }
    }
}
