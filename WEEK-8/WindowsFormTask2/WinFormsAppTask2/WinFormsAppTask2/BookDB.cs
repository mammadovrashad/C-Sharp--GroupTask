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
            };
            Book bookdb1 = new Book("Qara Volqa", " Cəmşid Əmirov", "Roman", 290, "Filmdə ın (Laləzar Mustafayeva) başçılıq etdiyi cinayətkar qrupun törətdiyi saysız hesabsız cinayətlərdən və nəhayət hüquq mühafizə orqanları tərəfindən bu cinayətkar qrupun dağıdılmasından danışılır.");
            Book bookdb2 = new Book("Sibumi", " Chinghiz Torekulovich Aitmatov", "Hekaye", 270, "He was born to a Kyrgyz father and Tatar mother. Aitmatov's parents were civil servants in Sheker. In 1937, his father was charged with bourgeois nationalism in Moscow, arrested, and executed in 1938.[1]");
            database.Add(bookdb1);
            database.Add(bookdb2);
        }
    }
}
