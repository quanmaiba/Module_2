using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class PhotoAlbum
    {
        protected static int numberOfPages;

        public  PhotoAlbum()
        {
            numberOfPages = 16;
        }
        public  PhotoAlbum(int n)
        {
            numberOfPages = n;
        }

        public  int GetNumberOfPages()
        {
            return numberOfPages;
        }
        
    }
    class BigPhotoAlbum : PhotoAlbum
    {
        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }
    }
    class AlbumTest
    {
        static void Main()
        {
            PhotoAlbum album = new PhotoAlbum();
            Console.WriteLine(album.GetNumberOfPages());

            PhotoAlbum album1 = new PhotoAlbum(24);
            Console.WriteLine(album1.GetNumberOfPages());

            BigPhotoAlbum album2 = new BigPhotoAlbum();
            Console.WriteLine(album2.GetNumberOfPages());

        }
    }
}
