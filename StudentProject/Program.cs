using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args)
        {
            Student brailee = new Student(); //To create a new instance of a class
            brailee.SetStatus("CURRENT");
            brailee.FirstName = "Brailee";
            brailee.IsPaid = true;
            brailee.Birthdate = new DateTime(1990, 01, 01);
            brailee.SetCreditScore(100);
            brailee.SetCreditScore(900);
            Console.WriteLine($"Brailee credit score is {brailee.CreditScore}");

            Student jesse = new Student("Jesse", "Kyle"); //To create another instance/ add another student
            Console.WriteLine($"Jesse: {jesse.FirstName} {jesse.LastName}");
            jesse.SetStatus("past");
            jesse.IsPaid = true;
            jesse.Birthdate = new DateTime(1990, 1, 1);

            Console.WriteLine($"Brailee's Bootcamp is {brailee.Bootcamp}");
            Console.WriteLine($"Jesse's Bootcamp is {jesse.Bootcamp}");

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

            Student titus = new Student();
            titus.FirstName = "Titus";
            titus.IsPaid = true;
            titus.Birthdate = new DateTime(1998, 4, 4);


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
        public int CreditScore { get; private set; } //To keep the user from changing the value. Can read, can't write.

        public void SetStatus(string status)  //To set the status. Include void bc void doesnt return a value and status can only be one of three options 
                                              //Must be CURRENT, FUTURE, PAST in all caps
        {
            if ((status == "CURRENT") || (status == "PAST") || (status == "FUTURE"))
            {
                this.Status = status;

            }
            else
            {
                Console.WriteLine("Status must be CURRENT, PAST, or FUTURE");
            }
        }

        //Set credit score to only accept values 400 - 900
            public void SetCreditScore(int score)
        {
                if(score >= 400 && score <= 900)
            {
                this.CreditScore = score;
            }   else
            {
                Console.WriteLine("Credit Score must be between 400 - 900");
            }
        }



            public Student(string firstName, string lastName)
            //public Student() { } is the constructor, Formatted as a method and the name of the method must match the class/default constructor-no parameters
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Bootcamp = "Java";
            }
            public Student()
            {
                this.Bootcamp = ".Net"; //to make the bootcamp field default to .Net
            }
        }
    }

