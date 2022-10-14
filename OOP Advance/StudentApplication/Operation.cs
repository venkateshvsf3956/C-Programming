using System;

namespace StudentApplication;
public static class  Operation
{
        public static StudentDetails currentStudent=null;   
       public  static Lists<StudentDetails> studentList=new Lists<StudentDetails>();

        public static Lists<DepartmentDetails> departmentList=new Lists<DepartmentDetails>();
         
        public static Lists<AdmissionDetails> admissionList=new Lists<AdmissionDetails>();
        
        public static void MainMenu()
        {
            

            string choice="yes";
            while(choice=="yes")
            {
            System.Console.WriteLine("Select option \n1.Student Registration \n2.Student Login \n3.Check Department wise seat Eligibility \n4.Exit");
            int option=int.Parse(Console.ReadLine());
            

            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Registration\n");
                    Registration();
                
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login\n");
                    Login();
                
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Check Department wise seat availability:\n");
                    DepartmentSeatAvailability();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Exit\n");
                    choice="no";
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Enter the correct option");
                    break;
                }
            }
            }
        }

            public static void Registration()
            {
                System.Console.WriteLine("Enter Your Name:");
                string name=Console.ReadLine();
                System.Console.WriteLine("Enter your Father Name:");
                string fatherName=Console.ReadLine();
                System.Console.WriteLine("Enter Date of Birth:");
                DateTime dob=DateTime.ParseExact(Console.ReadLine(),("dd/MM/yyyy"),null);
                System.Console.WriteLine("Enter Gender:");
                Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
                System.Console.WriteLine("Enter your Physics mark:");
                int physics=int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your Chemistry mark: ");
                int chemistry=int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your Mathematics mark: ");
                int maths=int.Parse(Console.ReadLine());

                StudentDetails studentObj=new StudentDetails(name,fatherName,dob,gender,physics,chemistry,maths);
                studentList.Add(studentObj);
                System.Console.WriteLine("Register Number:"+studentObj.RegisterNumber);
              }
              public static void Login()
              {
                System.Console.WriteLine("Enter your register number:");
                string registerNumber=Console.ReadLine().ToUpper();
                
                foreach(StudentDetails student in studentList)
                {
                    if (student.RegisterNumber==registerNumber)
                    {
                        currentStudent=student;
                        System.Console.WriteLine("Login successfully\n");

                        SubMenu();

                    }

                }
              }
              public static void SubMenu()
              {
                string choice="yes";
                
                do{
                    System.Console.WriteLine("Enter your option: \na.Check Eligibility \nb.Show Detail \nc.Take Admission \nd.Cancel Admission \ne.Show Admission detail \nf.Exit");
                    string option=Console.ReadLine().ToLower();
                    switch(option)
                    {
                        case "a":
                        {
                            System.Console.WriteLine("Check Eligibilty:");
                            bool eligible=currentStudent.CheckEligibility(75.0);
                            if (eligible)
                            {
                                System.Console.WriteLine("Your are Eligible");
                            }
                            else{
                                System.Console.WriteLine("You are not eligible");
                            }
                            


                            break;
                        }
                        case "b":
                        {
                            System.Console.WriteLine("Show detail");
                            currentStudent.ShowDetail();
                            break;
                        }
                        case "c":
                        {
                            System.Console.WriteLine("Take Admission");
                            TakeAdmission();

                            break;

                        }
                        case "d":
                        {
                            System.Console.WriteLine("Cancel Admission");
                            CancelAdmission();
                            break;
                        }
                        case "e":
                        {
                            System.Console.WriteLine("Show Admission deatil");
                            ShowAdmissionDetails();
                            break;

                        }
                        case "f":
                        {
                            System.Console.WriteLine("Exit");
                            choice="no";
                            break;
                        }
                        default:
                        {
                            System.Console.WriteLine("Enter the correct option:");
                            
                            break;
                        }


                    }
                }while(choice=="yes");

              }
              public static void AddDefaultData()

              {
                StudentDetails student1=new StudentDetails("Ravichandran E","Ettapparajan",new DateTime(1999,11,11),Gender.Male,95,95,95);
                studentList.Add(student1);
                StudentDetails student2=new StudentDetails("Baskar","Sethurajan",new DateTime(1999,11,11),Gender.Male,95,95,95);
                studentList.Add(student2);
                DepartmentDetails department1=new DepartmentDetails("EEE",29);
                departmentList.Add(department1);
                DepartmentDetails department2=new DepartmentDetails("CSE",29);
                departmentList.Add(department2);
                DepartmentDetails department3=new DepartmentDetails("MECH",30);
                departmentList.Add(department3);
                DepartmentDetails department4=new DepartmentDetails("ECE",30);
                departmentList.Add(department4);
                AdmissionDetails admission1=new AdmissionDetails(student1.RegisterNumber,department1.DepartmentId,new DateTime(2022,05,11),AdmissionStatus.Booked);
                admissionList.Add(admission1);
                AdmissionDetails admission2=new AdmissionDetails(student2.RegisterNumber,department2.DepartmentId,new DateTime(2022,05,12),AdmissionStatus.Booked);
                admissionList.Add(admission2);
            
                

              }
              public static void TakeAdmission()
              {
                foreach(DepartmentDetails department in departmentList)
                {
                    System.Console.WriteLine($"Department Id is :{department.DepartmentId}\t Department Name :{department.DepartmentName} \t Number of seats: {department.NoOfSeats}");
                }
                string choosedepartment=Console.ReadLine();
                foreach(DepartmentDetails select in departmentList)
                {
                    if (select.DepartmentId==choosedepartment)
                    {
                        if(select.NoOfSeats>=1)
                        {
                            bool eligible=currentStudent.CheckEligibility(75.0);
                            if (eligible)
                            {
                                bool canAdmit=true;
                                foreach(AdmissionDetails tempStudent in admissionList)
                                {
                                    if(currentStudent.RegisterNumber==tempStudent.StudentId)
                                    {
                                        if (tempStudent.AdmissionStatus==AdmissionStatus.Booked)
                                        {
                                            System.Console.WriteLine("Student is Already booked");
                                            canAdmit=false;
                                        }

                                    }
                                }
                                if(canAdmit)
                                {
                                    foreach(DepartmentDetails tempdepartment in departmentList)
                                    {
                                        if(choosedepartment==tempdepartment.DepartmentId)
                                        {
                                            tempdepartment.NoOfSeats--;
                                            AdmissionDetails admission3=new AdmissionDetails(currentStudent.RegisterNumber,tempdepartment.DepartmentId,DateTime.Now,AdmissionStatus.Booked);
                                            admissionList.Add(admission3);
                                            System.Console.WriteLine($"Admission took successfully \n Your Admission Id :{admission3.AdmissionId}");
                                        }
                                    }
                                }
                            }

                        }
                        else{
                            System.Console.WriteLine("no seats Available");
                        }
                    }
                }
              }
              public static void CancelAdmission()
              {
                foreach(AdmissionDetails cancel in admissionList)
                {
                    if (cancel.StudentId==currentStudent.RegisterNumber)
                    {
                        cancel.AdmissionStatus=AdmissionStatus.Cancelled;
                        foreach(DepartmentDetails seat in departmentList)
                        {
                            if (cancel.DepartmentId==seat.DepartmentId)
                            {
                                seat.NoOfSeats++;
                                System.Console.WriteLine("Admission Cancelled Successfully");
                            }
                        }
                    }
                }
              }
              public static void ShowAdmissionDetails()
              {
                foreach(AdmissionDetails admissionDetail in admissionList){
                    if (currentStudent.RegisterNumber==admissionDetail.StudentId)
                    {
                        System.Console.WriteLine($"Admission Id: {admissionDetail.AdmissionId}\n Student ID:{admissionDetail.StudentId}\nDepartment Id {admissionDetail.DepartmentId}\n Admission Date{admissionDetail.AdmissionDate}\n Admission status:{admissionDetail.AdmissionStatus}");
                    }
                }
              }
              public static void DepartmentSeatAvailability()
              {
                foreach(DepartmentDetails seatAvailable in departmentList)
                {
                    System.Console.WriteLine($"Department ID {seatAvailable.DepartmentId}\tDepartment Name: {seatAvailable.DepartmentName}\t Number of seat: {seatAvailable.NoOfSeats}");
                }
              }
              
              
        
    
}