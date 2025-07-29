//premitive data type

//outputting
Console.WriteLine("Hello, World!");


//inputting
Console.WriteLine("please enter the Name");
string Name = Console.ReadLine();
Console.WriteLine("please enter the Age");

int Age = Convert.ToInt32(Console.ReadLine()); //"27" ==> 27

Console.WriteLine("please enter the gender");
char gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("please enter the Salary");
double Salary = Convert.ToDouble(Console.ReadLine());



Console.WriteLine("helllo " + Name); // concatination
Console.WriteLine($"helllo  {Name} , Age {Age} , G: {gender} , Salary {Salary}"); // string interpolation 
