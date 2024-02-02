namespace RealEstate_Dapper_Api.Tools
{
    public class TokenResponseViewModel
    {
        public TokenResponseViewModel(int token, DateTime expireDate)
        {
            Token = token;
            ExpireDate = expireDate;
        }

        public int Token { get; set; }
        public DateTime ExpireDate { get; set; } 
    }
}
