using HataliKul.Models;
using HataliKul.Services;

namespace HatasizKul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cannot assign void to an implicitly-typed variable
            var sonuc = Hesapla();

            //There is no argument given that corresponds to the required parameter ‘Email’ of ‘IUserService.GetUserByTryLogin(string, string)’
            string email = "test@test.com";
            string password = "password";
            var user = GetByEmailAndPassword(email, password);

            // There is no argument given that corresponds to the required parameter ‘userService’ of 'LoginForm.LoginForm(IUserService, UserService)
            var userService = new UserService();
            var loginForm = new LoginForm(userService);
        }

        static int Hesapla()
        {
            return 0;
        }

        static User GetByEmailAndPassword(string email, string password)
        {
            return new User();
        }
    }
}
