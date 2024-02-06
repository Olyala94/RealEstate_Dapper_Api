namespace RealEstate_Dapper_Api.Tools
{
    public class JwtTokenDefaults
    {
        public const string ValidAudience = "https://localhost";
        public const string ValidIssuer = "https://localhost";
        public const string Key = "RealEstate0102030405Asp.NetCore8.0.1+-*/";
        public const int Expire = 5; /*(token 5 dk ayakta kalacak)*/
    }
}
