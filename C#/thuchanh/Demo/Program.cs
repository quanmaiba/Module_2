using System;
using System.Collections;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Animal> listAnimal = new List<Animal>();

            //Dog dog = new Dog();
            //listAnimal.Add(dog);



            //foreach (var item in listAnimal)
            //{
            //    Console.WriteLine(item.ToString()); 
            //}
            //string str = "Hello";

            //Console.WriteLine(str);
            //TaphopAnimal animaltaphop = new TaphopAnimal();
            //Dog dog = new Dog();
            //dog.Name = "cho";
            ////dog.Name = "hi";
            //animaltaphop.add(dog);

            NhanVien objEmployee = new NhanVien();
            objEmployee.Them(105, "Minh");
            objEmployee.Them(106, "Quan");
            Console.WriteLine("Ban dau trong Dictionary co nhung ban ghi sau:");
            objEmployee.ChiTiet();
            objEmployee.OnRemove(106);
            Console.WriteLine("Sau khi xoa, Dictionary se chua cac ban ghi sau:");
            objEmployee.ChiTiet();
        }
        class NhanVien : DictionaryBase
        {
            public void Them(int id, string ten)
            {
                Dictionary.Add(id, ten);
            }
            public void OnRemove(int id)
            {
                Console.WriteLine("Ban se xoa ban ghi co ID: " + id);
                Dictionary.Remove(id);
            }
            public void ChiTiet()
            {
                IDictionaryEnumerator objIde = Dictionary.GetEnumerator();
                while (objIde.MoveNext())
                {
                    Console.WriteLine(objIde.Key + "\t" + objIde.Value);
                }
            }
        }
    }
}
