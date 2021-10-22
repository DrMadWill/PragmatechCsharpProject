using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");


            Student student_1 = new Student("Domation Road","SSS",25);
            Student student_2 = new Student("Mad Will", "SSS", 23);
            Student student_3 = new Student("Rafeyel Mika", "A5", 25);
            Student student_4 = new Student("Long Fang", "A5", 25);
            Student student_5 = new Student("Shoko Komi", "A5", 18);


            Student[] A5 = new Student[3];
            A5[0] = student_3;
            A5[1] = student_4;
            A5[2] = student_5;


            Student[] SSS = new Student[2];
            SSS[0] = student_1;
            SSS[1] = student_2;




            GetBirthYear(student_1.Age);

            ClassroomMembers(SSS);



        }

        public static void GetBirthYear(int Age)
        {
            int birth_year = 2021 - Age;
            Console.WriteLine($" Brith Year : {birth_year}");
        }

        public static void ClassroomMembers(Student[] GropNo)
        {
            Console.WriteLine($" Classroom Members : {GropNo.Length}");
        }

    }


    class Student
    {
        public string FullName;
        public string GroupNo;
        public int Age;

        public Student(string FullName,string GroupNo,int Age)
        {
            this.FullName = FullName;
            this.GroupNo = GroupNo;
            this.Age = Age;
        }



    }
}
