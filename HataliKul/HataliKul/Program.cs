using HataliKul.Models;
using HataliKul.Services;

namespace HataliKul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cannot assign void to an implicitly-typed variable
            // implicitly-typed variable -> var sonuc
            // Cannot assign void -> Hesapla methodunun döndüğü tip void, void'i var sonuc değişkenine atayamazsın
            var sonuc = Hesapla();

            // There is no argument given that corresponds to the required parameter ‘Email’ of ‘IUserService.GetUserByTryLogin(string, string)
            var user = GetByEmailAndPassword();

            // There is no argument given that corresponds to the required parameter ‘userService’ of 'LoginForm.LoginForm(IUserService, UserService)
            var loginForm = new LoginForm();
        }

        // Bu method geriye bir sonuç/değer döndürmüyor
        static void Hesapla()
        {

        }

        static User GetByEmailAndPassword(string email, string password)
        {
            return new User();
        }
    }
}
