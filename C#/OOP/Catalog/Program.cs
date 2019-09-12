using System;
using System.Collections.Generic;

namespace Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Music> MusicList = new List<Music>();
            List<Film> MusicFilm = new List<Film>();
            //Music[] music = new Music[2];

            for (int i = 0; i < 2; i++)
            {
                Music ms = new Music();

                Console.Write("ten: ");
                ms.Name = Console.ReadLine();
                Console.Write("ma: ");               
                ms.Code = Console.ReadLine();
                Console.Write("the loai: ");
                ms.Category = Console.ReadLine();
                Console.Write("kich thuoc: ");
                ms.Size = Console.ReadLine();
                Console.Write("ca si: ");
                ms.Singer = Console.ReadLine();
                Console.Write("thoi gian: ");
                ms.Length = Console.ReadLine();
                //ms.Play();
                Console.WriteLine();
                MusicList.Add(ms);

            }
            foreach(var show in MusicList)
            {
                show.Play();
            }
            for (int i = 0; i < 2; i++)
            {
                Film film = new Film();

                Console.Write("ten: ");
                film.Name = Console.ReadLine();
                Console.Write("ma: ");
                film.Code = Console.ReadLine();
                Console.Write("the loai: ");
                film.Category = Console.ReadLine();
                Console.Write("kich thuoc: ");
                film.Size = Console.ReadLine();
                Console.Write("Dien vien chinh: ");
                film.Actor = Console.ReadLine();
                Console.Write("Nu dien vien chinh: ");
                film.Actress = Console.ReadLine();
                Console.Write("Dao dien: ");
                film.Director = Console.ReadLine();
                //ms.Play();
                Console.WriteLine();
                MusicFilm.Add(film);

            }
            foreach (var show in MusicFilm)
            {
                show.Play();
            }
        }
    }
}
