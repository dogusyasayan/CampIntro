using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course kurs1 = new Course();
            kurs1.CourseName = "C#";
            kurs1.Teacher = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Course kurs2 = new Course();
            kurs2.CourseName = "Java";
            kurs2.Teacher = "Serdar Karagöz";
            kurs2.IzlenmeOrani = 54;

            Course kurs3 = new Course();
            kurs3.CourseName = "Python";
            kurs3.Teacher = "Adem Kılıççı";
            kurs3.IzlenmeOrani = 37;

            //Array(Dizi) Tanımlama,

            Course[] courses = new Course[] {kurs1,kurs2,kurs3};

            foreach (var kurs in courses)
            {
                Console.WriteLine(kurs.CourseName + " : " + kurs.Teacher);
            }

           
        }
    }

    class Course
    {
        //Property = Özellik
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
