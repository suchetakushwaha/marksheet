using System;
namespace MarkSheet
{
  
  class Program3
   {
     static void Main(string[] args)
     {
       Console.WriteLine("Enter your Name");
       string name = Console.ReadLine();
        System.Console.WriteLine("Enter your Roll Number");
        string roll = Console.ReadLine();
        System.Console.WriteLine("Enter Your class");
        string standard = Console.ReadLine();
        System.Console.WriteLine("Enter the Cumputer Marks");
        int C = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Math Marks");
        int m =int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Physics Marks");
        int p = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Chemistry Marks");
        int Ch = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your English Marks");
        int E = int.Parse(Console.ReadLine());

        int obtain = C + m + p + Ch + E;
        int per = obtain * 100 / 500;
        System.Console.WriteLine("------Mrksheet------");
        System.Console.WriteLine("your name is:{0}",name);
        System.Console.WriteLine("your Roll Number is:{0}",roll);
        System.Console.WriteLine("your class is:{0}",standard);
        System.Console.WriteLine("your obtain marks are:{0}",obtain);
        System.Console.WriteLine("your percentage:{0}",per);
        if(per >=80)
        {
           System.Console.WriteLine("Grade A");
           }
           else if(per >= 70)
           {
             System.Console.WriteLine("Grade is:B");
           }
           else if(per >=60){
             System.Console.WriteLine("Grade is: C");
           }
           else if(per >=50){
             System.Console.WriteLine("Grade is: D");
           }
           else if(per >=40){
             System.Console.WriteLine("Grade is: E");
            }
            else if(per >=33){
            System.Console.WriteLine("Grade:F");
            }
            else {
              System.Console.WriteLine("Fail");
    
            }

     }
   }
}



