using System.Collections.Generic;

namespace BaiTapPokemon
{

    //public class RootObject
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public int Height { get; set; }
    //    public int Weight { get; set; }
    //    public int HP { get; set; }
    //    public int Attack { get; set; }
    //    public int Defence { get; set; }
    //    public int Speed { get; set; }
    //    public List<string> Type { get; set; }
    //}
    public class RootObject
    {
        public List<Result> result { get; set; }
    }
    public class Result
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Speed { get; set; }
        public List<string> Type { get; set; }
    }


}
