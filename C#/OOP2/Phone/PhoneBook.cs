using System;
using System.Collections;

namespace Phone
{
    class PhoneBook : IPhoneBook
    {
        private SortedList sortList = new SortedList();
        private string name;
        private int phone;

        public string Name { get => name; set => name = value; }
        public int Phone { get => phone; set => phone = value; }
        public SortedList SortList { get => sortList; set => sortList = value; }

        public void InsertPhone(string name, int phone)
        {
            if (sortList.ContainsKey(name))
            {
                sortList[name] += " : " + phone;
                Console.WriteLine("Insert Update");
                return;
            }
            else
            {
                sortList.Add(name, phone);
                Console.WriteLine("Insert");
            }
        }
        public void RemovePhone(string name)
        {
            if (sortList.ContainsKey(name))
            {
                sortList.Remove(name);
                Console.WriteLine("Delete");
                return;
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            //bool check = false;
            //foreach (var item in sortList.Keys)
            //{
            //    if (item.Equals(name))
            //    {
            //        sortList.Remove(item);
            //        check = true;
            //        break;
            //    }
            //}
            //check = false;

            //if (!check)
            //{
            //    Console.WriteLine("Not Found");
            //}
            //else
            //{
            //    Console.WriteLine("Remote Finish");
            //}
        }
        public void UpdatePhone(string name, int newphone)
        {
            if (sortList.ContainsKey(name))
            {
                sortList[name] = newphone;

                return;
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
        public void SearchPhone(string name)
        {
            if (sortList.ContainsKey(name))
            {
                Console.WriteLine($"Phone: {sortList[name]}");
              
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
        public void Sort()
        {
            for (int i = 0; i < sortList.Count; i++)
            {
                Console.WriteLine(sortList.GetKey(i));
            }
        }
        public void Show()
        {
            foreach (var item in sortList.Keys)
            {
                Console.WriteLine();
            }
        }
    }
}
