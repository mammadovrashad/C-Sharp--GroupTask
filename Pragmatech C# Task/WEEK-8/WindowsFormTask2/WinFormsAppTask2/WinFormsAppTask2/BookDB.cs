using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppTask2
{
    static class BookDB
    {
        public static readonly List<Book> database;
        static BookDB()
        {
            database = new List<Book>() {
            new Book("Menim Heyatim", "Sofya Tolstaya", "Roman", 232, "Lev Tolstoyun arvadı, dostu və köməkçisi Sofya Andreyevnanın bu əlyazması uzun illər arxivdə saxlanmış və oxuculara məlum olmamışdır. Çünki S.Tolstayanın vəsiyyətinə görə əlyazması yalnız onun ölümündən 50 il sonra çap edilə bilərdi. Oxucular kitabdan bu böyük insan, onun ailəsi, yaxın adamlarla münasibəti barədə çox şey öyrənəcəklər. Eyni zamanda xatirələr Lev Tolstoyun məlum obrazının dəqiqləşdirilməsinə, bəzi geniş yayılmış şayiə və dedi-qoduların aradan qaldırılmasına kömək edəcəkdir."),
            new Book("Etel Lilian Voyniç", " Chinghiz Torekulovich Aitmatov", "Hekaye", 270, "He was born to a Kyrgyz father and Tatar mother. Aitmatov's parents were civil servants in Sheker. In 1937, his father was charged with bourgeois nationalism in Moscow, arrested, and executed in 1938.[1]"),
            new Book("The Mystery Knight", "George R. R. Martin", "Hekaye", 270, "A full-color graphic novel edition of The Mystery Knight, one of the thrilling Dunk and Egg novellas from George R. R. Martin s A Knight of the Seven Kingdoms and a prequel of sorts to A Game of Thrones")
        };
          
           
        }
    }
}
