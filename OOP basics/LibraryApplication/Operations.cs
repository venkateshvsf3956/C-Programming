using System;
using System.Collections.Generic;

namespace Library
{
    public class Operations
    {
        string currentUser="null";
        static List<Registration> registerList=new List<Registration>();
        static List<BookDetails> bookList=new List<BookDetails>();
        static List<BorrowDetails> borrowList=new List<BorrowDetails>();

        public static void AddDefaultData()
        {
            Registration person1=new Registration("Ravichandran",Gender.Male,new DateTime(2022,04,12),Department.EEE,9938388333,"ravi@gmail.com");
            registerList.Add(person1);
            Registration person2=new Registration("Priyadharshini",Gender.Female,new DateTime(2022,04,10),Department.CSE,9944444455,"priya@gmail.com");
            registerList.Add(person2);

            //book default
            BookDetails book1=new BookDetails("C#","Author1",3);
            bookList.Add(book1);
            BookDetails book2=new BookDetails("HTML","Author2",5);
            bookList.Add(book2);
            BookDetails book3=new BookDetails("CSS","Author3",3);
            bookList.Add(book3);
            BookDetails book4=new BookDetails("JS","Author4",3);
            bookList.Add(book4);
            BookDetails book5=new BookDetails("TS","Author",2);
            bookList.Add(book5);
            //Borrow default data
            BorrowDetails borrow1=new BorrowDetails(new DateTime(2022,04,12),Status.Issue);
            borrowList.Add(borrow1);
            BorrowDetails borrow2=new BorrowDetails(new DateTime(2022,04,12),Status.Returned);
            borrowList.Add(borrow2);
            BorrowDetails borrow3=new BorrowDetails(new DateTime(2022,04,15),Status.Issue);
            borrowList.Add(borrow3);
            BorrowDetails borrow4=new BorrowDetails(new DateTime(2022,04,11),Status.Returned);
            borrowList.Add(borrow4);
            BorrowDetails borrow5=new BorrowDetails(new DateTime(2022,04,15),Status.Issue);
            borrowList.Add(borrow5);

        }
        public static void MainMenu()
        {
            
            string choice="yes";
            do{
                System.Console.WriteLine("Enter the option:\n1.User Registration  \n2.User Login \n3.Exit");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("User Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("User Login");
                        SubMenu();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Enter the valid option.");
                        break;
                    }
                }

            }while(choice=="yes");

            
            
        }
        public static void Registration()
        {
            System.Console.WriteLine("Enter your name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your gender:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your Department:");
            Department department=Enum.Parse<Department>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your Mobile Number:");
            long phone=Convert.ToInt64(Console.ReadLine());
            System.Console.WriteLine("Enter your Mail Id:");
            string mailId=Console.ReadLine();
            DateTime date=DateTime.Now;
            Registration person4=new Registration(name,gender,date,department,phone,mailId);
            registerList.Add(person4);

            System.Console.WriteLine("User registration Id :"+person4.RegistrationId);
        }

        public static void SubMenu()
        {
            System.Console.WriteLine("Enter your User Id");
            string userId=Console.ReadLine().ToUpper();
            
            foreach(Registration user in registerList)
            {
                if (userId==user.RegistrationId)
                {
                    string choice="yes";
                    do {
                        System.Console.WriteLine("Enter the Option: \n1.Borrow Book \n2.Return Book \n3.Show Borrowed histroy \n4.Exit");
                        int option =int.Parse(Console.ReadLine());

                        switch(option)
                        {
                            case 1:
                            {
                                System.Console.WriteLine("Borrow Book.");
                                BorrowBook();
                                break;
                            }
                            case 2:
                            {
                                System.Console.WriteLine("Return Book");
                                ReturnBooks();
                                

                                break;
                            }
                            case 3:
                            {
                                System.Console.WriteLine("Show Borrowed Histroy");
                                
                                Histroy();
                                break;
                            }
                            case 4:
                            {
                                System.Console.WriteLine("Exit");
                                choice="no";

                                break;
                            }
                            default:
                            {
                                System.Console.WriteLine("Enter the correct option");
                                break;
                            }
                        }
                    }while(choice=="yes");
                }
            }


        }
        public static void BorrowBook()
        {
            foreach(BookDetails books in bookList)
            {
                System.Console.WriteLine($"Book ID: {books.BookId}\t Book Name:{books.BookName}\t Author Name:{books.AuthorName} \tBook Count:{books.BookCount}");
            }
            System.Console.WriteLine("Enter the Book Id to Borrow:");
            string bookid=Console.ReadLine().ToUpper();
            
            foreach (BookDetails books in bookList)
            {
                if (bookid==books.BookId)
                {
                    if (books.BookCount>1)
                    { 
                        System.Console.WriteLine("Enter your register id:");
                        string register=Console.ReadLine().ToUpper();
                        
                        foreach(Registration user in registerList)
                        {
                            if ((register==user.RegistrationId)&&(books.BookCount<=3))
                            {
                                
                                books.BookCount--;
                                System.Console.WriteLine("You borrowed the book");


                            }
                            if ((register==user.RegistrationId)&&(books.BookCount>=3))
                            {
                                
                               System.Console.WriteLine("Already issued");


                            }
                            
                        }

                    }
                    else{
                        System.Console.WriteLine("Books are not available for the selected count");
                        System.Console.WriteLine("The book will be available on 22/04/2002");
                    }
                }
            }

        }
        public static void Histroy()
        {
            foreach (BookDetails book in bookList)
            {
                System.Console.WriteLine("Borrowed books are:"+book.BookCount);
                
            }

        }
        public static void ReturnBooks()
        {
            DateTime date=DateTime.Now;
            System.Console.WriteLine("Return date:"+date.AddDays(15));

        }
        
        
    }
}