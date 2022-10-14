using System;
namespace Assessment1
{
    public  class UserDetail:PersonalDetail,IBalance
    {
        /// <summary>
        /// Field ,is used to store Id
        /// </summary>
        private static int s_userId=1000;
        /// <summary>
        /// Property --used to store the userId
        /// </summary>
        /// <value></value>
        public string UserId { get; set; }
        /// <summary>
        /// Property --used to store the wallet balance
        /// </summary>
        /// <value></value>
        public double WalletBalance { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>used to name of the user
        /// <param name="age"></param>used to age of the user
        /// <param name="mobileNumber"></param>used to mobile number  of the user
        /// <returns></returns>

        public UserDetail(string name,int age,long mobileNumber):base(name,age,mobileNumber)
        {
            s_userId++;
            UserId="UID"+s_userId;
            

            
        }
        public UserDetail(string data)
        {
            string[]value=data.Split(',');
            s_userId=int.Parse(value[0].Remove(0,3));
            UserId=value[0];
            Name=value[1];
            Age=int.Parse(value[2]);
            MobileNumber=long.Parse(value[3]);

        }
        
        public void RechargeWallet()
        {
            System.Console.WriteLine("Enter the amount to recharge:");
            double amount=double.Parse(Console.ReadLine());
            WalletBalance+=amount;
            System.Console.WriteLine("your wallet balance is:"+WalletBalance);


        }
    }
}