namespace GastroManagerBE.HttpRequest
{
    public class UserCreateRequest
    {
        public string username { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
    }
}
