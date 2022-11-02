// See https://aka.ms/new-console-template for more information
using School;

Person person = new Person();
Student student = new Student();
Professor professor = new Professor();

person.Greet();

student.SetAge(15).Greet();
student.ShowAge();

professor.SetAge(32).Greet();
professor.Explain();

Console.ReadLine();



