using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Zoo
    {
        Cage cage;
        private List<Cage> CagelList = new List<Cage>();

        internal List<Cage> CagelList1 { get => CagelList; set => CagelList = value; }

        public void AddAnimal(Cage a)
        {
            CagelList1.Add(a);
        }
        public void RemoveCage(int c)
        {
            foreach (var item in CagelList1)
            {
                if (item.CageNumber == c)
                {
                    CagelList1.Remove(item);
                    break;
                }
            }
        }
    }
}
