using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args)
        {
            Student brailee = new Student(); //To create a new instance of a class
            brailee.FirstName = "Brailee";
            brailee.IsPaid = true;
            brailee.Birthdate = new DateTime(1990, 01, 01);

            Student jesse = new Student(); //To create another instance/ add another student
            jesse.FirstName = "Jesse";
            jesse.IsPaid = true;
            jesse.Birthdate = new DateTime(1990, 1, 1);

            Student briana = new Student();
            briana.FirstName = "Briana";
            briana.IsPaid = true;
            briana.Birthdate = new DateTime(1991, 2, 18);

            Student maggie = new Student();
            maggie.FirstName = "Maggie";
            maggie.IsPaid = true;
            maggie.Birthdate = new DateTime(1998, 4, 4);

            Student glenn = new Student();
            glenn.FirstName = "Glenn";
            glenn.IsPaid = true;
            glenn.Birthdate = new DateTime(1998, 4, 4);

            Student marianne = new Student();
            marianne.FirstName = "Marianne";
            marianne.IsPaid = true;
            marianne.Birthdate = new DateTime(1998, 4, 4);

            Student alex = new Student();
            alex.FirstName = "Alex";
            alex.IsPaid = true;
            alex.Birthdate = new DateTime(1998, 4, 4);

        }
    }
    class Student {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Bootcamp { get; set; }
        public string Status { get; set; } //current, future, past
        public string Email { get; set; }    
        public string Phone { get; set; }
        public bool IsPaid { get; set; } = false;
        public DateTime Birthdate { get; set; }

        //public Student() { } is the constructor, Formatted as a method and the name of the method must match the class/default constructor-no parameters

    }
}
