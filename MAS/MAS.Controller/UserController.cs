namespace MAS.Controller
{
    using DAL;
    using BusinessObject;
    /// <summary>
    /// Business Logic For User Entity
    /// CB:NA
    /// CD:12-January-2013
    /// </summary>
    public class UserController
    {
        public User VerifyUser(string userName, string password)
        {
            return new UserDal().VerifyCredentials(userName, password);
        }
    }
}
