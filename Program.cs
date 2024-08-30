using System;
using System.ComponentModel;
namespace ADMISSION;
class Program{
    public static void Main(){
        
        
            
        // Console.WriteLine("COLLEGE ADMISSION");
        // Console.WriteLine("DETIALS");
        // Console.WriteLine("ENTER YOUR NAME : ");
        // String NAME=Console.ReadLine();
        // Console.WriteLine("ENTER YOUR FATHER NAME : ");
        // String FATHERNAME=Console.ReadLine();
        // Console.WriteLine("ENTER YOUR GENDER : ");
        // String GENDER=Console.ReadLine();
        // Console.WriteLine("ENTER THE DEPARTRMENT");
        // String DEPARTMENT=Console.ReadLine();
        // Console.WriteLine("ENTER YOUR DOB : ");
        // String DOB=Console.ReadLine();
        // Console.WriteLine("ENTER YOUR CITY : ");
        // string city=Console.ReadLine();
        // Console.WriteLine("YOUR ADMISSION SUCESSFUL");
        //  Console.WriteLine("COLLEGE ADMISSION");
        // Console.WriteLine("DETIALS");
        // Console.WriteLine("ENTER YOUR NAME : ");
        // String NAME1=Console.ReadLine();
        // Console.WriteLine("ENTER YOUR FATHER NAME : ");
        // String FATHERNAME1=Console.ReadLine();
        // Console.WriteLine("ENTER YOUR GENDER : ");
        // String GENDER1=Console.ReadLine();
        // Console.WriteLine("ENTER THE DEPARTRMENT");
        // String DEPARTMENT1=Console.ReadLine();
        // Console.WriteLine("ENTER YOUR DOB : ");
        // String DOB1=Console.ReadLine();
        // Console.WriteLine("ENTER YOUR CITY : ");
        // string city1=Console.ReadLine();
        // Console.WriteLine("YOUR ADMISSION SUCESSFUL");

        //  Console.WriteLine(NAME);
        //  Console.WriteLine(FATHERNAME);
        //    Console.WriteLine(GENDER);
        //    Console.WriteLine(DEPARTMENT);
        //        Console.WriteLine(DOB);
        //          Console.WriteLine(city);
        //  Console.WriteLine(NAME1);
        //  Console.WriteLine(FATHERNAME1);
        //    Console.WriteLine(GENDER1);
        //    Console.WriteLine(DEPARTMENT1);
        //        Console.WriteLine(DOB1);
        //          Console.WriteLine(city1);        

         int Students = 5;
        
        
        string[] names = new string[Students];
        string[] fatherNames = new string[Students];
        string[] gender = new string[Students];
        string[] department = new string[Students];
        string[] dob = new string[Students];
        string[] citie = new string[Students];

        for (int i = 0; i < Students; i++)
        {
            Console.WriteLine("COLLEGE ADMISSION");
            Console.WriteLine("DETAILS");
            
            Console.WriteLine("ENTER YOUR NAME : ");
            names[i] = Console.ReadLine();
            
            Console.WriteLine("ENTER YOUR FATHER NAME : ");
            fatherNames[i] = Console.ReadLine();
            
            Console.WriteLine("ENTER YOUR GENDER : ");
            gender[i] = Console.ReadLine();
            
            Console.WriteLine("ENTER THE DEPARTMENT: ");
            department[i] = Console.ReadLine();
            
            Console.WriteLine("ENTER YOUR DOB : ");
            dob[i] = Console.ReadLine();
            
            Console.WriteLine("ENTER YOUR CITY : ");
            citie[i] = Console.ReadLine();
            
            Console.WriteLine("YOUR ADMISSION SUCCESSFUL");
            Console.WriteLine();
        }

     
        
        for (int i = 0; i < Students; i++)
        {
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

             

         
        
