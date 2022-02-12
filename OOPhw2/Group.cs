using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPhw2
{
    internal class Group
    {
        public string No;
        public int Limit;
        private Student[] _students;


        public Group(string no,int limit)
        {
            No = no;
            Limit = limit;
            _students = new Student[0];
        }

        public void AddStudent(Student temp)
        {
            if (_students.Length<Limit)
            {
                Array.Resize(ref _students, _students.Length+1);
                _students[_students.Length-1] = temp;
            }
            else
            {
                Console.WriteLine("Yer doludu, bashga kapiya aslanim");
            }
        }



        public void GetStudents()
        {
            foreach (var std in _students)
            {
                Console.WriteLine($"\nAdi- {std.Name}\nSoyad- {std.Surname}\nGroup nomre - {No}");
            }
        }

        



                                    

    }
}
