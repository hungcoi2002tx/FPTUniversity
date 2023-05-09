using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiLePhuong
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Student() { }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public virtual string language()
        {
            return "VietNamese";
        }
        public override string ToString()
        {
            return $"{Id} + {Name}";
        }
    }

    public class SeStudent : Student
    {   
        public string major { get; set; }
        public SeStudent()
        {
        }

        public SeStudent(int id, string name, string major) : base(id, name)
        {
            this.major = major;
        }
        public override string ToString()
        {
            return base.ToString() + " - " + major;
        }

        public override string language()
        {
            return base.language() + " - " + "English";
        }
    }
}
