using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace week_6_project
{
    /// <summary>
    /// muellime aid datalar istehsal edir
    /// </summary>
    class Teacher
    {
        Hashtable muellimData = new Hashtable();
        private int id=1;
        private string teacher="Teacher";
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                for (int i = 0; i <10; i++)
                {
                    id += 1;
                }
            }
        }
        public string Name { get; set; }
        public string Surame { get; set; }
        public ref readonly  string Vezife =>ref teacher;
        public DateTime DogumTarixi { get; set; }
        public DateTime IseBaslamasi { get; set; }
        public string IslediyiYer { get; set; }

    }
}
