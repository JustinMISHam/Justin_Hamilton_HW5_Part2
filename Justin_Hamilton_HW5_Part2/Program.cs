// HW 5 Part 2 Lists
//Justin Hamilton

List<Student> StudList;
StudList = new List<Student>();
string userIn;
string m;

do
{
    m = string.Format($"Please input Student {StudList.Count+1} ID: ");
    Console.Write(m);
    string userid = Console.ReadLine();

    m = string.Format($"Please input Student {StudList.Count+1} Name: ");
    Console.Write(m);
    string username = Console.ReadLine();

    m = String.Format($"Please input Student {StudList.Count+1} favorite thing: ");
    Console.Write(m);
    string stufav = Console.ReadLine();

    Student stud;
    stud = new Student();

    stud.id = userid;
    stud.name = username;
    stud.FavThing = stufav;

    StudList.Add(stud);

    m = "Would you like to input another Student?(yes/no) ";
    Console.Write(m);
    userIn = Console.ReadLine();
}
while (userIn=="yes");

Console.WriteLine();

Console.WriteLine("Normal Output: ");
for (int i = 0; i < StudList.Count; i++)
{
    m = string.Format($"Student{i + 1} ID:{StudList[i].id}, Name:{StudList[i].name}, Favorite Thing:{StudList[i].FavThing}");
    Console.WriteLine(m);
}
Console.WriteLine();
Console.WriteLine("Reversed Output: ");
for (int i = StudList.Count-1;i>=0 ;i-- )
{
    m = string.Format($"Student{i+1} ID:{StudList[i].id}, Name:{StudList[i].name}, Favorite Thing:{StudList[i].FavThing}");
    Console.WriteLine(m);
}
Console.WriteLine();
Console.WriteLine("Every other output: ");
for (int i = 0; i <= StudList.Count; i =i + 2)
{
    m = string.Format($"Student{i + 1} ID:{StudList[i].id}, Name:{StudList[i].name}, Favorite Thing:{StudList[i].FavThing}");
    Console.WriteLine(m);
}
Console.WriteLine();
m = string.Format($"Number of Students: {StudList.Count}");
Console.Write(m);
Console.WriteLine();


public class Student
{
    public string id;
    public string name;
    public string FavThing;
}