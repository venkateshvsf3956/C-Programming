namespace Question2
{
    public class AccountInfo:PersonalInfo
    {
        private static int s_accountNumber=1000;
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IfscCode { get; set; }
        public double Balance{get;set;}

        public AccountInfo(string aid,string name,string fatherName,Gender gender,long phone,string branchName,string ifscCode):base(aid, name,fatherName,gender,phone)
        {
            s_accountNumber++;
            AccountNumber="AID"+s_accountNumber;
            BranchName=branchName;
            IfscCode=ifscCode;


        }



        public void Deposit()
        {
            
            System.Console.WriteLine("Enter the amount to deposit:");
            double depositamount=double.Parse(Console.ReadLine());
            Balance+=depositamount;
            System.Console.WriteLine("Deposited amount:"+Balance);
        }
        public void Withdraw()
        {
            System.Console.WriteLine("Enter the amount to withdraw:");
            double withdrawAmount=double.Parse(Console.ReadLine());
            Balance-=withdrawAmount;
            System.Console.WriteLine("Withdraw Amount:"+Balance);
        }
        public void Show()
        {
            System.Console.WriteLine($"Account Number:{AccountNumber} \nBranch Name:{BranchName} \nIfsc Code:{IfscCode}");
            ShowDetail();

            System.Console.WriteLine("Balance:"+Balance);
        }
    }
}