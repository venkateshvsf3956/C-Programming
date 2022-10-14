using System;
using System.IO;

namespace OnlineApplication
{
    public static class Files
    {
        public static void Create()
        {
            //Folder
            if(!Directory.Exists("OnlineOrder"))
            {
                System.Console.WriteLine("Creating folder");
                Directory.CreateDirectory("OnlineOrder");
            }
            if (!File.Exists("OnlineOrder/UserDetail.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("OnlineOrder/UserDetail.csv");
            }
            if(!File.Exists("OnlineOrder/MedicineDetail.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("OnlineOrder/MedicineDetail.csv");
            }
            if (!File.Exists("OnlineOrder/OrderDetail"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("OnlineOrder/OrderDetail.csv");
            }
            
        }
        public static void ReadFile()
        {
            //user file
            string []person=File.ReadAllLines("OnlineOrder/UserDetail.csv");
            foreach(string data  in person)
            {
                Details perons=new Details(data);
                Operation.userList.Add(perons);
            }
            //medicine file
            string []medicine=File.ReadAllLines("OnlineOrder/MedicineDetail.csv");
            foreach (string data in medicine)
            {
                Medicine medicine1=new Medicine(data);
                Operation.medicineList.Add(medicine1);
            }
            //order file
            string []order=File.ReadAllLines("OnlineOrder/OrderDetail.csv");
            foreach(string data in order)
            {
                OrderDetail order1=new OrderDetail(data);
                Operation.orderList.Add(order1);
            }

        }
        public static void WriteFile()
        {
            
        }
    }
}