using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject.AccessModifre
{
    class Student
    {
        int id;
        string name;
        int subn1;
        int subn2;
        int subn3;

        public int Id
        {
            get;
            set;
            
        }
        public string Name
        {
            get;
            set;
        }
        public int Subn1
        {
            get;
            set;

        }
        public int Subn2
        {
            get;
            set;

                

           

        }
        public int Subn3
        {
            get;
            set;
            
        }
    }

    class Student_info
    {
        static void Main(string[] args)
        {
                Student s= new Student();
                s.Id = 07865;
                s.Name = "Manthan";
                s.Subn1 = 85;
                s.Subn2 = 84;
                s.Subn3 = 87;
                int total = s.Subn1 + s.Subn2 + s.Subn3;
                
                double per = (total*100) /300;
                Console.WriteLine(s.Id + " " + s.Name + " " + s.Subn1 + " " + s.Subn2 + " " + s.Subn3);
                Console.WriteLine("Percentage is=" + per);

        }
    }
    
}
