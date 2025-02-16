using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_join
{
    // Book sınıfı: Kitabı temsil eden sınıf
    public class Book
    {
        public int BookId { get; set; }   // Kitap ID'si
        public string Title { get; set; }  // Kitap başlığı
        public int AuthorId { get; set; }  // Kitabın yazar ID'si
    }
}