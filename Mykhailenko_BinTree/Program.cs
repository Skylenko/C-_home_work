using System;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BinTree<Student> binTree = new BinTree<Student>();
            binTree.Put(new Student("23.4.2017", "AAvanov", "Math", 80));
            binTree.Put(new Student("23.4.2017", "Avanov", "Math", 55));
            binTree.Put(new Student("23.4.2017", "Xvanov", "Math", 5));
            binTree.Put(new Student("23.4.2017", "Yvanov", "Math", 0));

            foreach (Student s in binTree)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}