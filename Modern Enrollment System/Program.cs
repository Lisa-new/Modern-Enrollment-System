// See https://aka.ms/new-console-template for more information

using Modern_Enrollment_System;
using System.Runtime.CompilerServices;

List<Courses> MSUCourses;

var ComputerCourse = new Courses(1, "ComputerCourse");

ComputerCourse.StudentCourse = new List<StudentCourse>()
{
    new StudentCourse() { Id = 1, Subject = "Software Engineering", IsTaken = false },
    new StudentCourse() { Id = 2, Subject = "C Programming", IsTaken = false },
    new StudentCourse() { Id = 3, Subject = "Web Design", IsTaken = false },
    new StudentCourse() { Id = 4, Subject = "3D Animation", IsTaken = false },
    new StudentCourse() { Id = 5, Subject = "Microsoft Office", IsTaken = false },
 };

var AccountingCourse = new Courses(2, "AccountingCourse");

AccountingCourse.StudentCourse = new List<StudentCourse>()
{
    new StudentCourse() { Id = 1, Subject = "Accounting System & Services", IsTaken = false },
    new StudentCourse() { Id = 2, Subject = "Accounting Techniques & Software", IsTaken = false },
    new StudentCourse() { Id = 3, Subject = "Accounting Theory", IsTaken = false },
    new StudentCourse() { Id = 4, Subject = "Auditing", IsTaken = false },
    new StudentCourse() { Id = 5, Subject = "Financial Accounting", IsTaken = false },
};

var EngineeringCourse = new Courses(3, "EngineeringCourse");
EngineeringCourse.StudentCourse = new List<StudentCourse>()
{
    new StudentCourse() { Id = 1, Subject = "Mechanics", IsTaken = false },
    new StudentCourse() { Id = 2, Subject = "Structural Designing", IsTaken = false },
    new StudentCourse() { Id = 3, Subject = "Advance Software Engineering", IsTaken = false },
    new StudentCourse() { Id = 4, Subject = "Engineering Mathematics", IsTaken = false },
    new StudentCourse() { Id = 5, Subject = "Communication Engineering", IsTaken = false },
};

MSUCourses = new List<Courses> ();
MSUCourses.Add(ComputerCourse);
MSUCourses.Add(AccountingCourse);
MSUCourses.Add(EngineeringCourse);

Console.WriteLine("Welcome to MSU Student Enrollment System!");
Console.WriteLine("\n\n ****** Press Y to Register ****** \n\n");

var inputBegin = Console.ReadLine();

if (inputBegin.ToLower() == "y")
{
    Console.WriteLine("\n\nCourses Offered for 1st Semester\n");
    Console.WriteLine("\nThese are the following Courses:\n\n");

    /* for (int i = 0; i < MSUCourses.Count; i++)
       {
         //Combining 2 var to make 1 string (interpulation)
         Console.WriteLine($"{MSUCourses[i]. Name}");
     }
    */
    foreach (var courses in MSUCourses)
    {
        //merging the 3 variables in 1 string interpulation ($)
        Console.WriteLine($"{courses.Id}. {courses.Name}");
    }
    var inputCourses = Console.ReadLine();

    var selectedCourses = MSUCourses.FirstOrDefault(courses => courses.Id.ToString() == inputCourses);

    if (selectedCourses == null)
    {
        Console.WriteLine("\n\n****Invalid Courses Input****\n");
    }
    else
    {
        Console.WriteLine($"\n\n****Your Are Choosing {selectedCourses.Name}!****\n");
        SelectStudentCourse(selectedCourses);
    }
        
        /* switch (inputCourses)
         {
             case "1":
                 Console.WriteLine("\n\n****You are Choosing ComputerCourse!\n");
                 break;
             case "2":
                 Console.WriteLine("\n\n****You are Choosing AccountingCourse!\n");
                 break;
             case "3": Console.WriteLine("\n\n****You are Choosing EngineeringCourse!\n");
                 break;
             case "4": Console.WriteLine("\n\n****Invalid Courses Input****\n");
                 break;
         }
        /*

         //using 2 if else
         /*if (inputCourses == "1")
         {
             Console.WriteLine("\n\n**** Welcome to ComputerCourse!****\n");

         }
         else if (inputCourses == "2")
         {
             Console.WriteLine("\n\n**** Welcome to ComputerCourse!****\n");
         }
         else
         {

         }
         Console.WriteLine("\n\n**** Invalid Courses Input!****\n");
     }
         */
    }  //void- wala sya gina return   //method  //parameter
    void SelectStudentCourse(Courses selectedcourses)
    {
       Console.WriteLine($"\nHere are the pre-requisites Subjects in {selectedcourses.Name}:\n");

        foreach (var curriculum in selectedcourses.StudentCourse)
        {
            //?- means tertiary operator
            Console.WriteLine($"{curriculum.Subject} - {(curriculum.IsTaken ? "This subject is unavailable." : "Available")}");
        }
        Console.WriteLine($"\nPlease Select the Required Curriculum: \n");
        var inputStudentCourse = Console.ReadLine();

        var selectedCurriculum = selectedcourses.StudentCourse.FirstOrDefault(curriculum => curriculum.Subject == inputStudentCourse);

    if (selectedCurriculum == null)
    {
        Console.WriteLine($"\nYou have Entered an Invalid Subject. Press any key to Select Another Subject of N to Exit\n");
        SelectAnotherCurriculum(selectedcourses);
    }
    else
    {
        if (selectedCurriculum.IsTaken)
        {
            Console.WriteLine("\nSorry, this Subject is unavailable. Press any key Select Another Subject or N to Exit.");
            SelectAnotherCurriculum(selectedcourses);
        }
        else
        {
            Console.WriteLine($"\nCongratulations! You have Successfully Choose the Pre-requisite {selectedCurriculum.Subject} on {selectedcourses.Name} Thank You! Would you like to Choose Another Subjects? or Press any key to exit");
            selectedCurriculum.IsTaken = true;
            SelectAnotherCurriculum(selectedcourses);
           
            //calling itself
            //SelectStudentCourse(selectedcourses);
        }
    }
}
void SelectAnotherCurriculum(Courses selectedcourses)
{
    var anotherCurriculum = Console.ReadLine();
    
    if (anotherCurriculum.ToLower() == "n")
    {
        return;
    }

    SelectStudentCourse(selectedcourses);
}

    return;


    
    