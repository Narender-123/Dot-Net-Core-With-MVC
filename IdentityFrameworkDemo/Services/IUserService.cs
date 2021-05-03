namespace IdentityFrameworkDemo.Services
{

    //To Make Dependeny Injection We have to Add this Interface and ites implementation Inside the Services
    public interface IUserService
    {
        string GetUserId();
        bool IsAuthenticated();
    }
}