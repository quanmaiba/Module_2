using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog
{
    class Music : Item
    {
        public string Singer { get; set; }
        public string  Length { get; set; }
        public Music()
        {

        }
        public Music(string singer, string length)
        {
            Singer = singer;
            Length = length;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Ca Si: {Singer} , Thoi gian:{Length}");
        }
        public override void RetrieveInformation()
        {
            base.RetrieveInformation();
        }
    }
    
}
