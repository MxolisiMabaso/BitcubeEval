using System;

class Program
{  
 //Classes

   class Student {
      public string forenames {get; set;}
      public string surname   {get; set;}
      public string emailAddress {get; set;}
      public int dateOfBirth  {get; set;}
      public string degreeLink   {
                                  get { return degreelink; }
                                  set {
                                     if (value >== 1)
                                       degreelink = value;
                                      }
                                    }
      public string firstName {get; set;}
      public string fullName  {get; set;}
      public Speak() {
        Console.WriteLine("Hi there, in here you can manage degrees, courses and students lists");
         }
    }

   class Lecture : Student {
      public string degreeList {
                                get { return degreelist; }
                                set {
                                   if (value >== 1)
                                       degreelist = value;
                                     }
                               }

   class Degree : Student {
      public string degreeName {get; set;}
      public int degreeDurationYears {get; set;}
      public string courseList {
                                get { return courselist; }
                                set {
                                   if (value >== 1)
                                     courselist = value;
                                     }
                                }
      public string lecture    {get; set;}
    }

   class Course : Student {
      public string courseName {get; set;}
      public int courseDurationMonths {get; set;}
      public string courseList {
                                get { return courselist; }
                                set {
                                   if (value >== 1)
                                     courselist = value;
                                     }
                                }
      public string degree {
                             get { return degree; }
                             set {
                                 if (value == 1)
                                   degree = value;
                                 }
                              }
      


    static void Main(string[] args) {

 //New objects

     //New student object
       Student m = new Student();

       m.forenames = Console.ReadLine(); 
       Console.WriteLine(m.forenames);
       m.surname = Console.ReadLine();
       Console.WriteLine(m.surname);
       m.emailAdress= Console.ReadLine();
       Console.WriteLine(m.emailAdress);
       m.dateOfBirth = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine(m.dateOfBirth);
       m.degreeLink = Console.ReadLine();
       Console.WriteLine(m.degreeLink);
       m.firstName = Console.ReadLine();
       Console.WriteLine(m.firstName);
       m.fullName = Console.ReadLine();
       Console.WriteLine(m.fullName);

     //New lecture object
       Lecture z = new Lecture();

       z.forenames = Console.ReadLine();
       Console.WriteLine(z.forenames);
       z.surname = Console.ReadLine();
       Console.WriteLine(z.surname);
       z.emailAdress = Console.ReadLine();
       Console.WriteLine(z.emailAdress);
       z.dateOfBirth = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine(z.dateOfBirth);
       z.degreeList = Console.ReadLine();
       Console.WriteLine(z.degreeList);
       z.firstName = Console.ReadLine();
       Console.WriteLine(z.firstName);
       z.fullName = Console.ReadLine();
       Console.WriteLine(z.fullName);

     //New degree object
       Degree c = new Degree();

       c.degreeName = Console.ReadLine();
       Console.WriteLine(c.degreeName);
       c.degreeDurationYears = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Degree duration years are {0}", c.degreeDuration);
       c.courseList = Console.ReadLine();
       Console.WriteLine(c.courseList);
       c.lecture = Console.ReadLine();
       Console.WriteLine(c.lecture);

     //New course object
       Course a = new Course();

       a.courseName = Console.Readline();
       Console.WriteLine(a.courseName);
       a.courseDurationMonths = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Course durations months is {0}", c.courseDurationMonths);
       a.courseList = Console.ReadLine();
       Console.WriteLine(a.courseList);
       a.degree = Console.ReadLine();
       Console.WriteLine(a.degree);
    }
}