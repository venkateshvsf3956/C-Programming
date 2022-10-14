using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        AccountInfo person=new AccountInfo("5678","Venkat","Vaithi",Gender.Male,98765436,"Nungabakam","CNRB10001");
        person.Show();
        person.Deposit();
        person.Withdraw();
        
    }
}