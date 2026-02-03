////////using System.ComponentModel.Design;
////////using System.Threading.Channels;
////////using static System.Runtime.InteropServices.JavaScript.JSType;
////////using Microsoft.EntityFrameworkCore;
////////using Microsoft.EntityFrameworkCore.SqlServer;
////////using Microsoft.EntityFrameworkCore;
////////using Microsoft.Extensions.Options;

//////////////////Even or Odd////////////


////////while (true)
////////{
////////    Console.WriteLine("Enter Num (or exit)");

////////    string Num = Console.ReadLine();
////////    int ConvertedNum;
////////    if (Num.ToLower() == "exit")
////////        break;
////////    if (!int.TryParse(Num, out ConvertedNum))
////////    {
////////        Console.WriteLine("Invalid Number");
////////        continue;
////////    }
////////    else Console.WriteLine(ConvertedNum % 2 == 0 ? "even" : "Odd");
////////}
////////Console.ReadKey();


//////////////////Even or Odd////////////




//////////////////Reverse Number////////////


////////while (true)
////////{
////////    Console.WriteLine("Enter Num (or exite)");
////////    string Num1 = Console.ReadLine();
////////    if (Num1.ToLower() == "exit")
////////         break;

////////    List<char> Chracters = Num1.ToList() ;
////////    Chracters.Reverse();
////////    List<char> Reverse =Chracters ;
////////    foreach (var i in Chracters)
////////    {
////////        Console.Write(i); 
////////    }
////////}
//////////////////Reverse Number////////////




//////////////////Digits Sum////////////
////////while (true)
////////{                     
////////    Console.WriteLine("Enter Num (or exite)");
////////    string Num2 = Console.ReadLine();
////////    if (Num2.ToLower() == "exit")
////////        break;
////////    //List<char> Chracters2 = Num2.ToList();
////////    //List<char> Chracters3 = new List<char>();
////////    int Sum = 0;
////////    foreach (char ch in Num2)
////////    {
////////        if (!char.IsDigit(ch))
////////        {
////////            Console.WriteLine("invalid input");
////////            break;
////////        }
////////        Sum += ch - '0';

////////    }
////////    Console.WriteLine(Sum);
////////    Console.ReadKey();
////////}
//////////////////Digits Sum////////////


////////char c = 'a';
////////Console.WriteLine('5' - '2');

//////////////////Digits Sum////////////

////////int x = 4681;
////////int Sum = 0;
////////while (x != 0)
////////{
////////    Sum += x % 10;
////////      x /= 10;
////////}
////////Console.WriteLine(Sum);

//////////////////Digits Sum////////////


////////public class AppDbContext:DbContext
////////{
////////    public DbSet<User> Users { get; set; }
////////    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
////////    {
////////        base.OnConfiguring(optionsBuilder);

////////    }


////////}

////////public class User
////////{
////////    public int Id { get; set; }
////////    public string Name { get; set; }
////////}
////////using System;

////////public class Person
////////{
////////    public int Id { get; set; }
////////    public string Name { get; set; }

////////    public Person (string name)
////////        { Name = name; }
////////    public void Man (string Name)
////////    {
////////        Console.WriteLine("My Name is " + Name );
////////    }
////////}

////////public class Teacher : Person
////////{
////////    public Teacher(string name) : base(name)
////////    {
////////        Name = name;
////////    }
////////}
////////class Program { 
////////    static void Main(string[] args)
////////        {
////////        Person P = new Person ("Mobin");
////////        }


//////////}
////////string? x = null ; // ? after type makes variable nullable
////////int? y = null;
////////Console.WriteLine( x ?? "True"  ); // if X = null then return "True" , Left and right must be a same type
////////Console.WriteLine(int.TryParse("453", out int r) ? "True" : "Fales"); // ternery // if trypare returns true left string comes out and if tryparse returns fales right string comes out 
////////int.TryParse("453",out x );

////////List<string> list1 = new List<string>();
////////list1.Add( "True" );
////////Console.WriteLine(list1);
////////foreach (string i  in list1)
////////console.writeline(i);
////////string list2 = /*"/*3456 tigha ro posh ham bezan"*/"9099301030";
////////list<char> list3 = [.. list2];

////////list3.reverse();
////////foreach (char w in list3)
////////    console.write(w + " ");
////////foreach (char q in list2)
////////    console.writeline(q);
////////console.writeline("\n \n \n \n \n \n \n");

////////list2.tolist().foreach (x => console.writeline(x + "\n")) ;
////////list<char> ch = list2.tolist();
////////console.writeline(list2.equals(list3) ? "" : ""); ;
//////using System;
//////using System.Xml;
//////public class Person
//////{
//////    public long Id { get; }
//////    public string FirstName { set; get; }
//////    public string LastName;

//////    //public Person(string firstname, string lastname)
//////    //    {
//////    //        this.FirstName = firstname;
//////    //        this.LastName = lastname;
//////    //    }
//////    public long ShowId()
//////    {
//////        return Id;
//////    }
//////    public string ShowFirstName()
//////    {
//////        return FirstName;
//////    }
//////    public string ShowLastName()
//////    {
//////        return LastName;
//////    }


//////}
//////public class Student : Person
//////{
//////    public double Avreage { get; set; }
//////    public Student(double Avg, string fistname, string lastname)
//////    {
//////        this.Avreage = Avg;
//////        this.FirstName = fistname;
//////        this.LastName = lastname;
//////    }
//////}
//////class program
//////{
//////    static void Main(string[] args)
//////    {
//////        Person P = new Person();
//////        P.FirstName = "";
//////        P.LastName = "";
//////        Console.WriteLine(P.ShowFirstName);
//////        Console.WriteLine(P.ShowLastName());
//////        Student S = new Student(19.32, "Mobin", "Piri");
//////    }

//////}


////List<int> first = [16,17,18,22,20,21, 19];
////first.Order();
////List<int> second = [7, 12, 9, 10, 11,8 , 13];
////second.Order();
////for  (int i = 0; i < first.Count; i++)
////    Console.WriteLine($"{first[i]} is  {second[i]}");
////public class Mobin
////{
////    public string Name { get; set; }
////    private string LastName { get; set; }
////    private long NationalCode { get; set; }
////    private int Age{ get; set; }
////    public Mobin(string name,string lastName,long nationalCode ,int age)
////    {
////        Name = name;
////        LastName = lastName;    
////        NationalCode = nationalCode;
////        Age = age;
////    }
////    public string M()
////    {
////        return Name;
////        return LastName;

////    }
////}

////string x = "gold";
////x.Reverse();
////foreach (var item in x)
////    Console.Write(item);
////namespace Mosh
////{
////    public class Presentation
////    {
////        public int Width { get; set; }
////        public int Height { get; set; }
////        public void Copy()
////            { Console.WriteLine(); }
////        public void Duplicate()
////            { Console.WriteLine(); }
////    }
////    public class Text : Presentation
////    {
////        public int FontSize { get; set; }
////        public string FontName {  get; set; }
////        public void link(string url)
////            { Console.WriteLine(url); }
////    }
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            Text text = new Text();
////            text.Copy();
////        }
////    }
////}

////namespace train
////{
////    public class Const
////    {
////        public readonly string Name = "Mobin";
////        public readonly int Num;

////        public void Print(string Name)
////        {
////            Console.WriteLine(Name);
////        }
////    }

////    public class Program
////    {
////        //public class Test
////        //{
////        //    const int Num = 21 ; // cost Compile time 
////        //    readonly int Num1 ;  // readonly Run time
////        //    public Test(int num)
////        //    {
////        //        Num1 = num;
////        //    }

////        //}
////        static void Main(string[] args) 
////        {
////            const int Name = 2311 ;


////        }
////    }
////}

////namespace str
////{
////    struct point
////    {
////        public int x;
////        public int y;
////    }
////    enum Order
////    {
////        Pending = 0,
////        Paid = 1,
////        Shipped = 2,
////        ShipVia = 3

////    }
////    class Program 
////    {
////        static void Main(string[] args) 
////            {   
////                point p = new point(); 
////            }
////    }


////}

//namespace arr 
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {   
//            int[] Num = { 1, 2, 3 };
//            List<int> List = new List<int>();
//            List.Add(20);
//            Dictionary<int ,string> User = new Dictionary<int ,string>();
//            User.Add(23, "Mobin");
//            bool X = true;
//            Console.WriteLine(X ? 0 : 21);  
//        }

//    }
//}


//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.SqlServer;
////using Microsoft.EntityFrameworkCore.Tools;
//namespace Repo {
//    class Program
//    {
//        public static void Main (string[] args)
//        {





//        }
//    }

//}

//namespace Repo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //using var context = new AppDbContext();
//            //Console.WriteLine("DB Connected");
//        }
//    }
//}
enum M
{
    Unknown,
    Known,
}

//namespace Arr{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            List<string> Number = new List<string> { "Mobin", "Amin", "Hossein" };
//            //Number[0] = "1";
//            //Console.WriteLine(Number.Any(x => x == "Mobin"));
//            string Name = "Moar";
//            //Console.WriteLine (Name.Split("o"));
//            //foreach(var part in Name.Split("o"))
//            //    Console.WriteLine (part);

//            Number.Append("A");
//            foreach (string str in Number)
//            {
//                Console.WriteLine(str);
//            }
//        }
        
//    }
//}

namespace Repo
{
    class program
    {

        static void Main (string[] args)
        {
            using var db = new AppDbContext ();
            db.Products.Add(new Product
            {
                ProductName = "Test",
                Price = 135.156,
                Seller = "Mobin"

            });
            db.SaveChanges ();
        }
    }
}





