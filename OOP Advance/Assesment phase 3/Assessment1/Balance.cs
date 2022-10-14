namespace Assessment1
{
    public interface IBalance
    {
        /// <summary>
        /// Property --used to store the wallet balnce
        /// </summary>
        /// <value></value>
        double WalletBalance {get;set;}
        void RechargeWallet();
        
    }
}