using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog
{
    class Film : Item
    {
        public string  Director { get; set; }
        public string Actor  { get; set; }
        public string Actress { get; set; }

        public  Film()
        {

        }
        public Film(string director , string actor ,string actress)
        {
            Director = director;
            Actor = actor;
            Actress = actress;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Dao dien: {Director} , Dien vien chinh :{Actor}, Nu dien vien chinh: {Actress}");
        }
        public override void RetrieveInformation()
        {
            base.RetrieveInformation();
        }

    }
}
