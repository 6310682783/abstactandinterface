// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

var teacher = new Teacher("KP",3000.00,"men");
teacher.Whoami();
var teachertax = teacher.Gettax();
Console.WriteLine($"tax is {teachertax}");
Console.WriteLine();

var doctor = new Doctor("DT", 5000.00, "women");
doctor.Whoami();
var doctertax = doctor.Gettax();
Console.WriteLine($"tax is {doctertax}");
Console.WriteLine();


var student = new Student("ST", 1000.00, "men");
student.Whoami();
var studenttax = student.Gettax();
Console.WriteLine($"tax is {studenttax}");
Console.WriteLine();

