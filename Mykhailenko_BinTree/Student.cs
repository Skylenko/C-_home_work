using System;

namespace ConsoleApplication
{
    public class Student : IComparable
    {
        public string dateOfExam;
        public string name;
        public string subject;
        public int mark;

        public Student(string dateOfExam, string name, string subject, int mark)
        {
            this.dateOfExam = dateOfExam;
            this.name = name;
            this.subject = subject;
            this.mark = mark;
        }

        public int CompareTo(object other)
        {
            return string.Compare(name, ((Student)other).name, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return name + " " + dateOfExam + " " + subject + " " + mark;
        }
    }
}