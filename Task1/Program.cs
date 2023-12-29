using System.Runtime.ConstrainedExecution;

string name = Console.ReadLine();
var tch1 = new Teacher(name);
string name1 = Console.ReadLine();
var st1 = new Student(name1);
string name2 = Console.ReadLine();
var st2 = new Student(name2);
System.Console.WriteLine("---------------------------");
System.Console.WriteLine(tch1.Explain());
System.Console.WriteLine(st1.Study());
System.Console.WriteLine(st2.Study());
