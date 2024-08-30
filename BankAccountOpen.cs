using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{ public enum Gender1 {Male,Female}
     public class BankAccountOpen
    {   private static int _CustomerID=1000;
       public string Name{get;set;}
       public double Balance{get;set;}
       public string MailId{get;set;}
       public DateTime DateOfBirth{get;set;}
       public Gender1 Gender{get;set;}
       public string CustomerID{get;set;}

       public BankAccountOpen(string customername,double balance,string mailid,DateTime dateofbirth,Gender1 gender)
       {
        Name=customername;
        Balance=balance;
        MailId=mailid;
        DateOfBirth=dateofbirth;
        gender=Gender;
        CustomerID="HDFC" + ++_CustomerID;
       }
        
    }
}