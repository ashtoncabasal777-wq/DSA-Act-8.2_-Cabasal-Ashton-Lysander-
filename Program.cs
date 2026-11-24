
            using System;
            using System.Collections;
            using System.Linq;

class Student
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string ContactNo { get; set; }

            public Student(string name, string address, string contactNo)
            {
                Name = name;
                Address = address;
                ContactNo = contactNo;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Create a Hashtable
                Hashtable students = new Hashtable();

                // Store student records
                students.Add(101, new Student("Jose Marie Chou", "Solano", "N/A"));
                students.Add(102, new Student("Marites Alcantara", "Bayombong", "09273744546"));
                students.Add(103, new Student("Pepito Montalban", "Aritao", "09184476548"));

                Console.WriteLine("Welcome to my HASHTABLE Program");

                string choice = "Y";

                while (choice.ToUpper() == "Y")
                {
                    // Display available student records
                    Console.WriteLine("Here are the available records:");
                    Console.WriteLine("Student ID");

                    foreach (int id in students.Keys.Cast<int>().OrderBy(id => id))
                    {
                        Console.WriteLine(id);
                    }

                    // Ask user to enter student ID
                    Console.Write("\nEnter look up id: ");
                    string input = Console.ReadLine();

                    int searchID;

                    if (int.TryParse(input, out searchID))
                    {
                        // Search for the student record
                        if (students.ContainsKey(searchID))
                        {
                            Student student = (Student)students[searchID];

                            Console.WriteLine("\nHere is the detailed information:");
                            Console.WriteLine("Student ID:       " + searchID);
                            Console.WriteLine("Name:             " + student.Name);
                            Console.WriteLine("Address:          " + student.Address);
                            Console.WriteLine("Contact no:       " + student.ContactNo);
                        }
                        else
                        {
                            Console.WriteLine("Record is not existing!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Student ID!");
                    }

                    // Ask if user wants to search again
                    Console.Write("\nWould you like to search another record? [Y/N]: ");
                    choice = Console.ReadLine();

                    Console.WriteLine();
                }

                Console.WriteLine("Thank you for using my HASHTABLE Program!");
                Console.ReadKey();
            }
        }
