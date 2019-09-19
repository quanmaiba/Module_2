using System.Collections.Generic;

namespace Zoo
{
    class Cage
    {
        private int cageNumber;
        //private static Cage cage = new Cage();

        private List<Animal> AnimalList = new List<Animal>();

        internal List<Animal> AnimalList1 { get => AnimalList; set => AnimalList = value; }
        public int CageNumber { get => this.cageNumber; set => this.cageNumber = value; }

        public Cage(int cageNumber)
        {
            CageNumber = cageNumber;
        }
        public void AddAnimal(Animal a)
        {

            AnimalList1.Add(a);
            //CageNumber++;


        }
        public void RemoveAnimal(string name)
        {
            foreach (var item in AnimalList1)
            {
                if (item.Name == name)
                {
                    AnimalList1.Remove(item);
                    break;
                }
            }
        }
        public void IterateAnimals()
        {
            foreach (var item in AnimalList1)
            {
                item.ViewInfo();

            }
        }
    }
}
