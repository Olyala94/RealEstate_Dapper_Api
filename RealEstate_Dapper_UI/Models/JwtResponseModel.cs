namespace RealEstate_Dapper_UI.Models
{
    public class JwtResponseModel
    {
        //Tokenın kendisi tutacak 
        public string Token { get; set; }

        //Tokenın son geçerlilik  tarihini tutyor olacak
        public DateTime ExpireDate { get; set; }
    }
}
