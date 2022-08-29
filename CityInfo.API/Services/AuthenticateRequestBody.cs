namespace CityInfo.API.Services
{
    public class AuthenticateRequestBody
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
    public class CityUserInfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public CityUserInfo(int userId, string userName, string firstName, string lastName, string city)
        {
            UserId = userId;
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public static CityUserInfo ValidateUserCredentials(string? userName, string? password)
        {
            return new CityUserInfo(1, userName ?? "", "Ola", "Otoks", "Surrey");
        }
    }

}
