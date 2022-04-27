using System;
// using System.Linq;
using System.Collections;

//var names = new[] {"Zachary", "Crash", "Cortex", "Homer", "Bob", "Tina"};

/* The Chunk method is useful for dividing data into smaller equal pieces for parallel processing */
//var chunks = names.Chunk(2);

/* Hash Tables */

namespace Practice
{
    public class Program
    {
        /// <summary>
        /// Basic Hash Table practice,
        /// A hash table is used to store keys and values to refernce for quick and effective lookup times.
        /// Below is how to implement a hash table and when to impliment a hashtable.
        /// Example:
        /// In a student registration system every student would have an ID, and that id would point towards
        /// a object of a student which contains all the data for the student. Every id must be unique, 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();

            Student studentOne = new Student(1, "Zachary", 3.33f);
            Student studentTwo = new Student(2, "Jasmine", 3.78f);
            Student studentThree = new Student(3, "Crash", 0.00f);
            Student studentFour = new Student(4, "Cortex", 4.00f);
            Student studentFive = new Student(5, "Link", 1.67f);

            studentTable.Add(studentOne.Id, studentOne);
            studentTable.Add(studentTwo.Id, studentTwo);
            studentTable.Add(studentThree.Id, studentThree);
            studentTable.Add(studentFour.Id, studentFour);
            studentTable.Add(studentFive.Id, studentFive);

            /* To grab a student from the table, it must be casted as a student object.
             * This is because the hash table is storing the data as a object of type student */
            Student storedStudentOne = (Student)studentTable[studentOne.Id];

            /* Retrieve all values from studentTable */
            foreach (DictionaryEntry entry in studentTable)
            {
                /* For every student "entry" inside the student table
                 * this will grab the object in a temp value 
                 * and output it to the console */
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student Id: {0}", temp.Id);
                Console.WriteLine("Student Name: {0}", temp.Name);
                Console.WriteLine("Student GPA: {0}", temp.GPA);
            }

            foreach (Student value in studentTable.Values)
            {
                Console.WriteLine("Student Id: {0}", value.Id);
                Console.WriteLine("Student Name: {0}", value.Name);
                Console.WriteLine("Student GPA: {0}", value.GPA);
            }
        }

        class Student
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public float? GPA { get; set; }

            public Student(int id, string name, float GPA)
            {
                this.Id = id;
                this.Name = name;
                this.GPA = GPA;

            }
        }
    }
}